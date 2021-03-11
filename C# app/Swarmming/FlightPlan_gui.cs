using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TelloLib;

namespace Swarmming
{
    public partial class FlightPlan_gui : Form
    {
        string IP = "192.168.10.1";
        List<string> instructionList = new List<string>();
        AutoCompleteStringCollection suggestedInstructions = new AutoCompleteStringCollection() { 
            "takeoff",
            "land",
            "up 20",
            "down 20",
            "right 20",
            "left 20"
        };

        public FlightPlan_gui()
        {
            InitializeComponent();
            input.AutoCompleteCustomSource = suggestedInstructions;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("form loaded");
        }

        private void Add_Instruction_Click(object sender, EventArgs e)
        {
            if ((input.Text == "") || (input.Text == null))
            {
                insList.Text = "Instruction cannot be plank";
            }
            else {
                instructionList.Add(input.Text);
                insList.Text = displayIntructions(instructionList);
                input.Text = "";
                Run.Enabled = true;
            }

        }

        private void delInstrutions_Click(object sender, EventArgs e)
        {
            
            if (instructionList.Count > 0)
            {
                instructionList.Clear();
                insList.Text = "No instruction yet";
                Run.Enabled = false;
            }
            else {
                insList.Text = "No instruction to delete";
            } 
           
        }

        private string displayIntructions(List<String> instructions)
        {
            var text = string.Empty;
            foreach (String s in instructions)
            {
                text += s.ToString() + "\r\n";
            }
            return text;
        }

        private void Run_Click(object sender, EventArgs e)
        {
            if (instructionList[0] != "takeoff")
            {
                instructionList.Insert(0, "takeoff");
            }
            if (instructionList[instructionList.Count - 1] != "land") {
                instructionList.Add("land");
            }
            insList.Text = displayIntructions(instructionList);
        }
    }
}
