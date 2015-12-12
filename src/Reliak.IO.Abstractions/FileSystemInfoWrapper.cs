using System;
using System.IO;

namespace Reliak.IO.Abstractions
{
    internal class FileSystemInfoWrapper : IFileSystemInfo
    {
        private readonly FileSystemInfo _fileSystemInfo;

        public FileSystemInfoWrapper(FileSystemInfo fileSystemInfo)
        {
            _fileSystemInfo = fileSystemInfo;
        }

        public FileAttributes Attributes
        {
            get
            {
                return _fileSystemInfo.Attributes;
            }
            set
            {
                _fileSystemInfo.Attributes = value;
            }
        }

        public DateTime CreationTime
        {
            get
            {
                return _fileSystemInfo.CreationTime;
            }

            set
            {
                _fileSystemInfo.CreationTime = value;
            }
        }

        public DateTime CreationTimeUtc
        {
            get
            {
                return _fileSystemInfo.CreationTimeUtc;
            }

            set
            {
                _fileSystemInfo.CreationTimeUtc = value;
            }
        }

        public bool Exists
        {
            get
            {
                return _fileSystemInfo.Exists;
            }
        }

        public string Extension
        {
            get
            {
                return _fileSystemInfo.Extension;
            }
        }

        public string FullName
        {
            get
            {
                return _fileSystemInfo.FullName;
            }
        }

        public DateTime LastAccessTime
        {
            get
            {
                return _fileSystemInfo.LastAccessTime;
            }

            set
            {
                _fileSystemInfo.LastAccessTime = value;
            }
        }

        public DateTime LastAccessTimeUtc
        {
            get
            {
                return _fileSystemInfo.LastAccessTimeUtc;
            }

            set
            {
                _fileSystemInfo.LastAccessTimeUtc = value;
            }
        }

        public DateTime LastWriteTime
        {
            get
            {
                return _fileSystemInfo.LastWriteTime;
            }

            set
            {
                _fileSystemInfo.LastWriteTime = value;
            }
        }

        public DateTime LastWriteTimeUtc
        {
            get
            {
                return _fileSystemInfo.LastWriteTimeUtc;
            }

            set
            {
                _fileSystemInfo.LastWriteTimeUtc = value;
            }
        }

        public string Name
        {
            get
            {
                return _fileSystemInfo.Name;
            }
        }

        public void Delete()
        {
            _fileSystemInfo.Delete();
        }

        public void Refresh()
        {
            _fileSystemInfo.Refresh();
        }

        public override string ToString()
        {
            return _fileSystemInfo.ToString();
        }
    }
}