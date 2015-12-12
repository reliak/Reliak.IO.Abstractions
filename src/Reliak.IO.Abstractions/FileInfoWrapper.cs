using System.IO;
using System.Security.AccessControl;

namespace Reliak.IO.Abstractions
{
    internal class FileInfoWrapper : FileSystemInfoWrapper, IFileInfo
    {
        private readonly FileInfo _fileInfo;

        public FileInfoWrapper(FileInfo fileInfo)
            : base(fileInfo)
        {
            _fileInfo = fileInfo;
        }

        public IDirectoryInfo Directory
        {
            get
            {
                return new DirectoryInfoWrapper(_fileInfo.Directory);
            }
        }

        public string DirectoryName
        {
            get
            {
                return _fileInfo.DirectoryName;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return _fileInfo.IsReadOnly;
            }

            set
            {
                _fileInfo.IsReadOnly = value;
            }
        }

        public long Length
        {
            get
            {
                return _fileInfo.Length;
            }
        }

        public StreamWriter AppendText()
        {
            return _fileInfo.AppendText();
        }

        public IFileInfo CopyTo(string destFileName)
        {
            return new FileInfoWrapper(_fileInfo.CopyTo(destFileName));
        }

        public IFileInfo CopyTo(string destFileName, bool overwrite)
        {
            return new FileInfoWrapper(_fileInfo.CopyTo(destFileName, overwrite));
        }

        public FileStream Create()
        {
            return _fileInfo.Create();
        }

        public StreamWriter CreateText()
        {
            return _fileInfo.CreateText();
        }

        public void MoveTo(string destFileName)
        {
            _fileInfo.MoveTo(destFileName);
        }

        public FileStream Open(FileMode mode)
        {
            return _fileInfo.Open(mode);
        }

        public FileStream Open(FileMode mode, FileAccess access)
        {
            return _fileInfo.Open(mode, access);
        }

        public FileStream Open(FileMode mode, FileAccess access, FileShare share)
        {
            return _fileInfo.Open(mode, access, share);
        }

        public FileStream OpenRead()
        {
            return _fileInfo.OpenRead();
        }

        public StreamReader OpenText()
        {
            return _fileInfo.OpenText();
        }

        public FileStream OpenWrite()
        {
            return _fileInfo.OpenWrite();
        }

        public void SetAccessControl(FileSecurity fileSecurity)
        {
            _fileInfo.SetAccessControl(fileSecurity);
        }

        public FileSecurity GetAccessControl()
        {
            return _fileInfo.GetAccessControl();
        }

        public FileSecurity GetAccessControl(AccessControlSections includeSections)
        {
            return _fileInfo.GetAccessControl(includeSections);
        }

        public override string ToString()
        {
            return _fileInfo.ToString();
        }
    }
}