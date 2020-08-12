using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using TelloLib;


namespace Basic_GUI
{
    
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index = 0;
        public Form1()
        {
            this.KeyPreview = true;
            InitializeComponent();
            //subscribe to Tello connection events
            Tello.onConnection += (Tello.ConnectionState newState) =>
            {
                if (newState != Tello.ConnectionState.Connected)
                {
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
                    string filepath = @"C:\Users\nomie\Desktop\Linear Algebra\3D visualization\test.dat";
                    writeCSV(Tello.state.posX.ToString(), Tello.state.posY.ToString(), Tello.state.posZ.ToString(), filepath);
                }
            };

            // writing positioning data to a csv file
            void writeCSV(string posX, string posY, string PosZ, string filepath) 
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true)) 
                {
                    file.WriteLine(posX + "," + posY + "," + PosZ);
                }
            } 
            

            var videoClient = UdpUser.ConnectTo("127.0.0.1", 7038);
            //subscribe to Tello video data
            Tello.onVideoData += (byte[] data) =>
            {
                try
                {
                    videoClient.Send(data.Skip(2).ToArray());//Skip 2 byte header and send to ffplay. 
                    //Console.WriteLine("Video size:" + data.Length);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: ", ex);
                }
            };


            Tello.startConnecting();//Start trying to connect.
            while (Tello.connected) 
            {   
                // update positioning data on GUI 
                label4.Text = Tello.state.posX.ToString();
                label5.Text = Tello.state.posY.ToString();
                label6.Text = Tello.state.posZ.ToString();

            }
        }
        // Update positions 
        private void button3_Click(object sender, EventArgs e)
        {
            // Update positioning 
            label4.Text = Tello.state.posX.ToString();
            label5.Text = Tello.state.posY.ToString();
            label6.Text = Tello.state.posZ.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetPos.PerformClick();
        }

        // Keyboard events
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

            if (e.KeyCode == Keys.Space)
            {
                Hover.BackColor = Color.Green;
                Hover.ForeColor = Color.White;
                // Instrutions to the drone
                Tello.hover();
            }

            // Keyboard controls 
            float lx = 0f;
            float ly = 0f;
            float rx = 0f;
            float ry = 0f;

            if (e.KeyCode == Keys.W)
            {
                Forward.BackColor = Color.Green;
                Forward.ForeColor = Color.White;
                // Instrutions to the drone
                ry = 1;
            }

            if (e.KeyCode == Keys.S)
            {
                Backward.BackColor = Color.Green;
                Backward.ForeColor = Color.White;
                // Instrutions to the drone
                ry = -1;

            }

            if (e.KeyCode == Keys.A)
            {
                Right.BackColor = Color.Green;
                Right.ForeColor = Color.White;
                // Instrutions to the drone
                rx = -1;
            }

            if (e.KeyCode == Keys.D)
            {
                Left.BackColor = Color.Green;
                Left.ForeColor = Color.White;
                // Instrutions to the drone
                rx = 1;
            }

            if (e.KeyCode == Keys.I)
            {
                Upward.BackColor = Color.Green;
                Upward.ForeColor = Color.White;
                // Instrutions to the drone
                // Instrutions to the drone
                ly = 1;
            }

            if (e.KeyCode == Keys.K)
            {
                Downward.BackColor = Color.Green;
                Downward.ForeColor = Color.White;
                // Instrutions to the drone
                ly = -1;
            }

            if (e.KeyCode == Keys.J)
            {
                Counter.BackColor = Color.Green;
                Counter.ForeColor = Color.White;
                // Instrutions to the drone
                lx = -1;
            }

            if (e.KeyCode == Keys.L)
            {
                Clockwise.BackColor = Color.Green;
                Clockwise.ForeColor = Color.White;
                // Instrutions to the drone
                lx = 1;
            }
            Tello.controllerState.setSpeedMode(10);
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
        }

        // Waypoint planner mode
        private void WaypointMode_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();
            // Unfocus once button is pressed 
            this.ActiveControl = null;
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            if (index > 0 )
                listPanel[--index].BringToFront();
            // Unfocus once button is pressed 
            this.ActiveControl = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel[index].BringToFront();
        }
    }
}

