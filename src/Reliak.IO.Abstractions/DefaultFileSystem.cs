using System.IO;

namespace Reliak.IO.Abstractions
{
    /// <summary>
    /// Default implementation of the <see cref="System.IO"/> filesystem entities
    /// </summary>
    public class DefaultFileSystem : IFileSystem
    {
        public IDirectory Directory { get; protected set; }
        public IFile File { get; protected set; }

        public DefaultFileSystem()
            : this(new FileWrapper(), new DirectoryWrapper())
        {}

        protected DefaultFileSystem(IFile file, IDirectory directory)
        {
            File = file;
            Directory = directory;
        }
        
        public virtual IDirectoryInfo GetDirectoryInfo(string path)
        {
            return new DirectoryInfoWrapper(new DirectoryInfo(path));
        }

        public virtual IDriveInfo GetDriveInfo(string driveName)
        {
            return new DriveInfoWrapper(new DriveInfo(driveName));
        }

        public virtual IFileInfo GetFileInfo(string filename)
        {
            return new FileInfoWrapper(new FileInfo(filename));
        }
    }
}