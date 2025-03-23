using System;
using System.IO;

namespace OpenUI.Platform.Storage
{
	public class StorageObject : IStorageItem 
	{
		public string Name { get; private set; }
		public string Path { get; private set; }

		public StorageObject(string path) 
		{
			if (!this.Exists(path)){
				throw new ArgumentException("Invalid file or folder path.", nameof(path));
			} else {
				Path = path;
				Name = System.IO.Path.GetFileName(path);
			}
		}

		public bool Exists()
		{
			return File.Exists(Path) || Directory.Exists(Path);
		}

		private bool Exists(string path)
		{
			return File.Exists(path) || Directory.Exists(path);
		}

		public long GetSize() => 1;
		public void Dispose()
		{
		}

		private bool IsValidPath(string path)
		{
			try
			{
				return System.IO.Path.GetFullPath(path) == path;
			}
			catch
			{
				return false;
			}
		}
	}
}
