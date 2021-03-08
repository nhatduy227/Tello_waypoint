using System;
using System.Drawing;
using System.Windows.Forms;
using TelloLib;
using OpenTK.Graphics.OpenGL;
using OpenTK;
using PixelFormat = OpenTK.Graphics.OpenGL.PixelFormat;

namespace Basic_GUI
{
    public partial class basic_gui : Form
    {
        // initial positions 
        float initX = 0;
        float initY = 0;
        float initZ = 0;

        // current waypoints
        float curX = 0;
        float curY = 0;
        float curZ = 0;
        int counter = 0;

        // Roll Pitch Yaw data
        double Yaw = 0;
        Utils utils = new Utils();

        // IP info
        string IP = "192.168.10.1";
        static double angle = 0.0;

        public basic_gui()
        {
            
            this.KeyPreview = true;
            InitializeComponent();

            //subscribe to Tello connection events
            Tello.onConnection += (Tello.ConnectionState newState) =>
            {
                if (newState != Tello.ConnectionState.Connected)
                {
                    Console.WriteLine("Tello Disconnected");
                }
                if (newState == Tello.ConnectionState.Connected)
                {
                    Tello.queryAttAngle();
                    Tello.setMaxHeight(50);
                }
            };

            //subscribe to Tello update events.
            Tello.onUpdate += (cmdId) =>
            {
                if (cmdId == 86)//ac update
                {
                    Console.WriteLine("Tello updated");
                }
            };

            Tello.startConnecting(IP);//Start trying to connect.
            while (Tello.connected)
            {
                // send back connecting message
                Console.WriteLine("Tello connected");
            }
        }

        // Update positions 
        private void GetPos_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            // Positioning data
            curX = Tello.state.posX - initX;
            curY = Tello.state.posY - initY;
            curZ = Tello.state.posZ - initZ;

            // Rotation data
            var eular = utils.toEuler(Tello.state.quatX, Tello.state.quatY, Tello.state.quatZ, Tello.state.quatW);
            Yaw = Math.Round(eular[2] * (180 / 3.141592), 4);
            if (Yaw < 0)
            {
                Yaw += 360;
            }

            if (curX > 5 || curX < -5 || curY > 5 || curY < -5)
            {
                Console.WriteLine("Data Noise eliminated");
            }
            else
            {
                // Update data
                PosX.Text = "Position X: " + curX.ToString() + " m";
                PosY.Text = "Position Y: " + curY.ToString() + " m";
                Height.Text = "Height: " + Tello.state.height.ToString() + " dm";
                YawAngel.Text = "Yaw Angle: " + Yaw.ToString();
                Battery.Text = "Battery: " + Tello.state.batteryPercentage.ToString() + "%";

                // PLotting Chart
                // Plot current position

                // Past positions
                if (counter != 0)
                {
                    Console.WriteLine("Plot Past Positions");
                }
                counter += 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Tello.state.flying)
                GetPos.PerformClick();
        }

