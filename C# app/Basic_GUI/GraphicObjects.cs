using System;
using System.Numerics;

namespace Basic_GUI
{
    public class GraphicsObject
    {
        protected Vector3 position; // location
        protected Colors color;

        public GraphicsObject(int x, int y, int z)
        {
            SetPosition(x, y, z);
        }
        public void SetPosition(int x, int y, int z)
        {
            position = new Vector3(x, y, z);
        }
        public Vector3 GetPosition()
        {
            return position;
        }
        public void Color(double r, double g, double b)
        {
            color = new Colors(r, g, b);

        }
    }
}
