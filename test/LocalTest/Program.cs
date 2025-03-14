using System;
using OpenUI.Mathematics;

namespace OpenUI {
    public static class Program {
        public static void Main(string[] args) {
           var game = new GameWindow(800, 600, "Simpile Example");
					 Vector2 pos = game.GetWindowPosition();
					 Console.WrightLine(pos);
           game.Show();
        }
    }
}
