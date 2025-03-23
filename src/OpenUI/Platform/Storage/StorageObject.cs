using System;
using System.IO;

namespace OpenUI.Platform.Storage
{
	public class StorageObject : IStorageItem 
	{
		public string Name { get; private set; }
		public string Path { get; private set; }
		public bool IsFolder { get; private set; }

		public StorageObject(string path) 
		{
			if (!this.Exists(path)){
				throw new ArgumentException("Invalid file or folder path.", nameof(path));
			} else {
				Path = path;
				Name = System.IO.Path.GetFileName(path);
				IsFolder = Directory.Exists(path);
			}
		}

		public bool Exists() => IsFolder ? Directory.Exists(Path) : File.Exists(Path);

		private bool Exists(string path)
		{
			return File.Exists(path) || Directory.Exists(path);
		}

		public long GetSize()
		{
			// if (!Exists()) return 0;

			if (!IsFolder) return new FileInfo(Path).Length;

			long size = 0;
			foreach (var file in Directory.GetFiles(Path, "*", SearchOption.AllDirectories))
				size += new FileInfo(file).Length;

			return size;
		}

		public void Dispose() { }
	}
}
