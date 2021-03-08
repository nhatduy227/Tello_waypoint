using System;
using OpenTK.Graphics.OpenGL;

namespace Basic_GUI
{
    public class Sphere : GraphicsObject
    {
        public Sphere(int x, int y, int z) : base(x, y, z)
        { }

        public void Display(double r, int lats, int longs)
        {
            int i, j;
            double M_PI = 3.14;
            for (i = 0; i <= lats; i++)
            {
                double lat0 = M_PI * (-0.5 + (double)(i - 1) / lats);
                double z0 = Math.Sin(lat0);
                double zr0 = Math.Cos(lat0);

                double lat1 = M_PI * (-0.5 + (double)i / lats);
                double z1 = Math.Sin(lat1);
                double zr1 = Math.Cos(lat1);

                GL.Begin(PrimitiveType.QuadStrip);
                color.Display();
                for (j = 0; j <= longs; j++)
                {
                    double lng = 2 * M_PI * (double)(j - 1) / longs;
                    double x1 = Math.Cos(lng);
                    double y1 = Math.Sin(lng);

                    GL.Normal3(position.X * zr0, position.Y * zr0, z0);
                    GL.Vertex3(r * x1 * zr0 + position.X, r * y1 * zr0 + position.Y, r * z0 + position.Z);
                    GL.Normal3(position.X * zr1, position.Y * zr1, z1);
                    GL.Vertex3(r * x1 * zr1 + position.X, r * y1 * zr1 + position.Y, r * z1 + position.Z);
                }
                GL.End();
            }
        }
    }
}
