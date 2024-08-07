﻿using droneDockDataCenter.Controls;
using log4net;
using log4net.Repository.Hierarchy;
using System;
using System.Threading;

namespace droneDockDataCenter.Modle
{
    public class Gimbal
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(DockDetailPanel));

        //TCP客户端
        public AsyncTcpClient AsyncTcpClient1;

        public Gimbal() 
        {
            AsyncTcpClient1 = new AsyncTcpClient();
        }

        public string ControlIP { get; set; } = "127.0.0.1";
        public int ControlPort { get; set; } = 2000;

        public bool TCPisConneted { get { return AsyncTcpClient1.Connected; } }


        public void connectViaTCP()
        {
            if (!AsyncTcpClient1.Connected)
            {
                AsyncTcpClient1.Connect(ControlIP, ControlPort);
                AsyncTcpClient1.DataReceived += AsyncTcpClient1_MessageReceived;
                AsyncTcpClient1.ISConnected += AsyncTcpClient1_ISConnected;
                logger.Info($"Connect via TCP address:{ControlIP} port:{ControlPort}");
            }
        }

        public void disconnectViaTCP()
        {
            if (AsyncTcpClient1.Connected)
            {
                AsyncTcpClient1.DataReceived -= AsyncTcpClient1_MessageReceived;
                AsyncTcpClient1.ISConnected -= AsyncTcpClient1_ISConnected;
                AsyncTcpClient1.Disconnect();
                logger.Info($"Disconnect via TCP");

            }
        }
        public void ControlDown()
        {
            byte[] data = new byte[] { 0xeb, 0x90, 0x14, 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 00, 00, 0xFC, 0x18, 00, 00, 00, 00, 00, 00, 00, 00, 00, 0xC4, 0xf5 };
            AsyncTcpClient1.SendHex(data);
        }


        public void ControlUp()
        {
            byte[] data = new byte[] { 0xeb, 0x90, 0x14, 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 00, 00, 0x03, 0xE8, 00, 00, 00, 00, 00, 00, 00, 00, 00, 0xCB, 0xd3 };
            AsyncTcpClient1.SendHex(data);
        }
        public void ControlLeft()
        {
            byte[] data = new byte[] { 0xeb, 0x90, 0x14, 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 0xFC, 0x18, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 0xC4, 0xf5 };
            AsyncTcpClient1.SendHex(data);
        }
        public void ControlRight()
        {
            byte[] data = new byte[] { 0xeb, 0x90, 0x14, 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 0x03, 0xE8, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 0xCB, 0xd3 };
            AsyncTcpClient1.SendHex(data);
        }
        public void ControlStop()
        {
            //send stop 
            byte[] data = new byte[] { 0xeb, 0x90, 0x14, 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x01, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 0x20, 0x3d };
            AsyncTcpClient1.SendHex(data);
        }

        public void ControlStopZoom()
        {
            byte[] data = new byte[] { 0xeb, 0x90, 0x14, 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0F, 00, 00, 00, 00, 00, 00, 00, 00, 00, 0x40, 00, 00, 00, 0x6E, 0xd9 };


            AsyncTcpClient1.SendHex(data);
        }
        public void ControlZoomIn()
        {
            byte[] data = new byte[] { 0xeb, 0x90, 0x14, 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0F, 00, 00, 00, 00, 00, 00, 00, 00, 0x02, 0x78, 00, 00, 00, 0x54, 0xf9 };

            AsyncTcpClient1.SendHex(data);
        }
        public void ControlZoomOut()
        {
            byte[] data = new byte[] { 0xeb, 0x90, 0x14, 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0F, 00, 00, 00, 00, 00, 00, 00, 00, 0x02, 0x38, 00, 00, 00, 0x14, 0x79 };

            AsyncTcpClient1.SendHex(data);
        }
        public void ControlZoomStop()
        {
            byte[] data = new byte[] { 0xeb, 0x90, 0x14, 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0F, 00, 00, 00, 00, 00, 00, 00, 00, 00, 0x40, 00, 00, 00, 0x6E, 0xd9 };

            AsyncTcpClient1.SendHex(data);
        }
        public void ControlCenter()
        {
            byte[] data = new byte[] { 0xeb, 0x90, 0x14, 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x04, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 0x25, 0x45 };

            AsyncTcpClient1.SendHex(data);
        }
        public void SendHeartBeat()
        {
            byte[] data = new byte[] { 0xeb, 0x90, 0x07, 0x55, 0xAA, 0xDC, 0x04, 0x10, 0x00, 0x14, 0x03 };
            AsyncTcpClient1.SendHex(data);

        }


        int IRindex = 0;
        public void SwitchIR()
        {
            byte[] data = new byte[] { 0xeb, 0x90, 0x14, 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0x81, 0x00, 0x00, 0x00, 0xAC, 0x5B };
            switch (IRindex)
            {
                case 0:
                    data = new byte[] { 0xeb, 0x90, 0x14, 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0x81, 0x00, 0x00, 0x00, 0xAC, 0x5B };
                    break;
                case 1:
                    data = new byte[] { 0xeb, 0x90, 0x14, 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0x83, 0x00, 0x00, 0x00, 0xAE, 0x5F };
                    break;
                case 2:
                    data = new byte[] { 0xeb, 0x90, 0x14, 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0x84, 0x00, 0x00, 0x00, 0xA9, 0x5B };
                    break;
                case 3:
                    data = new byte[] { 0xeb, 0x90, 0x14, 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0x82, 0x00, 0x00, 0x00, 0xAF, 0x5F };
                    break;
                case 4:
                    data = new byte[] { 0xeb, 0x90, 0x14, 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0xC1, 0x00, 0x00, 0x00, 0xEC, 0xDB };
                    break;
                case 5:
                    data = new byte[] { 0xeb, 0x90, 0x14, 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0xC3, 0x00, 0x00, 0x00, 0xEE, 0xDF };
                    break;
                case 6:
                    data = new byte[] { 0xeb, 0x90, 0x14, 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0xC4, 0x00, 0x00, 0x00, 0xE9, 0xDB };
                    break;
                case 7:
                    data = new byte[] { 0xeb, 0x90, 0x14, 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0xC2, 0x00, 0x00, 0x00, 0xEF, 0xDF };
                    break;
                case 8:
                    data = new byte[] { 0xeb, 0x90, 0x14, 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0F, 0x1F, 0xFE, 0x0E, 0x38, 0x00, 0x00, 0x00, 0x00, 0x04, 0x81, 0x00, 0x00, 0x00, 0x7C, 0x8F };
                    break;
                case 9:
                    data = new byte[] { 0xeb, 0x90, 0x14, 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0F, 0x1F, 0xFE, 0x0E, 0x38, 0x00, 0x00, 0x00, 0x00, 0x04, 0x83, 0x00, 0x00, 0x00, 0x7E, 0x93 };
                    break;
                case 10:
                    data = new byte[] { 0xeb, 0x90, 0x14, 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0F, 0x1F, 0xFE, 0x0E, 0x38, 0x00, 0x00, 0x00, 0x00, 0x04, 0x84, 0x00, 0x00, 0x00, 0x79, 0x8F };
                    break;
                case 11:
                    data = new byte[] { 0xeb, 0x90, 0x14, 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0F, 0x1F, 0xFE, 0x0E, 0x38, 0x00, 0x00, 0x00, 0x00, 0x04, 0x82, 0x00, 0x00, 0x00, 0x7F, 0x93 };
                    break;
                default:
                    break;
            }

            IRindex++;
            if(IRindex ==12)
            {
                IRindex = 0;
            }
            AsyncTcpClient1.SendHex(data);
        }
        public void TackPic()
        {
            byte[] data = new byte[] { 0xeb, 0x90, 0x14, 0x55, 0xAA, 0xDC, 0x11, 0x30, 0x0F, 00, 00, 00, 00, 00, 00, 00, 00, 04, 0xD0, 00, 00, 00, 0xFA, 0xF9 };
            AsyncTcpClient1.SendHex(data);
        }


        public bool IsConnected { get; set; }
        private void AsyncTcpClient1_ISConnected(object sender, bool e)
        {
            IsConnected = e;
        }

        private void AsyncTcpClient1_MessageReceived(object sender, byte[] message)
        {
            try
            {
                //解析云台
                bool isHeaderMatched = message.Length >= 3 &&
                           message[0] == 0x55 &&
                           message[1] == 0xAA &&
                           message[2] == 0xDC;

                if (!isHeaderMatched)
                    return;

                byte value1 = (byte)(message[32]);
                byte value2 = (byte)(message[33] + 1);

                Int16 p1 = BitConverter.ToInt16(message, 32);
                // 将两个元素转换为 Int16 类型
                Single pitch = (Single)(BitConverter.ToInt16(new byte[] { value2, value1 }, 0)) * 360 / 65536;

                byte value3 = (byte)(message[30]);
                byte value4 = (byte)(message[31] + 1);

                Single yaw = (Single)(BitConverter.ToInt16(new byte[] { value4, value3 }, 0)) * 360 / 65536;

                byte zoomByte1 = message[44];
                byte zoomByte2 = message[45];

                Single zoom = (Single)BitConverter.ToUInt16(new byte[] { zoomByte2, zoomByte1 }, 0) / 10;
                Pitch = pitch;
                Yaw = yaw;
                Zoom = zoom;
            }
            catch
            {

            }
        }


        public float Pitch { get; set; }

        public float Yaw { get; set; }
        public float Zoom { get; set; }

        public string VideoRtspAddress { get; set; }

    }
}
