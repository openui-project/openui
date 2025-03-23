using System;
using OpenUI;
using OpenUI.Platform.Storage;

public static class Program
{
	public static void Main(string[] args)
	{
		try {
			using (IStorageItem file = new FileObject("test.txt")) 
			{
				Console.WriteLine($"Name: {file.Name}");
				Console.WriteLine($"Path: {file.Path}");
				Console.WriteLine($"File Exists: {file.Exists()}");
				Console.WriteLine($"File Size: { file.GetSize() }");
			}
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine($"Error: {ex.Message}");
		}
	}
}
