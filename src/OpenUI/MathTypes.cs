using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace OpenUI {
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector2 
    {
        public float X, Y;

        public Vector2(float x, float y) {
            X = x;
            Y = y;
        }

        public static readonly Vector2 Zero = new Vector2(0, 0);

        public static int SizeInBytes { get; } = Unsafe.SizeOf<Vector2>();

        public static bool operator ==(Vector2 v1, Vector2 v2) =>  v1.X == v2.X && v1.Y == v2.Y;
        public static bool operator !=(Vector2 v1, Vector2 v2) => !(v1 == v2);

        public override string ToString() => $"({X}, {Y})";
        public override int GetHashCode() => (X, Y).GetHashCode();
    }
}