        // Keyboard Controls
        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.T)
            {
                Takeoff.BackColor = Color.Green;
                Takeoff.ForeColor = Color.White;
                // Instrutions to the drone
                Tello.takeOff();
            }

            if (e.KeyCode == Keys.Y)
            {
                Land.BackColor = Color.Green;
                Land.ForeColor = Color.White;
                // Instrutions to the drone
                Tello.land();
            }

            if (e.KeyCode == Keys.R)
            {
                markOrigin.PerformClick();
                markOrigin.BackColor = Color.Green;
                markOrigin.ForeColor = Color.White;
                //Data.CreateXMLFile(run);
            }

            if (e.KeyCode == Keys.Space)
            {
                Hover.BackColor = Color.Green;
                Hover.ForeColor = Color.White;
                // Instrutions to the drone
                Tello.hover();
            }

            float lx = 0f;
            float ly = 0f;
            float rx = 0f;
            float ry = 0f;

            if (e.KeyCode == Keys.W)
            {
                Forward.BackColor = Color.Green;
                Forward.ForeColor = Color.White;
                // Instrutions to the drone
                ry = 0.5f;
            }

            if (e.KeyCode == Keys.S)
            {
                Backward.BackColor = Color.Green;
                Backward.ForeColor = Color.White;
                // Instrutions to the drone
                ry = -0.5f;

            }

            if (e.KeyCode == Keys.A)
            {
                Right.BackColor = Color.Green;
                Right.ForeColor = Color.White;
                // Instrutions to the drone
                rx = -0.5f;
            }

            if (e.KeyCode == Keys.D)
            {
                Left.BackColor = Color.Green;
                Left.ForeColor = Color.White;
                // Instrutions to the drone
                rx = 0.5f;
            }

            if (e.KeyCode == Keys.I)
            {
                Upward.BackColor = Color.Green;
                Upward.ForeColor = Color.White;
                // Instrutions to the drone
                // Instrutions to the drone
                ly = 0.5f;
            }

            if (e.KeyCode == Keys.K)
            {
                Downward.BackColor = Color.Green;
                Downward.ForeColor = Color.White;
                // Instrutions to the drone
                ly = -0.5f;
            }

            if (e.KeyCode == Keys.J)
            {
                Counter.BackColor = Color.Green;
                Counter.ForeColor = Color.White;
                // Instrutions to the drone
                lx = -0.5f;
            }

            if (e.KeyCode == Keys.L)
            {
                Clockwise.BackColor = Color.Green;
                Clockwise.ForeColor = Color.White;
                // Instrutions to the drone
                lx = 0.5f;
            }
            Tello.controllerState.setAxis(lx, ly, rx, ry);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // Change buttons color to default settings
            Forward.BackColor = Color.White;
            Forward.ForeColor = Color.Black;
            Backward.BackColor = Color.White;
            Backward.ForeColor = Color.Black;
            Right.BackColor = Color.White;
            Right.ForeColor = Color.Black;
            Left.BackColor = Color.White;
            Left.ForeColor = Color.Black;
            Upward.BackColor = Color.White;
            Upward.ForeColor = Color.Black;
            Downward.BackColor = Color.White;
            Downward.ForeColor = Color.Black;
            Counter.BackColor = Color.White;
            Counter.ForeColor = Color.Black;
            Clockwise.BackColor = Color.White;
            Clockwise.ForeColor = Color.Black;
            Takeoff.BackColor = Color.White;
            Takeoff.ForeColor = Color.Black;
            Land.BackColor = Color.White;
            Land.ForeColor = Color.Black;
            Hover.BackColor = Color.White;
            Hover.ForeColor = Color.Black;
            markOrigin.BackColor = Color.White;
            markOrigin.ForeColor = Color.Black;
        }

        // Set Origins
        private void markOrigin_Click(object sender, EventArgs e)
        {
            initX = Tello.state.posX;
            initY = Tello.state.posY;
            initZ = Tello.state.posZ;

            // Mark Origin 

            // Start timer 
            timer1.Start();
        }

        // Disable arrow keys
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.PreviewKeyDown += new PreviewKeyDownEventHandler(control_PreviewKeyDown);
            }
        }
        void control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.IsInputKey = true;
            }
        }

        private void glControl_Load(object sender, EventArgs e)
        {
            base.OnLoad(e);

            glControl.KeyDown += new KeyEventHandler(glControl_KeyDown);
            glControl.KeyUp += new KeyEventHandler(glControl_KeyUp);
            glControl.Resize += new EventHandler(glControl_Resize);
            glControl.Paint += new PaintEventHandler(glControl_Paint);

            Text =
                GL.GetString(StringName.Vendor) + " " +
                GL.GetString(StringName.Renderer) + " " +
                GL.GetString(StringName.Version);

            GL.ClearColor(Color.MidnightBlue);
            GL.Enable(EnableCap.DepthTest);

            Application.Idle += Application_Idle;

            // Ensure that the viewport and projection matrix are set correctly.
            glControl_Resize(glControl, EventArgs.Empty);
        }

        void glControl_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        void glControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                GrabScreenshot().Save("screenshot.png");
            }
        }

        void glControl_Resize(object sender, EventArgs e)
        {
            OpenTK.GLControl c = sender as OpenTK.GLControl;

            if (c.ClientSize.Height == 0)
                c.ClientSize = new System.Drawing.Size(c.ClientSize.Width, 1);

            GL.Viewport(0, 0, c.ClientSize.Width, c.ClientSize.Height);

            //float aspect_ratio = this.Width / float.Parse(this.Height.ToString());
            float aspect_ratio = 16 / 9;
            Matrix4 perpective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, aspect_ratio, 1, 64);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perpective);
        }

        void glControl_Paint(object sender, PaintEventArgs e)
        {
            Render();
        }

        void Application_Idle(object sender, EventArgs e)
        {
            while (glControl.IsIdle)
            {
                Render();
            }
        }

        private void Render()
        {
            Matrix4 lookat = Matrix4.LookAt(0, 5, 5, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref lookat);

            GL.ClearColor(0.1f, 0.1f, 0.1f, 1.0f); // black background
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Enable(EnableCap.DepthTest);

            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.PushMatrix();

            GL.Translate(0.0, 0.0, -35.0);
            GL.Rotate(-45.0, 1.0, 0.0, 0.0);
            GL.Rotate(225.0, 0.0, 0.0, 1.0);
            //GL.Rotate(angle, 1.0, 0.0, 1.0);
            DisplayCoordinatesAxes();
            DisplayDrone(0.5, 50, 50, -2, -2, 0);

            angle += 0.1; 
            glControl.SwapBuffers();
        }
        void DisplayCoordinatesAxes()
        {
            // X axis: red
            GL.Begin(PrimitiveType.Lines);
            Colors.Red();
            GL.Vertex3(-10.0, 0, 0.0f); // origin of the line
            GL.Vertex3(10.0, 0.0, 0.0f); // ending point of the line
            GL.End();

            // Y axis: green
            GL.Begin(PrimitiveType.Lines);
            Colors.Green();
            GL.Vertex3(0.0, -10.0, 0.0); // origin of the line
            GL.Vertex3(0.0, 10.0, 0.0); // ending point of the line
            GL.End();

            // Z axis: blue
            GL.Begin(PrimitiveType.Lines);
            Colors.Blue();
            GL.Vertex3(0.0, 0.0, -10.0); // origin of the line
            GL.Vertex3(0.0, 0.0, 10.0); // ending point of the line
            GL.End();

            DisplayXYGrid(10, 10, 10, 2);
        }

        void DisplayXYGrid(double x, double y, double z, double gridSpace)
        {

            // draw Y grid
            int t1 = Convert.ToInt32(x / gridSpace); // iteration
            for (int i = -t1; i <= t1; i++)
            {
                GL.Begin(PrimitiveType.Lines);
                GL.Color3(0.5, 0.5, 0.5);
                GL.LineWidth(5);
                GL.Vertex3(i * gridSpace, -y, 0.0);
                GL.Vertex3(i * gridSpace, y, 0.0);
                GL.End();
            }

            // draw X grid
            int t2 = Convert.ToInt32(y / gridSpace); // iteration
            for (int i = -t2; i <= t2; i++)
            {
                GL.Begin(PrimitiveType.Lines);
                GL.Color3(0.5, 0.5, 0.5);
                GL.LineWidth(5);
                GL.Vertex3(-x, i * gridSpace, 0.0);
                GL.Vertex3(x, i * gridSpace, 0.0);
                GL.End();
            }
        }

        void DisplayDrone(double r, int lats, int longs, int X, int Y, int Z)
        {
            var s = new Drone(X, Y, Z);
            s.Color(1.0, 0.0, 0.0);
            s.Display(r, lats, longs);
        }
        Bitmap GrabScreenshot()
        {
            Bitmap bmp = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            System.Drawing.Imaging.BitmapData data =
            bmp.LockBits(this.ClientRectangle, System.Drawing.Imaging.ImageLockMode.WriteOnly,
                System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            GL.ReadPixels(0, 0, this.ClientSize.Width, this.ClientSize.Height, PixelFormat.Bgr, PixelType.UnsignedByte,
                data.Scan0);
            bmp.UnlockBits(data);
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);
            return bmp;
        }
    }
}

