using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.IO;

namespace XpBlog
{
    internal class Pubish_SFTP
    {
        private readonly SftpClient _sftp;

        public Pubish_SFTP(ConnectionInfo connectionInfo)
        {
            _sftp = new SftpClient(connectionInfo);
            _sftp.Connect();
        }

        public void UploadDirectory(string localPath, string remotePath)
        {
            Console.WriteLine("Uploading directory {0} to {1}", localPath, remotePath);

            IEnumerable<FileSystemInfo> infos =
                new DirectoryInfo(localPath).EnumerateFileSystemInfos();
            foreach (FileSystemInfo info in infos)
            {
                string subPath = Path.Combine(remotePath, info.Name);
                if (info.Attributes.HasFlag(FileAttributes.Directory))
                {
                    if (!_sftp.Exists(subPath))
                        _sftp.CreateDirectory(subPath);
                    UploadDirectory(info.FullName, subPath);
                }
                else
                {
                    using var fileStream = new FileStream(info.FullName, FileMode.Open);
                    Console.WriteLine(
                        "Uploading {0} ({1:N0} bytes)",
                        info.FullName, ((FileInfo)info).Length);
                    _sftp.UploadFile(fileStream, subPath);
                }
            }
        }
    }
}