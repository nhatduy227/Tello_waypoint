using TelloLib;
using System.Windows.Forms.DataVisualization.Charting;

namespace Basic_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.Takeoff = new System.Windows.Forms.Button();
            this.Land = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GetPos = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Forward = new System.Windows.Forms.Button();
            this.Backward = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Clockwise = new System.Windows.Forms.Button();
            this.Counter = new System.Windows.Forms.Button();
            this.Downward = new System.Windows.Forms.Button();
            this.Upward = new System.Windows.Forms.Button();
            this.Hover = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Run = new System.Windows.Forms.Button();
            this.Ybox = new System.Windows.Forms.TextBox();
            this.Xbox = new System.Windows.Forms.TextBox();
            this.SetY = new System.Windows.Forms.Label();
            this.SetX = new System.Windows.Forms.Label();
            this.PlaceWaypoint = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Apply = new System.Windows.Forms.Button();
            this.WaypointLabel = new System.Windows.Forms.Label();
            this.WaypointMode = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Takeoff
            // 
            this.Takeoff.BackColor = System.Drawing.Color.White;
            this.Takeoff.Location = new System.Drawing.Point(655, 23);
            this.Takeoff.Name = "Takeoff";
            this.Takeoff.Size = new System.Drawing.Size(175, 70);
            this.Takeoff.TabIndex = 0;
            this.Takeoff.TabStop = false;
            this.Takeoff.Text = "Take Off";
            this.Takeoff.UseVisualStyleBackColor = false;
            // 
            // Land
            // 
            this.Land.BackColor = System.Drawing.Color.White;
            this.Land.Location = new System.Drawing.Point(898, 23);
            this.Land.Name = "Land";
            this.Land.Size = new System.Drawing.Size(174, 70);
            this.Land.TabIndex = 1;
            this.Land.TabStop = false;
            this.Land.Text = "Land";
            this.Land.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pos_X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pos_Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Poz_Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // GetPos
            // 
            this.GetPos.BackColor = System.Drawing.Color.White;
            this.GetPos.Location = new System.Drawing.Point(82, 105);
            this.GetPos.Name = "GetPos";
            this.GetPos.Size = new System.Drawing.Size(116, 35);
            this.GetPos.TabIndex = 8;
            this.GetPos.TabStop = false;
            this.GetPos.Text = "Get Positions";
            this.GetPos.UseVisualStyleBackColor = false;
            this.GetPos.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Forward
            // 
            this.Forward.BackColor = System.Drawing.Color.White;
            this.Forward.Location = new System.Drawing.Point(214, 233);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(131, 44);
            this.Forward.TabIndex = 12;
            this.Forward.TabStop = false;
            this.Forward.Text = "Forward";
            this.Forward.UseVisualStyleBackColor = false;
            // 
            // Backward
            // 
            this.Backward.BackColor = System.Drawing.Color.White;
            this.Backward.Location = new System.Drawing.Point(214, 330);
            this.Backward.Name = "Backward";
            this.Backward.Size = new System.Drawing.Size(131, 44);
            this.Backward.TabIndex = 13;
            this.Backward.TabStop = false;
            this.Backward.Text = "Backward";
            this.Backward.UseVisualStyleBackColor = false;
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.Color.White;
            this.Right.Location = new System.Drawing.Point(86, 280);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(131, 44);
            this.Right.TabIndex = 14;
            this.Right.TabStop = false;
            this.Right.Text = "Right";
            this.Right.UseVisualStyleBackColor = false;
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.Color.White;
            this.Left.Location = new System.Drawing.Point(343, 280);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(128, 44);
            this.Left.TabIndex = 15;
            this.Left.TabStop = false;
            this.Left.Text = "Left";
            this.Left.UseVisualStyleBackColor = false;
            // 
            // Clockwise
            // 
            this.Clockwise.BackColor = System.Drawing.Color.White;
            this.Clockwise.Location = new System.Drawing.Point(920, 283);
            this.Clockwise.Name = "Clockwise";
            this.Clockwise.Size = new System.Drawing.Size(131, 44);
            this.Clockwise.TabIndex = 19;
            this.Clockwise.TabStop = false;
            this.Clockwise.Text = "Clockwise";
            this.Clockwise.UseVisualStyleBackColor = false;
            // 
            // Counter
            // 
            this.Counter.BackColor = System.Drawing.Color.White;
            this.Counter.Location = new System.Drawing.Point(655, 283);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(131, 44);
            this.Counter.TabIndex = 18;
            this.Counter.TabStop = false;
            this.Counter.Text = "Counter";
            this.Counter.UseVisualStyleBackColor = false;
            // 
            // Downward
            // 
            this.Downward.BackColor = System.Drawing.Color.White;
            this.Downward.Location = new System.Drawing.Point(790, 333);
            this.Downward.Name = "Downward";
            this.Downward.Size = new System.Drawing.Size(131, 44);
            this.Downward.TabIndex = 17;
            this.Downward.TabStop = false;
            this.Downward.Text = "Downward";
            this.Downward.UseVisualStyleBackColor = false;
            // 
            // Upward
            // 
            this.Upward.BackColor = System.Drawing.Color.White;
            this.Upward.Location = new System.Drawing.Point(790, 233);
            this.Upward.Name = "Upward";
            this.Upward.Size = new System.Drawing.Size(131, 44);
            this.Upward.TabIndex = 16;
            this.Upward.TabStop = false;
            this.Upward.Text = "Upward";
            this.Upward.UseVisualStyleBackColor = false;
            // 
            // Hover
            // 
            this.Hover.BackColor = System.Drawing.Color.White;
            this.Hover.Location = new System.Drawing.Point(478, 386);
            this.Hover.Name = "Hover";
            this.Hover.Size = new System.Drawing.Size(176, 44);
            this.Hover.TabIndex = 20;
            this.Hover.TabStop = false;
            this.Hover.Text = "Hover";
            this.Hover.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Hover);
            this.panel1.Controls.Add(this.Clockwise);
            this.panel1.Controls.Add(this.Counter);
            this.panel1.Controls.Add(this.Downward);
            this.panel1.Controls.Add(this.Upward);
            this.panel1.Controls.Add(this.Left);
            this.panel1.Controls.Add(this.Right);
            this.panel1.Controls.Add(this.Backward);
            this.panel1.Controls.Add(this.Forward);
            this.panel1.Controls.Add(this.GetPos);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Land);
            this.panel1.Controls.Add(this.Takeoff);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1430, 583);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Run);
            this.panel2.Controls.Add(this.Ybox);
            this.panel2.Controls.Add(this.Xbox);
            this.panel2.Controls.Add(this.SetY);
            this.panel2.Controls.Add(this.SetX);
            this.panel2.Controls.Add(this.PlaceWaypoint);
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Controls.Add(this.Apply);
            this.panel2.Controls.Add(this.WaypointLabel);
            this.panel2.Location = new System.Drawing.Point(9, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1430, 580);
            this.panel2.TabIndex = 22;
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(1325, 463);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(91, 43);
            this.Run.TabIndex = 31;
            this.Run.TabStop = false;
            this.Run.Text = "Run Flight Plan";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Ybox
            // 
            this.Ybox.Location = new System.Drawing.Point(1324, 367);
            this.Ybox.Name = "Ybox";
            this.Ybox.Size = new System.Drawing.Size(92, 22);
            this.Ybox.TabIndex = 30;
            // 
            // Xbox
            // 
            this.Xbox.Location = new System.Drawing.Point(1323, 312);
            this.Xbox.Name = "Xbox";
            this.Xbox.Size = new System.Drawing.Size(93, 22);
            this.Xbox.TabIndex = 29;
            // 
            // SetY
            // 
            this.SetY.AutoSize = true;
            this.SetY.Location = new System.Drawing.Point(1321, 341);
            this.SetY.Name = "SetY";
            this.SetY.Size = new System.Drawing.Size(42, 17);
            this.SetY.TabIndex = 28;
            this.SetY.Text = "Set Y";
            // 
            // SetX
            // 
            this.SetX.AutoSize = true;
            this.SetX.Location = new System.Drawing.Point(1322, 286);
            this.SetX.Name = "SetX";
            this.SetX.Size = new System.Drawing.Size(42, 17);
            this.SetX.TabIndex = 27;
            this.SetX.Text = "Set X";
            // 
            // PlaceWaypoint
            // 
            this.PlaceWaypoint.Location = new System.Drawing.Point(1325, 404);
            this.PlaceWaypoint.Name = "PlaceWaypoint";
            this.PlaceWaypoint.Size = new System.Drawing.Size(91, 43);
            this.PlaceWaypoint.TabIndex = 26;
            this.PlaceWaypoint.TabStop = false;
            this.PlaceWaypoint.Text = "Place New Waypoint";
            this.PlaceWaypoint.UseVisualStyleBackColor = true;
            this.PlaceWaypoint.Click += new System.EventHandler(this.PlaceWaypoint_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(3, 41);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1312, 525);
            this.chart1.TabIndex = 25;
            this.chart1.Text = "chart1";
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(1325, 523);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(91, 43);
            this.Apply.TabIndex = 23;
            this.Apply.TabStop = false;
            this.Apply.Text = "Return ";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // WaypointLabel
            // 
            this.WaypointLabel.AutoSize = true;
            this.WaypointLabel.Location = new System.Drawing.Point(427, 11);
            this.WaypointLabel.Name = "WaypointLabel";
            this.WaypointLabel.Size = new System.Drawing.Size(120, 17);
            this.WaypointLabel.TabIndex = 24;
            this.WaypointLabel.Text = "Waypoint Planner";
            // 
            // WaypointMode
            // 
            this.WaypointMode.Location = new System.Drawing.Point(94, 614);
            this.WaypointMode.Name = "WaypointMode";
            this.WaypointMode.Size = new System.Drawing.Size(183, 43);
            this.WaypointMode.TabIndex = 22;
            this.WaypointMode.TabStop = false;
            this.WaypointMode.Text = "Waypoint Mode";
            this.WaypointMode.UseVisualStyleBackColor = true;
            this.WaypointMode.Click += new System.EventHandler(this.WaypointMode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 676);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.WaypointMode);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Takeoff;
        private System.Windows.Forms.Button Land;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GetPos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Button Backward;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Clockwise;
        private System.Windows.Forms.Button Counter;
        private System.Windows.Forms.Button Downward;
        private System.Windows.Forms.Button Upward;
        private System.Windows.Forms.Button Hover;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label WaypointLabel;
        private System.Windows.Forms.Button WaypointMode;
        private System.Windows.Forms.Button Apply;
        private Chart chart1;
        private System.Windows.Forms.Button PlaceWaypoint;
        private System.Windows.Forms.Label SetX;
        private System.Windows.Forms.TextBox Xbox;
        private System.Windows.Forms.Label SetY;
        private System.Windows.Forms.TextBox Ybox;
        private System.Windows.Forms.Button Run;
    }
}

