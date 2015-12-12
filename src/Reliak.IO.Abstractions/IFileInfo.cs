using System.IO;
using System.Security.AccessControl;

namespace Reliak.IO.Abstractions
{
    public interface IFileInfo : IFileSystemInfo
    {
        IDirectoryInfo Directory { get; }
        string DirectoryName { get; }
        bool IsReadOnly { get; set; }
        long Length { get; }
        StreamWriter AppendText();
        IFileInfo CopyTo(string destFileName);
        IFileInfo CopyTo(string destFileName, bool overwrite);
        FileStream Create();
        StreamWriter CreateText();
        void MoveTo(string destFileName);
        FileStream Open(FileMode mode);
        FileStream Open(FileMode mode, FileAccess access);
        FileStream Open(FileMode mode, FileAccess access, FileShare share);
        FileStream OpenRead();
        StreamReader OpenText();
        FileStream OpenWrite();

        void SetAccessControl(FileSecurity fileSecurity);
        FileSecurity GetAccessControl();
        FileSecurity GetAccessControl(AccessControlSections includeSections);
    }
}