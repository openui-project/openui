using System;

namespace OpenUI.Platform.Storage
{
	public interface IStorageItem : IDisposable
	{
		/// <summary>
		/// Gets the name of the item.
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Gets the file-system path of the item.
		/// </summary>
		string Path { get; }

		bool IsFolder { get; }

		/// <summary>
		/// Gets the size of the storage item in bytes.
		/// </summary>
		/// <returns>Size of the item in bytes.</returns>
		long GetSize();

		bool Exists();
	}}
