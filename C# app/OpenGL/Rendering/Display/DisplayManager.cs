using System.Drawing;
using System.Collections.Generic;
using System.Numerics;
using GLFW;
using static OpenGL.OpenGL.GL;

namespace OpenGL.Rendering.Display
{
    static class DisplayManager
    {
        public static Window Window { get; set; }
        public static Vector2 WindowSize { get; set; }
        public static void CreateWindow(int width, int height, string title)
        {
            // width and height for initial window
            WindowSize = new Vector2(width, height);

            Glfw.Init();

            // Choose GLFW version - opengl 3.3 core profile
            Glfw.WindowHint(Hint.ContextVersionMajor, 3);
            Glfw.WindowHint(Hint.ContextVersionMinor, 3);
            Glfw.WindowHint(Hint.OpenglProfile, Profile.Core);

            // Additional Settings
            Glfw.WindowHint(Hint.Focused, true);
            Glfw.WindowHint(Hint.Resizable, false);

            // Create Window
            Window = Glfw.CreateWindow(width, height, title, Monitor.None, Window.None);

            if (Window == Window.None)
            {
                // Cannot start window
                return;
            }
            // Create Window in the middle of the screen
            Rectangle screen = Glfw.PrimaryMonitor.WorkArea;
            int x = (screen.Width - width) / 2;
            int y = (screen.Height - height) / 2;
            Glfw.SetWindowPosition(Window, x, y);

            Glfw.MakeContextCurrent(Window);
            Import(Glfw.GetProcAddress);

            glViewport(0, 0, width, height);
            Glfw.SwapInterval(0); // 0 = Vsync off, 1 = Vsync on 
        }

        public static void CloseWindow()
        {
            Glfw.Terminate();
        }
    }
}
