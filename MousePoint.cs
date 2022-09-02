using System.Runtime.InteropServices;

namespace MouseController
{
    /// <summary>
    /// Represent mouse point structure with 2 dimensions x, y
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct MousePoint
    {
        public int X;
        public int Y;

        public MousePoint(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
