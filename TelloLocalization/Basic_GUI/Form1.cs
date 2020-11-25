using System;
using System.Linq;
using System.IO;
using System.Drawing;
using System.Xml;
using System.Windows.Forms;
using TelloLib;
using System.Diagnostics;

namespace Basic_GUI
{
    
    public partial class Form1 : Form
    {
        // Saving data logic 
        Data Data = new Data();
        int run = Directory.GetFiles("C:/Users/nomie/Desktop/Tello_waypoint/XML-positioning/", "*", SearchOption.TopDirectoryOnly).Length + 1;
        // initial positions 
        float initX = 0;
        float initY= 0;
        float initZ = 0;

        // current waypoints
        float curX = 0;
        float curY = 0;
        float curZ = 0;

        int counter = 0;
        public Form1()
        {
            this.KeyPreview = true;
            Data.CreateXMLFile(run);
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
                    
                }
            };

            

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
        private void GetPos_Click(object sender, EventArgs e)
        {
            // Update positioning 
            curX = Tello.state.posX - initX;
            curY = Tello.state.posY - initY;
            curZ = Tello.state.posZ - initZ;
            label4.Text = curX.ToString();
            label5.Text = curY.ToString();
            label6.Text = curZ.ToString();
            label8.Text = (Tello.state.height).ToString();

            // PLotting Chart
            chart1.Series["Trajectory 2D"].Points.AddXY(curX, curY);
            //chart1.Series["Trajectory 2D"].Points[counter].Color = Color.Red;
            //counter += 1;

            // Saving to XML
            //Data.PosX = ((Tello.state.posX - initX)).ToString();
            //Data.PosY = ((Tello.state.posY - initY)).ToString();
            //Data.PosZ = (Tello.state.height).ToString();
            //Data.FlightTime = Tello.state.flyTime.ToString();
            //Data.TimeStamp = System.DateTime.Now.ToString();
            //Data.AddRecordToXML(Data.FlightTime,Data.TimeStamp,Data.PosX,Data.PosY,Data.PosZ, run);

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
        }

        private void Compare_Click(object sender, EventArgs e)
        {
            string inputRun = textBox1.Text;
            // Plotting for comparation 
            XmlTextReader xtr = new XmlTextReader(@"C:/Users/nomie/Desktop/Tello_waypoint/XML-positioning/" + inputRun.ToString() + ".xml");
            while (xtr.Read())
            {
                string s1 = "";
                string s2 = "";
                string s3 = "";
                string s4 = "";
                //if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "FlightTime")
                //{
                //    s1 = xtr.ReadElementString();
                //}
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "PosX")
                {
                    s2 = xtr.ReadElementString();
                }
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "PosY")
                {
                    s3 = xtr.ReadElementString();
                }
                //if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "PosZ")
                //{
                //    s4 = xtr.ReadElementString();
                //}
                chart1.Series["Trajectory 2D"].Points.AddXY(s2, s3);
            }
            chart1.Visible = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;
        }

        private void markOrigin_Click(object sender, EventArgs e)
        {
            initX = Tello.state.posX;
            initY = Tello.state.posY;
            initZ = Tello.state.posZ;

            // Start timer 
            timer1.Start();
        }
    }
}

