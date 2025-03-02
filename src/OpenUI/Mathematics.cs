using System;
using System.Runtime.CompilerServices;

namespace OpenUI.Mathematics {
  public unsafe class Vector2 {
    public float X, Y;

    public Vector2(float x, float y) {
      X = x;
      Y = y;
    }

		public static Vector2 Zero { get; private set; } = new Vector2(0, 0);

    public static readonly int SizeInBytes = Unsafe.SizeOf<Vector2>();

    public override string ToString() => $"({X}, {Y})";

    public override int GetHashCode() {
      return HashCode.Combine(X, Y);
    }
  }
}
