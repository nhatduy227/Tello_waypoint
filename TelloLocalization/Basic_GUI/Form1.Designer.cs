﻿using TelloLib;
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Land = new System.Windows.Forms.Button();
            this.Takeoff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // Update positioning in time inverval of 2s
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Hover
            // 
            this.Hover.BackColor = System.Drawing.Color.White;
            this.Hover.Location = new System.Drawing.Point(416, 399);
            this.Hover.Name = "Hover";
            this.Hover.Size = new System.Drawing.Size(176, 44);
            this.Hover.TabIndex = 38;
            this.Hover.TabStop = false;
            this.Hover.Text = "Hover";
            this.Hover.UseVisualStyleBackColor = false;
            // 
            // Clockwise
            // 
            this.Clockwise.BackColor = System.Drawing.Color.White;
            this.Clockwise.Location = new System.Drawing.Point(858, 296);
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
            this.Counter.Location = new System.Drawing.Point(593, 296);
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
            this.Downward.Location = new System.Drawing.Point(728, 346);
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
            this.Upward.Location = new System.Drawing.Point(728, 246);
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
            this.Left.Location = new System.Drawing.Point(281, 293);
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
            this.Right.Location = new System.Drawing.Point(24, 293);
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
            this.Backward.Location = new System.Drawing.Point(152, 343);
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
            this.Forward.Location = new System.Drawing.Point(152, 246);
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
            this.GetPos.Location = new System.Drawing.Point(20, 118);
            this.GetPos.Name = "GetPos";
            this.GetPos.Size = new System.Drawing.Size(116, 35);
            this.GetPos.TabIndex = 29;
            this.GetPos.TabStop = false;
            this.GetPos.Text = "Get Positions";
            this.GetPos.UseVisualStyleBackColor = false;
            this.GetPos.Click += new System.EventHandler(this.GetPos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "label6";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Poz_Z";
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
            this.Land.Location = new System.Drawing.Point(836, 36);
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
            this.Takeoff.Location = new System.Drawing.Point(593, 36);
            this.Takeoff.Name = "Takeoff";
            this.Takeoff.Size = new System.Drawing.Size(175, 70);
            this.Takeoff.TabIndex = 21;
            this.Takeoff.TabStop = false;
            this.Takeoff.Text = "Take Off";
            this.Takeoff.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 676);
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
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Land);
            this.Controls.Add(this.Takeoff);
            this.Name = "Form1";
            this.Text = " ";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Land;
        private System.Windows.Forms.Button Takeoff;
    }
}

