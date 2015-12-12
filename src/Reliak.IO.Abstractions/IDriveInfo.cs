using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Reliak.IO.Abstractions
{
    public interface IDriveInfo
    {
        long AvailableFreeSpace { get; }
        string DriveFormat { get; }
        DriveType DriveType { get; }
        bool IsReady { get; }
        string Name { get; }
        IDirectoryInfo RootDirectory { get; }
        long TotalFreeSpace { get; }
        long TotalSize { get; }
        string VolumeLabel { get; set; }
    }
}