using OpenUI;
using OpenUI.Mathematics;

public static class Program {
	public static void Main(string[] args) {
		var view = new ViewPort(800, 600, "Simpile Example");
		view.Run();
		Vector2 position = view.GetWindowPosition();
		Console.WriteLine(position);
	}
}
