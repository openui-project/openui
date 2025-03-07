using OpenUI;

public static class Program {
	public static void Main(string[] args) {
		var game = new GameWindow(800, 600, "Simpile Example");
		game.DrawText("Hello, World!", 50, 50, 18, System.Drawing.Color.Red);
		game.Show();
	}
}