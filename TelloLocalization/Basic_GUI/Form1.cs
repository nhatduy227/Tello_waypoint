using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using TelloLib;


namespace Basic_GUI
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
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
                    //Console.WriteLine(Tello.state.posX.ToString());
                    //Console.WriteLine(Tello.state.posY.ToString());
                    //Console.WriteLine(Tello.state.posZ.ToString());
                    // write positioning data to csv file.
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

        private void button2_Click(object sender, EventArgs e)
        {
            // create a respone for land button
            
            if (Tello.connected && Tello.state.flying)
                Tello.land();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create a respone for take off button
            if (Tello.connected && !Tello.state.flying)
                Tello.takeOff();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = Tello.state.posX.ToString();
            label5.Text = Tello.state.posY.ToString();
            label6.Text = Tello.state.posZ.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button3.PerformClick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // create a respone forward button
            if (Tello.connected && Tello.state.flying)
                Tello.forward();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // create a respone for clockwise button
            if (Tello.connected && Tello.state.flying)
                Tello.clockwise();
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            // fly in rectangle function
            moveRectangle();
        }
        void moveRectangle()
        {
            for (int i = 0; i < 4; i++)
            {
                if (Tello.connected && Tello.state.flying) 
                {
                    Tello.forward();
                    Tello.clockwise();
                }
            }
        }
    }
}
