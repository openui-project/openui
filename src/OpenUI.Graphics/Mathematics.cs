using System;
using System.Runtime.CompilerServices;
using OpenUI.Mathematics;

namespace OpenUI.Mathematics
{
    public unsafe class Vector2
    {
        public float X { get; set; }
        public float Y { get; get; }

        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }

        public static readonly int SizeInBytes = Unsafe.SizeOf<Vector2>();

        public override string ToString() => $"({X}, {Y})";

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
    }
}