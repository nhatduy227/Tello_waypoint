using System;
using OpenTK.Graphics.OpenGL;

namespace Basic_GUI
{
    public class Colors
    {
        private double red, green, blue;

        public Colors() { }

        public Colors(double red, double green, double blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }
        public void Display()
        {
            GL.Color3(this.red, this.green, this.blue);
        }
        public static void Red()
        {
            GL.Color3(1.0, 0.0, 0.0);
        }
        public static void Green()
        {
            GL.Color3(0.0, 1.0, 0.0);
        }
        public static void Blue()
        {
            GL.Color3(0.0, 0.0, 1.0);
        }
        public static void Black()
        {
            GL.Color3(0.0, 0.0, 0.0);
        }
        public static void White()
        {
            GL.Color3(1.0, 1.0, 1.0);
        }
        public static void Grey()
        {
            GL.Color3(0.5, 0.5, 0.5);
        }
    }
}
