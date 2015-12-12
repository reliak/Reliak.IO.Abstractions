# Reliak.IO.Abstractions
Provides interface abstractions for `System.IO` filesystem entities. Also provides a default implementation of
`IFileSystem` that provides the default behavior of the `System.IO` implementations.

The `IFileSystem` interface:
```
public interface IFileSystem
{
	IFile File { get; }
	IDirectory Directory { get; }

	IFileInfo GetFileInfo(string filename);
	IDriveInfo GetDriveInfo(string driveName);
	IDirectoryInfo GetDirectoryInfo(string path);
}
```

### Installation / NuGet package
Install via NuGet Packagemanager:
```
PM> Install-Package Reliak.IO.Abstractions
```

### Exemplary usage
```
// using default implementation
IFileSystem fs = new DefaultFileSystem();
string someDirectory = "c:\\...";

if(!fs.Directory.Exists(someDirectory))
{
	IDirectoryInfo di = fs.Directory.CreateDirectory(someDirectory);
	Console.WriteLine(di.FullName);
}
```

### License
https://opensource.org/licenses/MIT