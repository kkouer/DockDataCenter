using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;

namespace droneDockDataCenter.Modle
{
    public class AsyncTcpClient
    {
        private TcpClient client;
        private NetworkStream stream;

        public bool Connected
        {
            get
            {
                if (client != null)
                {
                    return client.Connected;
                }
                else
                {
                    return false;
                }
            }
        }
        public void Disconnect()
        {
            if (client != null)
            {
                client.Close();
                client = null;
                ISConnected?.Invoke(this, false);

            }
        }



        public event EventHandler<byte[]> DataReceived;
        public event EventHandler<bool> ISConnected;

        public void Connect(string ipAddress, int port)
        {
            client = new TcpClient();
            client.BeginConnect(ipAddress, port, new AsyncCallback(ConnectCallback), null);
        }

        private void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                client.EndConnect(ar);
                stream = client.GetStream();
                ISConnected?.Invoke(this, true);
                WaitForData();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
        }

        private void WaitForData()
        {
            byte[] buffer = new byte[1024];
            stream.BeginRead(buffer, 0, buffer.Length, new AsyncCallback(ReadCallback), buffer);
        }

        private void ReadCallback(IAsyncResult ar)
        {
            try
            {
                int bytesRead = stream.EndRead(ar);
                if (bytesRead > 0)
                {
                    byte[] buffer = (byte[])ar.AsyncState;
                    OnDataReceived(buffer);
                    WaitForData();
                }
                else
                {
                    client.Close();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
        }

        private void OnDataReceived(byte[] data)
        {
            DataReceived?.Invoke(this, data);
        }

        public void Send(string data)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            stream.BeginWrite(buffer, 0, buffer.Length, new AsyncCallback(SendCallback), null);
        }

        public void SendHex(byte[] data)
        {
            if (stream != null && stream.CanWrite)
            {
                stream.BeginWrite(data, 0, data.Length, new AsyncCallback(SendCallback), null);
            }
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                stream.EndWrite(ar);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
        }
    }
}

