namespace Reliak.IO.Abstractions
{
    public interface IFileSystem
    {
        IFile File { get; }
        IDirectory Directory { get; }

        IFileInfo GetFileInfo(string filename);
        IDriveInfo GetDriveInfo(string driveName);
        IDirectoryInfo GetDirectoryInfo(string path);
    }
}