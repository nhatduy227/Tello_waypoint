using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelloLib;

namespace Swarmming
{
    public partial class Swarming_gui : Form
    {
        string mock_IP = "192.168.10.1";
        public Swarming_gui()
        {
            InitializeComponent();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            string IP;
            if (inputIP.Text == "")
                connectNoti.Text = "Please input Tello's address";

            else {
                IP = inputIP.Text;
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
                        Console.WriteLine("Tello updated");
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

                Tello.startConnecting(IP);//Start trying to connect.
                if (Tello.connected)
                {
                    takeOff.Visible = true;
                    Land.Visible = true;
                    connectNoti.Text = "Tello connected";
                }
                else 
                {
                    connectNoti.Text = "Tello disconnected";
                }
                
            }
            
        }
        private void takeOff_Click(object sender, EventArgs e)
        {
            Tello.takeOff();
        }

        private void Land_Click(object sender, EventArgs e)
        {
            Tello.land();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("form loaded");
        }
    }
}
