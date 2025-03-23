using System;
using OpenUI;
using OpenUI.Platform.Storage;

public static class Program
{
	public static void Main(string[] args)
	{
		try {
			using (IStorageItem file = new StorageObject("test.txt")) 
			{
				Console.WriteLine($"File Exists: {file.Exists()}");
			}
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine($"Error: {ex.Message}");
		}
	}
}
