using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using TelloLib;

namespace Basic_GUI
{

    public partial class basic_gui : Form
    {
        // Saving positioning data 
        //Data Data = new Data();
        //int run = Directory.GetFiles("C:/Users/nomie/Desktop/Tello_waypoint/assets/", "*", SearchOption.TopDirectoryOnly).Length;

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

        // Constructor
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

            chart1.Series["Trajectory 2D"].CustomProperties = "IsXAxisQuantitative=True"; // Prevent X to be 1 on initialization 

            if (curX > 5 || curX < -5 || curY > 5 || curY < -5)
            {
                Console.WriteLine("Data Noise eliminated");
            }
            else
            {
                // Update data
                PosX.Text = "Position X: " + curX.ToString() + " m";
                PosY.Text = "Position Y: " + curY.ToString() + " m";
                Height.Text = "Height: " + (Tello.state.height/10).ToString() + " m";
                YawAngel.Text = "Yaw Angle: " + Yaw.ToString();
                Battery.Text = "Battery: " + Tello.state.batteryPercentage.ToString() + "%";

                // PLotting Chart
                // Plot current position
                chart1.Series["Trajectory 2D"].Points.AddXY(Math.Round(curX, 5), Math.Round(curY, 5));
                chart1.Series["Trajectory 2D"].Points[counter].MarkerSize = 10;

                // Past positions
                if (counter != 0)
                {
                    chart1.Series["Trajectory 2D"].Points[counter - 1].Color = Color.Red;
                    chart1.Series["Trajectory 2D"].Points[counter - 1].MarkerSize = 3;
                }
                counter += 1;

                //Saving to XML
                //Data.PosX = ((Tello.state.posX - initX)).ToString();
                //Data.PosY = ((Tello.state.posY - initY)).ToString();
                //Data.PosZ = (Tello.state.height).ToString();
                //Data.FlightTime = Tello.state.flyTime.ToString();
                //Data.TimeStamp = System.DateTime.Now.ToString();
                //Data.AddRecordToXML(Data.FlightTime, Data.TimeStamp, Data.PosX, Data.PosY, Data.PosZ, run);
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
            chart1.Series["Origin"].CustomProperties = "IsXAxisQuantitative=True"; // Prevent X to be 1 on initialization 
            chart1.Series["Origin"].Points.AddXY(0, 0);
            chart1.Series["Origin"].Points[0].MarkerSize = 10;

            // Start timer 
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form1 loaded");
        }
    }
}

