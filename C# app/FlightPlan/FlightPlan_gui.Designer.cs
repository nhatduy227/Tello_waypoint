
namespace Swarmming
{
    partial class FlightPlan_gui
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
            this.input = new System.Windows.Forms.TextBox();
            this.Instruction = new System.Windows.Forms.Label();
            this.addInstructions = new System.Windows.Forms.Button();
            this.insList = new System.Windows.Forms.Label();
            this.delInstrutions = new System.Windows.Forms.Button();
            this.Run = new System.Windows.Forms.Button();
            this.runningText = new System.Windows.Forms.Label();
            this.currentStage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.AutoCompleteCustomSource.AddRange(new string[] {
            "\"takeoff\"",
            "\"land\"",
            "\"up 20\"",
            "\"down 20\"",
            "\"left 20\"",
            "\"right 20\""});
            this.input.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.input.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(15, 71);
            this.input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(287, 22);
            this.input.TabIndex = 0;
            // 
            // Instruction
            // 
            this.Instruction.AutoSize = true;
            this.Instruction.Location = new System.Drawing.Point(12, 39);
            this.Instruction.Name = "Instruction";
            this.Instruction.Size = new System.Drawing.Size(252, 17);
            this.Instruction.TabIndex = 6;
            this.Instruction.Text = "Input instructions to create a flight plan";
            // 
            // addInstructions
            // 
            this.addInstructions.Location = new System.Drawing.Point(325, 66);
            this.addInstructions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addInstructions.Name = "addInstructions";
            this.addInstructions.Size = new System.Drawing.Size(133, 34);
            this.addInstructions.TabIndex = 7;
            this.addInstructions.Text = "Add Instructions";
            this.addInstructions.UseVisualStyleBackColor = true;
            this.addInstructions.Click += new System.EventHandler(this.Add_Instruction_Click);
            // 
            // insList
            // 
            this.insList.AutoSize = true;
            this.insList.Location = new System.Drawing.Point(12, 114);
            this.insList.Name = "insList";
            this.insList.Size = new System.Drawing.Size(118, 17);
            this.insList.TabIndex = 8;
            this.insList.Text = "No instruction yet";
            // 
            // delInstrutions
            // 
            this.delInstrutions.Location = new System.Drawing.Point(475, 66);
            this.delInstrutions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delInstrutions.Name = "delInstrutions";
            this.delInstrutions.Size = new System.Drawing.Size(133, 34);
            this.delInstrutions.TabIndex = 9;
            this.delInstrutions.Text = "Delete All";
            this.delInstrutions.UseVisualStyleBackColor = true;
            this.delInstrutions.Click += new System.EventHandler(this.delInstrutions_Click);
            // 
            // Run
            // 
            this.Run.Enabled = false;
            this.Run.Location = new System.Drawing.Point(627, 66);
            this.Run.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(133, 34);
            this.Run.TabIndex = 10;
            this.Run.Text = "Run Flight Plan";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // runningText
            // 
            this.runningText.AutoSize = true;
            this.runningText.Location = new System.Drawing.Point(472, 132);
            this.runningText.Name = "runningText";
            this.runningText.Size = new System.Drawing.Size(131, 17);
            this.runningText.TabIndex = 12;
            this.runningText.Text = "Running Flight Plan";
            this.runningText.Visible = false;
            // 
            // currentStage
            // 
            this.currentStage.AutoSize = true;
            this.currentStage.Location = new System.Drawing.Point(472, 165);
            this.currentStage.Name = "currentStage";
            this.currentStage.Size = new System.Drawing.Size(100, 17);
            this.currentStage.TabIndex = 13;
            this.currentStage.Text = "Current Stage:";
            this.currentStage.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FlightPlan_gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currentStage);
            this.Controls.Add(this.runningText);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.delInstrutions);
            this.Controls.Add(this.insList);
            this.Controls.Add(this.addInstructions);
            this.Controls.Add(this.Instruction);
            this.Controls.Add(this.input);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FlightPlan_gui";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label Instruction;
        private System.Windows.Forms.Button addInstructions;
        private System.Windows.Forms.Label insList;
        private System.Windows.Forms.Button delInstrutions;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Label runningText;
        private System.Windows.Forms.Label currentStage;
        private System.Windows.Forms.Timer timer1;
    }
}

