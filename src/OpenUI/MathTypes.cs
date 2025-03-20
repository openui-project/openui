using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace OpenUI
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector2
    {
        public float X;
        public float Y;

        public Vector2(float x, float y) 
				{ 
					X = x;
					Y = y;
				}

				// Properties & Fields

        // Methods

        // Operators
				public static bool operator ==(Vector2 v1, Vector2 v2) => v1.X == v2.X && v1.Y == v2.Y;
        public static bool operator !=(Vector2 v1, Vector2 v2) => !(v1 == v2);

				// Overriden Methods
        public override string ToString() => $"({X}, {Y})";
        public override int GetHashCode() => HashCode.Combine(X, Y);
    }
}
