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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Land = new System.Windows.Forms.Button();
            this.Takeoff = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.markOrigin = new System.Windows.Forms.Button();
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
            this.Hover.Location = new System.Drawing.Point(257, 399);
            this.Hover.Name = "Hover";
            this.Hover.Size = new System.Drawing.Size(342, 44);
            this.Hover.TabIndex = 38;
            this.Hover.TabStop = false;
            this.Hover.Text = "Hover";
            this.Hover.UseVisualStyleBackColor = false;
            // 
            // Clockwise
            // 
            this.Clockwise.BackColor = System.Drawing.Color.White;
            this.Clockwise.Location = new System.Drawing.Point(733, 296);
            this.Clockwise.Name = "Clockwise";
            this.Clockwise.Size = new System.Drawing.Size(131, 44);
            this.Clockwise.TabIndex = 37;
            this.Clockwise.TabStop = false;
            this.Clockwise.Text = "Clockwise";
            this.Clockwise.UseVisualStyleBackColor = false;
            // 
            // Counter
            // 
            this.Counter.BackColor = System.Drawing.Color.White;
            this.Counter.Location = new System.Drawing.Point(468, 296);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(131, 44);
            this.Counter.TabIndex = 36;
            this.Counter.TabStop = false;
            this.Counter.Text = "Counter";
            this.Counter.UseVisualStyleBackColor = false;
            // 
            // Downward
            // 
            this.Downward.BackColor = System.Drawing.Color.White;
            this.Downward.Location = new System.Drawing.Point(603, 346);
            this.Downward.Name = "Downward";
            this.Downward.Size = new System.Drawing.Size(131, 44);
            this.Downward.TabIndex = 35;
            this.Downward.TabStop = false;
            this.Downward.Text = "Downward";
            this.Downward.UseVisualStyleBackColor = false;
            // 
            // Upward
            // 
            this.Upward.BackColor = System.Drawing.Color.White;
            this.Upward.Location = new System.Drawing.Point(603, 246);
            this.Upward.Name = "Upward";
            this.Upward.Size = new System.Drawing.Size(131, 44);
            this.Upward.TabIndex = 34;
            this.Upward.TabStop = false;
            this.Upward.Text = "Upward";
            this.Upward.UseVisualStyleBackColor = false;
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.Color.White;
            this.Left.Location = new System.Drawing.Point(257, 293);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(128, 44);
            this.Left.TabIndex = 33;
            this.Left.TabStop = false;
            this.Left.Text = "Left";
            this.Left.UseVisualStyleBackColor = false;
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.Color.White;
            this.Right.Location = new System.Drawing.Point(3, 293);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(131, 44);
            this.Right.TabIndex = 32;
            this.Right.TabStop = false;
            this.Right.Text = "Right";
            this.Right.UseVisualStyleBackColor = false;
            // 
            // Backward
            // 
            this.Backward.BackColor = System.Drawing.Color.White;
            this.Backward.Location = new System.Drawing.Point(131, 343);
            this.Backward.Name = "Backward";
            this.Backward.Size = new System.Drawing.Size(131, 44);
            this.Backward.TabIndex = 31;
            this.Backward.TabStop = false;
            this.Backward.Text = "Backward";
            this.Backward.UseVisualStyleBackColor = false;
            // 
            // Forward
            // 
            this.Forward.BackColor = System.Drawing.Color.White;
            this.Forward.Location = new System.Drawing.Point(131, 246);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(131, 44);
            this.Forward.TabIndex = 30;
            this.Forward.TabStop = false;
            this.Forward.Text = "Forward";
            this.Forward.UseVisualStyleBackColor = false;
            // 
            // GetPos
            // 
            this.GetPos.BackColor = System.Drawing.Color.White;
            this.GetPos.Location = new System.Drawing.Point(20, 120);
            this.GetPos.Name = "GetPos";
            this.GetPos.Size = new System.Drawing.Size(116, 35);
            this.GetPos.TabIndex = 29;
            this.GetPos.TabStop = false;
            this.GetPos.Text = "Get Positions";
            this.GetPos.UseVisualStyleBackColor = false;
            this.GetPos.Click += new System.EventHandler(this.GetPos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Pos_Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Pos_X";
            // 
            // Land
            // 
            this.Land.BackColor = System.Drawing.Color.White;
            this.Land.Location = new System.Drawing.Point(702, 39);
            this.Land.Name = "Land";
            this.Land.Size = new System.Drawing.Size(174, 70);
            this.Land.TabIndex = 22;
            this.Land.TabStop = false;
            this.Land.Text = "Land";
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
            this.Takeoff.Text = "Take Off";
            this.Takeoff.UseVisualStyleBackColor = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(882, 28);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Trajectory 2D";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(873, 626);
            this.chart1.TabIndex = 39;
            this.chart1.TabStop = false;
            this.chart1.Text = "chart1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 44;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 45;
            this.label9.Text = "Height";
            // 
            // markOrigin
            // 
            this.markOrigin.BackColor = System.Drawing.Color.White;
            this.markOrigin.Location = new System.Drawing.Point(208, 42);
            this.markOrigin.Name = "markOrigin";
            this.markOrigin.Size = new System.Drawing.Size(175, 70);
            this.markOrigin.TabIndex = 46;
            this.markOrigin.TabStop = false;
            this.markOrigin.Text = "Mark Origin";
            this.markOrigin.UseVisualStyleBackColor = false;
            this.markOrigin.Click += new System.EventHandler(this.markOrigin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1767, 676);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.markOrigin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Land);
            this.Controls.Add(this.Takeoff);
            this.Name = "Form1";
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Land;
        private System.Windows.Forms.Button Takeoff;
        private Chart chart1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button markOrigin;
    }
}

