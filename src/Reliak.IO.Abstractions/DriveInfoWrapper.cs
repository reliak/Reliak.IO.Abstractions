using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Reliak.IO.Abstractions
{
    internal class DriveInfoWrapper : IDriveInfo
    {
        private readonly DriveInfo _driveInfo;

        public DriveInfoWrapper(DriveInfo driveInfo)
        {
            _driveInfo = driveInfo;
        }

        public long AvailableFreeSpace
        {
            get
            {
                return _driveInfo.AvailableFreeSpace;
            }
        }

        public string DriveFormat
        {
            get
            {
                return _driveInfo.DriveFormat;
            }
        }

        public DriveType DriveType
        {
            get
            {
                return _driveInfo.DriveType;
            }
        }

        public bool IsReady
        {
            get
            {
                return _driveInfo.IsReady;
            }
        }

        public string Name
        {
            get
            {
                return _driveInfo.Name;
            }
        }

        public IDirectoryInfo RootDirectory
        {
            get
            {
                return new DirectoryInfoWrapper(_driveInfo.RootDirectory);
            }
        }

        public long TotalFreeSpace
        {
            get
            {
                return _driveInfo.TotalFreeSpace;
            }
        }

        public long TotalSize
        {
            get
            {
                return _driveInfo.TotalSize;
            }
        }

        public string VolumeLabel
        {
            get
            {
                return _driveInfo.VolumeLabel;
            }

            set
            {
                _driveInfo.VolumeLabel = value;
            }
        }
    }
}