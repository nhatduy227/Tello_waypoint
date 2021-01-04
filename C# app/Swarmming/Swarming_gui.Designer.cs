
namespace Swarmming
{
    partial class Swarming_gui
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
            this.inputIP = new System.Windows.Forms.TextBox();
            this.Scan = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.connectNoti = new System.Windows.Forms.Label();
            this.takeOff = new System.Windows.Forms.Button();
            this.Land = new System.Windows.Forms.Button();
            this.scanInstruction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputIP
            // 
            this.inputIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputIP.Location = new System.Drawing.Point(434, 41);
            this.inputIP.Name = "inputIP";
            this.inputIP.Size = new System.Drawing.Size(332, 22);
            this.inputIP.TabIndex = 0;
            // 
            // Scan
            // 
            this.Scan.Location = new System.Drawing.Point(12, 83);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(99, 46);
            this.Scan.TabIndex = 1;
            this.Scan.Text = "Scan";
            this.Scan.UseVisualStyleBackColor = true;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(667, 83);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(99, 46);
            this.Connect.TabIndex = 2;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // connectNoti
            // 
            this.connectNoti.AutoSize = true;
            this.connectNoti.Location = new System.Drawing.Point(431, 156);
            this.connectNoti.Name = "connectNoti";
            this.connectNoti.Size = new System.Drawing.Size(329, 17);
            this.connectNoti.TabIndex = 3;
            this.connectNoti.Text = "Input your drone\'s IP and click Connect to proceed ";
            // 
            // takeOff
            // 
            this.takeOff.Location = new System.Drawing.Point(430, 216);
            this.takeOff.Name = "takeOff";
            this.takeOff.Size = new System.Drawing.Size(99, 46);
            this.takeOff.TabIndex = 4;
            this.takeOff.Text = "Take Off ";
            this.takeOff.UseVisualStyleBackColor = true;
            this.takeOff.Visible = false;
            this.takeOff.Click += new System.EventHandler(this.takeOff_Click);
            // 
            // Land
            // 
            this.Land.Location = new System.Drawing.Point(576, 216);
            this.Land.Name = "Land";
            this.Land.Size = new System.Drawing.Size(99, 46);
            this.Land.TabIndex = 5;
            this.Land.Text = "Land ";
            this.Land.UseVisualStyleBackColor = true;
            this.Land.Visible = false;
            this.Land.Click += new System.EventHandler(this.Land_Click);
            // 
            // scanInstruction
            // 
            this.scanInstruction.AutoSize = true;
            this.scanInstruction.Location = new System.Drawing.Point(12, 41);
            this.scanInstruction.Name = "scanInstruction";
            this.scanInstruction.Size = new System.Drawing.Size(383, 17);
            this.scanInstruction.TabIndex = 6;
            this.scanInstruction.Text = "Click scan button to scan for available drone in the network ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scanInstruction);
            this.Controls.Add(this.Land);
            this.Controls.Add(this.takeOff);
            this.Controls.Add(this.connectNoti);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.Scan);
            this.Controls.Add(this.inputIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputIP;
        private System.Windows.Forms.Button Scan;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label connectNoti;
        private System.Windows.Forms.Button takeOff;
        private System.Windows.Forms.Button Land;
        private System.Windows.Forms.Label scanInstruction;
    }
}

