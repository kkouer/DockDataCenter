using DSkin.Forms;
using System;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace droneDockDataCenter.Modle
{
    public class FTPClient
    {
        public static void UploadFile(string ftpServer, string username, string password, string filePath)
        {
            try
            {
                // 获取文件名 
                string fileName = Path.GetFileName(filePath);

                // 创建FTP请求
                string ftpUrl = $"ftp://{ftpServer}/{fileName}";
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpUrl);
                request.Method = WebRequestMethods.Ftp.UploadFile;

                // 提供登录凭据
                request.Credentials = new NetworkCredential(username, password);

                // 读取要上传的文件
                byte[] fileContents = File.ReadAllBytes(filePath);
                request.ContentLength = fileContents.Length;

                // 上传文件到FTP服务器
                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(fileContents, 0, fileContents.Length);
                }

                // 获取服务器响应
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    DSkinMessageBox.Show("文件已经上传, 状态{response.StatusDescription}");
                }
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ConnectFailure)
                {
                    DSkinMessageBox.Show("错误: 连接 FTP 服务器失败.");
                }
                else
                {
                    DSkinMessageBox.Show($"错误: {ex.Message}");
                }
            }
        }

        public static void CompressFile(string filePath, string zipPath)
        {
            using (FileStream zipToOpen = new FileStream(zipPath, FileMode.Create))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Create))
                {
                    archive.CreateEntryFromFile(filePath, Path.GetFileName(filePath));
                }
            }
        }
    }
}
