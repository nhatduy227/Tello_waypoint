using System.Windows.Forms.DataVisualization.Charting;


namespace Basic_GUI
{
    partial class basic_gui
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Hover = new System.Windows.Forms.Button();
            this.Clockwise = new System.Windows.Forms.Button();
            this.Counter = new System.Windows.Forms.Button();
            this.Downward = new System.Windows.Forms.Button();
            this.Upward = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.Backward = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            this.GetPos = new System.Windows.Forms.Button();
            this.PosY = new System.Windows.Forms.Label();
            this.PosX = new System.Windows.Forms.Label();
            this.Land = new System.Windows.Forms.Button();
            this.Takeoff = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Height = new System.Windows.Forms.Label();
            this.markOrigin = new System.Windows.Forms.Button();
            this.YawAngel = new System.Windows.Forms.Label();
            this.Battery = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Hover
            // 
            this.Hover.BackColor = System.Drawing.Color.White;
            this.Hover.Location = new System.Drawing.Point(257, 455);
            this.Hover.Name = "Hover";
            this.Hover.Size = new System.Drawing.Size(342, 44);
            this.Hover.TabIndex = 38;
            this.Hover.TabStop = false;
            this.Hover.Text = "Hover (Spacebar)";
            this.Hover.UseVisualStyleBackColor = false;
            // 
            // Clockwise
            // 
            this.Clockwise.BackColor = System.Drawing.Color.White;
            this.Clockwise.Location = new System.Drawing.Point(733, 352);
            this.Clockwise.Name = "Clockwise";
            this.Clockwise.Size = new System.Drawing.Size(131, 44);
            this.Clockwise.TabIndex = 37;
            this.Clockwise.TabStop = false;
            this.Clockwise.Text = "Clockwise (L)";
            this.Clockwise.UseVisualStyleBackColor = false;
            // 
            // Counter
            // 
            this.Counter.BackColor = System.Drawing.Color.White;
            this.Counter.Location = new System.Drawing.Point(468, 352);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(131, 44);
            this.Counter.TabIndex = 36;
            this.Counter.TabStop = false;
            this.Counter.Text = "Counter (J)";
            this.Counter.UseVisualStyleBackColor = false;
            // 
            // Downward
            // 
            this.Downward.BackColor = System.Drawing.Color.White;
            this.Downward.Location = new System.Drawing.Point(603, 402);
            this.Downward.Name = "Downward";
            this.Downward.Size = new System.Drawing.Size(131, 44);
            this.Downward.TabIndex = 35;
            this.Downward.TabStop = false;
            this.Downward.Text = "Downward (K)";
            this.Downward.UseVisualStyleBackColor = false;
            // 
            // Upward
            // 
            this.Upward.BackColor = System.Drawing.Color.White;
            this.Upward.Location = new System.Drawing.Point(603, 302);
            this.Upward.Name = "Upward";
            this.Upward.Size = new System.Drawing.Size(131, 44);
            this.Upward.TabIndex = 34;
            this.Upward.TabStop = false;
            this.Upward.Text = "Upward (I)";
            this.Upward.UseVisualStyleBackColor = false;
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.Color.White;
            this.Left.Location = new System.Drawing.Point(257, 349);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(128, 44);
            this.Left.TabIndex = 33;
            this.Left.TabStop = false;
            this.Left.Text = "Left (D)";
            this.Left.UseVisualStyleBackColor = false;
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.Color.White;
            this.Right.Location = new System.Drawing.Point(3, 349);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(131, 44);
            this.Right.TabIndex = 32;
            this.Right.TabStop = false;
            this.Right.Text = "Right (A)";
            this.Right.UseVisualStyleBackColor = false;
            // 
            // Backward
            // 
            this.Backward.BackColor = System.Drawing.Color.White;
            this.Backward.Location = new System.Drawing.Point(131, 399);
            this.Backward.Name = "Backward";
            this.Backward.Size = new System.Drawing.Size(131, 44);
            this.Backward.TabIndex = 31;
            this.Backward.TabStop = false;
            this.Backward.Text = "Backward (S)";
            this.Backward.UseVisualStyleBackColor = false;
            // 
            // Forward
            // 
            this.Forward.BackColor = System.Drawing.Color.White;
            this.Forward.Location = new System.Drawing.Point(131, 302);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(131, 44);
            this.Forward.TabIndex = 30;
            this.Forward.TabStop = false;
            this.Forward.Text = "Forward (W)";
            this.Forward.UseVisualStyleBackColor = false;
            // 
            // GetPos
            // 
            this.GetPos.BackColor = System.Drawing.Color.White;
            this.GetPos.Location = new System.Drawing.Point(12, 166);
            this.GetPos.Name = "GetPos";
            this.GetPos.Size = new System.Drawing.Size(116, 35);
            this.GetPos.TabIndex = 29;
            this.GetPos.TabStop = false;
            this.GetPos.Text = "Get Positions";
            this.GetPos.UseVisualStyleBackColor = false;
            this.GetPos.Click += new System.EventHandler(this.GetPos_Click);
            // 
            // PosY
            // 
            this.PosY.AutoSize = true;
            this.PosY.Location = new System.Drawing.Point(15, 47);
            this.PosY.Name = "PosY";
            this.PosY.Size = new System.Drawing.Size(75, 17);
            this.PosY.TabIndex = 27;
            this.PosY.Text = "Position Y:";
            // 
            // PosX
            // 
            this.PosX.AutoSize = true;
            this.PosX.Location = new System.Drawing.Point(15, 18);
            this.PosX.Name = "PosX";
            this.PosX.Size = new System.Drawing.Size(75, 17);
            this.PosX.TabIndex = 26;
            this.PosX.Text = "Position X:";
            // 
            // Land
            // 
            this.Land.BackColor = System.Drawing.Color.White;
            this.Land.Location = new System.Drawing.Point(702, 39);
            this.Land.Name = "Land";
            this.Land.Size = new System.Drawing.Size(174, 70);
            this.Land.TabIndex = 22;
            this.Land.TabStop = false;
            this.Land.Text = "Land (Y)";
            this.Land.UseVisualStyleBackColor = false;
            // 
            // Takeoff
            // 
            this.Takeoff.BackColor = System.Drawing.Color.White;
            this.Takeoff.Location = new System.Drawing.Point(459, 39);
            this.Takeoff.Name = "Takeoff";
            this.Takeoff.Size = new System.Drawing.Size(175, 70);
            this.Takeoff.TabIndex = 21;
            this.Takeoff.TabStop = false;
            this.Takeoff.Text = "Take Off (T)";
            this.Takeoff.UseVisualStyleBackColor = false;
            // 
            // chart1
            // 
            chartArea3.AxisX.Title = "Position X";
            chartArea3.AxisY.Title = "Position Y";
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(882, 28);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.Legend = "Legend1";
            series5.Name = "Trajectory 2D";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series6.Legend = "Legend1";
            series6.Name = "Origin";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(873, 626);
            this.chart1.TabIndex = 39;
            this.chart1.TabStop = false;
            this.chart1.Text = "chart1";
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Location = new System.Drawing.Point(15, 77);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(49, 17);
            this.Height.TabIndex = 44;
            this.Height.Text = "Height";
            // 
            // markOrigin
            // 
            this.markOrigin.BackColor = System.Drawing.Color.White;
            this.markOrigin.Location = new System.Drawing.Point(208, 42);
            this.markOrigin.Name = "markOrigin";
            this.markOrigin.Size = new System.Drawing.Size(175, 70);
            this.markOrigin.TabIndex = 46;
            this.markOrigin.TabStop = false;
            this.markOrigin.Text = "Mark Origin (R)";
            this.markOrigin.UseVisualStyleBackColor = false;
            this.markOrigin.Click += new System.EventHandler(this.markOrigin_Click);
            // 
            // YawAngel
            // 
            this.YawAngel.AutoSize = true;
            this.YawAngel.Location = new System.Drawing.Point(15, 107);
            this.YawAngel.Name = "YawAngel";
            this.YawAngel.Size = new System.Drawing.Size(82, 17);
            this.YawAngel.TabIndex = 47;
            this.YawAngel.Text = "Yaw Angle: ";
            // 
            // Battery
            // 
            this.Battery.AutoSize = true;
            this.Battery.Location = new System.Drawing.Point(15, 136);
            this.Battery.Name = "Battery";
            this.Battery.Size = new System.Drawing.Size(53, 17);
            this.Battery.TabIndex = 49;
            this.Battery.Text = "Battery";
            // 
            // basic_gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1767, 676);
            this.Controls.Add(this.Battery);
            this.Controls.Add(this.YawAngel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.markOrigin);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Hover);
            this.Controls.Add(this.Clockwise);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.Downward);
            this.Controls.Add(this.Upward);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Backward);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.GetPos);
            this.Controls.Add(this.PosY);
            this.Controls.Add(this.PosX);
            this.Controls.Add(this.Land);
            this.Controls.Add(this.Takeoff);
            this.Name = "basic_gui";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Hover;
        private System.Windows.Forms.Button Clockwise;
        private System.Windows.Forms.Button Counter;
        private System.Windows.Forms.Button Downward;
        private System.Windows.Forms.Button Upward;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Backward;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Button GetPos;
        private System.Windows.Forms.Label PosY;
        private System.Windows.Forms.Label PosX;
        private System.Windows.Forms.Button Land;
        private System.Windows.Forms.Button Takeoff;
        private Chart chart1;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Button markOrigin;
        private System.Windows.Forms.Label YawAngel;
        private System.Windows.Forms.Label Battery;
    }
}

