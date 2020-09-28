using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TelloLib;
using System.Threading;

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

        // Place Waypoint Function 
        int Waypoint_Numb = 1;
        int Drone_Numb = 1; 
        private void PlaceWaypoint_Click(object sender, EventArgs e)
        {
            // Getting points
            float x = float.Parse(Xbox.Text);
            float y = float.Parse(Ybox.Text);

            // Create chart
            var chart = chart1.ChartAreas[0];
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";

            chart.AxisX.Minimum = 0;
            chart.AxisX.Maximum = 100;
            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 100;
            chart.AxisX.Interval = 10;
            chart.AxisY.Interval = 10;

            
            if (Waypoint_Numb != 0) {
                // Add data points 
                string Waypoint_Name = Waypoint_Numb.ToString();
                chart1.Series.Add(Waypoint_Name);
                chart1.Series[Waypoint_Name].ChartType = SeriesChartType.Point;
                chart1.Series[Waypoint_Name].Color = Color.Blue;
                chart1.Series[Waypoint_Name].MarkerStyle = MarkerStyle.Circle;
                chart1.Series[Waypoint_Name].MarkerSize = 15;
                chart1.Series[Waypoint_Name].Points.AddXY(x, y);
                chart1.Series[Waypoint_Name].SetCustomProperty("X_val", x.ToString());
                chart1.Series[Waypoint_Name].SetCustomProperty("Y_val", y.ToString());

                // Operation for next way point 
                Waypoint_Numb += 1;
            }  
        }

        private void Run_Click(object sender, EventArgs e)
        {
            
            for (int i = 1; i  <  Waypoint_Numb; i++) {
                string Drone = "Drone " + Drone_Numb.ToString();
                chart1.Series.Add(Drone);
                chart1.Series[Drone].MarkerImage = "C:/Users/nomie/Desktop/Tello Project/Tello_waypoint/TelloLocalization/img/drone.png";
                float current_x = float.Parse(chart1.Series[i.ToString()].GetCustomProperty("X_val"));
                float current_y = float.Parse(chart1.Series[i.ToString()].GetCustomProperty("Y_val"));
                chart1.Series[Drone].Points.AddXY(current_x, current_y);
                if (Drone_Numb - 1 != 0) {
                    string Past_Drone = "Drone " + (Drone_Numb - 1).ToString();
                    chart1.Series.Remove(chart1.Series[Past_Drone]);
                }
                
                Drone_Numb += 1;
            }
        }
    }
}

