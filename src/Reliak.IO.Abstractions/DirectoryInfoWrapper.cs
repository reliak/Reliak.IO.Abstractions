using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Reliak.IO.Abstractions
{
    internal class DirectoryInfoWrapper : FileSystemInfoWrapper, IDirectoryInfo
    {
        private readonly DirectoryInfo _directoryInfo;

        public DirectoryInfoWrapper(DirectoryInfo directoryInfo)
            : base(directoryInfo)
        {
            _directoryInfo = directoryInfo;
        }

        public IDirectoryInfo Parent
        {
            get
            {
                return new DirectoryInfoWrapper(_directoryInfo.Parent);
            }
        }

        public IDirectoryInfo Root
        {
            get
            {
                return new DirectoryInfoWrapper(_directoryInfo.Root);
            }
        }

        public void Create()
        {
            _directoryInfo.Create();
        }

        public IDirectoryInfo CreateSubdirectory(string path)
        {
            return new DirectoryInfoWrapper(_directoryInfo.CreateSubdirectory(path));
        }
        
        public void Delete(bool recursive)
        {
            _directoryInfo.Delete(recursive);
        }

        public IEnumerable<IDirectoryInfo> EnumerateDirectories()
        {
            return _directoryInfo.EnumerateDirectories().Select(f => new DirectoryInfoWrapper(f));
        }

        public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern)
        {
            return _directoryInfo.EnumerateDirectories(searchPattern).Select(f => new DirectoryInfoWrapper(f));
        }

        public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption)
        {
            return _directoryInfo.EnumerateDirectories(searchPattern, searchOption).Select(f => new DirectoryInfoWrapper(f));
        }

        public IEnumerable<IFileInfo> EnumerateFiles()
        {
            return _directoryInfo.EnumerateFiles().Select(f => new FileInfoWrapper(f));
        }

        public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern)
        {
            return _directoryInfo.EnumerateFiles(searchPattern).Select(f => new FileInfoWrapper(f));
        }

        public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption)
        {
            return _directoryInfo.EnumerateFiles(searchPattern, searchOption).Select(f => new FileInfoWrapper(f));
        }

        public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos()
        {
            return _directoryInfo.EnumerateFileSystemInfos().Select(f => new FileSystemInfoWrapper(f));
        }

        public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern)
        {
            return _directoryInfo.EnumerateFileSystemInfos(searchPattern).Select(f => new FileSystemInfoWrapper(f));
        }

        public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption)
        {
            return _directoryInfo.EnumerateFileSystemInfos(searchPattern, searchOption).Select(f => new FileSystemInfoWrapper(f));
        }

        public IDirectoryInfo[] GetDirectories()
        {
            return _directoryInfo.GetDirectories().Select(f => new DirectoryInfoWrapper(f)).ToArray();
        }

        public IDirectoryInfo[] GetDirectories(string searchPattern)
        {
            return _directoryInfo.GetDirectories(searchPattern).Select(f => new DirectoryInfoWrapper(f)).ToArray();
        }

        public IDirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption)
        {
            return _directoryInfo.GetDirectories(searchPattern, searchOption).Select(f => new DirectoryInfoWrapper(f)).ToArray();
        }

        public IFileInfo[] GetFiles()
        {
            return _directoryInfo.GetFiles().Select(f => new FileInfoWrapper(f)).ToArray();
        }

        public IFileInfo[] GetFiles(string searchPattern)
        {
            return _directoryInfo.GetFiles(searchPattern).Select(f => new FileInfoWrapper(f)).ToArray();
        }

        public IFileInfo[] GetFiles(string searchPattern, SearchOption searchOption)
        {
            return _directoryInfo.GetFiles(searchPattern, searchOption).Select(f => new FileInfoWrapper(f)).ToArray();
        }

        public IFileSystemInfo[] GetFileSystemInfos()
        {
            return _directoryInfo.GetFileSystemInfos().Select(f => new FileSystemInfoWrapper(f)).ToArray();
        }

        public IFileSystemInfo[] GetFileSystemInfos(string searchPattern)
        {
            return _directoryInfo.GetFileSystemInfos(searchPattern).Select(f => new FileSystemInfoWrapper(f)).ToArray();
        }

        public IFileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption)
        {
            return _directoryInfo.GetFileSystemInfos(searchPattern, searchOption).Select(f => new FileSystemInfoWrapper(f)).ToArray();
        }

        public void MoveTo(string destDirName)
        {
            _directoryInfo.MoveTo(destDirName);
        }

        public override string ToString()
        {
            return _directoryInfo.ToString();
        }
    }
}