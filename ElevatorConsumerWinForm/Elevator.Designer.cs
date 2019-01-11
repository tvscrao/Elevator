namespace ElevatorConsumerWinForm
{
    partial class Elevator
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
            this.textBoxLowestFloor = new System.Windows.Forms.TextBox();
            this.textBoxHighestFloor = new System.Windows.Forms.TextBox();
            this.textBoxElevatorCount = new System.Windows.Forms.TextBox();
            this.labelLowestFloor = new System.Windows.Forms.Label();
            this.labelHighestFloorNumber = new System.Windows.Forms.Label();
            this.labelNoOfElevators = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFloorsInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelElevatorsInfo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelFloorId = new System.Windows.Forms.Label();
            this.textBoxFloorId = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelElevatorResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelElevatorsCurrentStatusInfo = new System.Windows.Forms.Label();
            this.labelTotalFloorsInfo = new System.Windows.Forms.Label();
            this.btnInitializeBuilding = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonUP = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.labelOptimalElevator = new System.Windows.Forms.Label();
            this.labelChooseElevator = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLowestFloor
            // 
            this.textBoxLowestFloor.Location = new System.Drawing.Point(128, 28);
            this.textBoxLowestFloor.Name = "textBoxLowestFloor";
            this.textBoxLowestFloor.Size = new System.Drawing.Size(100, 20);
            this.textBoxLowestFloor.TabIndex = 0;
            this.textBoxLowestFloor.Text = "-2";
            // 
            // textBoxHighestFloor
            // 
            this.textBoxHighestFloor.Location = new System.Drawing.Point(128, 64);
            this.textBoxHighestFloor.Name = "textBoxHighestFloor";
            this.textBoxHighestFloor.Size = new System.Drawing.Size(100, 20);
            this.textBoxHighestFloor.TabIndex = 1;
            this.textBoxHighestFloor.Text = "10";
            // 
            // textBoxElevatorCount
            // 
            this.textBoxElevatorCount.Location = new System.Drawing.Point(128, 98);
            this.textBoxElevatorCount.Name = "textBoxElevatorCount";
            this.textBoxElevatorCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxElevatorCount.TabIndex = 2;
            this.textBoxElevatorCount.Text = "3";
            // 
            // labelLowestFloor
            // 
            this.labelLowestFloor.AutoSize = true;
            this.labelLowestFloor.Location = new System.Drawing.Point(9, 35);
            this.labelLowestFloor.Name = "labelLowestFloor";
            this.labelLowestFloor.Size = new System.Drawing.Size(73, 13);
            this.labelLowestFloor.TabIndex = 3;
            this.labelLowestFloor.Text = "Lowest Floor :";
            // 
            // labelHighestFloorNumber
            // 
            this.labelHighestFloorNumber.AutoSize = true;
            this.labelHighestFloorNumber.Location = new System.Drawing.Point(9, 64);
            this.labelHighestFloorNumber.Name = "labelHighestFloorNumber";
            this.labelHighestFloorNumber.Size = new System.Drawing.Size(75, 13);
            this.labelHighestFloorNumber.TabIndex = 4;
            this.labelHighestFloorNumber.Text = "Highest Floor :";
            // 
            // labelNoOfElevators
            // 
            this.labelNoOfElevators.AutoSize = true;
            this.labelNoOfElevators.Location = new System.Drawing.Point(9, 105);
            this.labelNoOfElevators.Name = "labelNoOfElevators";
            this.labelNoOfElevators.Size = new System.Drawing.Size(88, 13);
            this.labelNoOfElevators.TabIndex = 5;
            this.labelNoOfElevators.Text = "Elevators Count :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelTotalFloorsInfo);
            this.panel1.Controls.Add(this.labelFloorsInfo);
            this.panel1.Location = new System.Drawing.Point(327, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 249);
            this.panel1.TabIndex = 7;
            // 
            // labelFloorsInfo
            // 
            this.labelFloorsInfo.AutoSize = true;
            this.labelFloorsInfo.Location = new System.Drawing.Point(28, 13);
            this.labelFloorsInfo.Name = "labelFloorsInfo";
            this.labelFloorsInfo.Size = new System.Drawing.Size(0, 13);
            this.labelFloorsInfo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxElevatorCount);
            this.panel2.Controls.Add(this.textBoxLowestFloor);
            this.panel2.Controls.Add(this.textBoxHighestFloor);
            this.panel2.Controls.Add(this.labelNoOfElevators);
            this.panel2.Controls.Add(this.labelLowestFloor);
            this.panel2.Controls.Add(this.labelHighestFloorNumber);
            this.panel2.Location = new System.Drawing.Point(65, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 249);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.labelElevatorsCurrentStatusInfo);
            this.panel3.Controls.Add(this.labelElevatorsInfo);
            this.panel3.Location = new System.Drawing.Point(539, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(389, 249);
            this.panel3.TabIndex = 9;
            // 
            // labelElevatorsInfo
            // 
            this.labelElevatorsInfo.AutoSize = true;
            this.labelElevatorsInfo.Location = new System.Drawing.Point(20, 47);
            this.labelElevatorsInfo.Name = "labelElevatorsInfo";
            this.labelElevatorsInfo.Size = new System.Drawing.Size(0, 13);
            this.labelElevatorsInfo.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.labelChooseElevator);
            this.panel4.Controls.Add(this.buttonDown);
            this.panel4.Controls.Add(this.buttonUP);
            this.panel4.Controls.Add(this.labelFloorId);
            this.panel4.Controls.Add(this.textBoxFloorId);
            this.panel4.Location = new System.Drawing.Point(63, 361);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 139);
            this.panel4.TabIndex = 10;
            // 
            // labelFloorId
            // 
            this.labelFloorId.AutoSize = true;
            this.labelFloorId.Location = new System.Drawing.Point(4, 34);
            this.labelFloorId.Name = "labelFloorId";
            this.labelFloorId.Size = new System.Drawing.Size(112, 13);
            this.labelFloorId.TabIndex = 1;
            this.labelFloorId.Text = "Passenger in Floor Id :";
            // 
            // textBoxFloorId
            // 
            this.textBoxFloorId.Location = new System.Drawing.Point(116, 30);
            this.textBoxFloorId.Name = "textBoxFloorId";
            this.textBoxFloorId.Size = new System.Drawing.Size(100, 20);
            this.textBoxFloorId.TabIndex = 0;
            this.textBoxFloorId.Text = "3";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.labelOptimalElevator);
            this.panel5.Controls.Add(this.labelElevatorResult);
            this.panel5.Location = new System.Drawing.Point(329, 361);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(598, 139);
            this.panel5.TabIndex = 11;
            // 
            // labelElevatorResult
            // 
            this.labelElevatorResult.AutoSize = true;
            this.labelElevatorResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElevatorResult.ForeColor = System.Drawing.Color.Green;
            this.labelElevatorResult.Location = new System.Drawing.Point(21, 26);
            this.labelElevatorResult.Name = "labelElevatorResult";
            this.labelElevatorResult.Size = new System.Drawing.Size(0, 13);
            this.labelElevatorResult.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Initial Configurations :";
            // 
            // labelElevatorsCurrentStatusInfo
            // 
            this.labelElevatorsCurrentStatusInfo.AutoSize = true;
            this.labelElevatorsCurrentStatusInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElevatorsCurrentStatusInfo.Location = new System.Drawing.Point(21, 12);
            this.labelElevatorsCurrentStatusInfo.Name = "labelElevatorsCurrentStatusInfo";
            this.labelElevatorsCurrentStatusInfo.Size = new System.Drawing.Size(153, 13);
            this.labelElevatorsCurrentStatusInfo.TabIndex = 1;
            this.labelElevatorsCurrentStatusInfo.Text = "Elevators Current Status :";
            // 
            // labelTotalFloorsInfo
            // 
            this.labelTotalFloorsInfo.AutoSize = true;
            this.labelTotalFloorsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalFloorsInfo.Location = new System.Drawing.Point(6, 6);
            this.labelTotalFloorsInfo.Name = "labelTotalFloorsInfo";
            this.labelTotalFloorsInfo.Size = new System.Drawing.Size(166, 13);
            this.labelTotalFloorsInfo.TabIndex = 1;
            this.labelTotalFloorsInfo.Text = "Total Floors in the building :";
            this.labelTotalFloorsInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnInitializeBuilding
            // 
            this.btnInitializeBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitializeBuilding.Location = new System.Drawing.Point(61, 300);
            this.btnInitializeBuilding.Name = "btnInitializeBuilding";
            this.btnInitializeBuilding.Size = new System.Drawing.Size(868, 31);
            this.btnInitializeBuilding.TabIndex = 12;
            this.btnInitializeBuilding.Text = "Initialize Building";
            this.btnInitializeBuilding.UseVisualStyleBackColor = true;
            this.btnInitializeBuilding.Click += new System.EventHandler(this.btnInitializeBuilding_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(62, 9);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 13;
            // 
            // buttonUP
            // 
            this.buttonUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUP.Location = new System.Drawing.Point(116, 61);
            this.buttonUP.Name = "buttonUP";
            this.buttonUP.Size = new System.Drawing.Size(99, 23);
            this.buttonUP.TabIndex = 3;
            this.buttonUP.Text = "Up";
            this.buttonUP.UseVisualStyleBackColor = true;
            this.buttonUP.Click += new System.EventHandler(this.buttonUP_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDown.Location = new System.Drawing.Point(116, 98);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(100, 23);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // labelOptimalElevator
            // 
            this.labelOptimalElevator.AutoSize = true;
            this.labelOptimalElevator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOptimalElevator.Location = new System.Drawing.Point(4, 4);
            this.labelOptimalElevator.Name = "labelOptimalElevator";
            this.labelOptimalElevator.Size = new System.Drawing.Size(51, 13);
            this.labelOptimalElevator.TabIndex = 1;
            this.labelOptimalElevator.Text = "Result :";
            // 
            // labelChooseElevator
            // 
            this.labelChooseElevator.AutoSize = true;
            this.labelChooseElevator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseElevator.Location = new System.Drawing.Point(4, 8);
            this.labelChooseElevator.Name = "labelChooseElevator";
            this.labelChooseElevator.Size = new System.Drawing.Size(188, 13);
            this.labelChooseElevator.TabIndex = 5;
            this.labelChooseElevator.Text = "Choose Elevator and Direction :";
            // 
            // Elevator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 562);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.btnInitializeBuilding);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Elevator";
            this.Text = "Elevator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLowestFloor;
        private System.Windows.Forms.TextBox textBoxHighestFloor;
        private System.Windows.Forms.TextBox textBoxElevatorCount;
        private System.Windows.Forms.Label labelLowestFloor;
        private System.Windows.Forms.Label labelHighestFloorNumber;
        private System.Windows.Forms.Label labelNoOfElevators;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelFloorsInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelElevatorsInfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelFloorId;
        private System.Windows.Forms.TextBox textBoxFloorId;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelElevatorResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelElevatorsCurrentStatusInfo;
        private System.Windows.Forms.Label labelTotalFloorsInfo;
        private System.Windows.Forms.Button btnInitializeBuilding;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUP;
        private System.Windows.Forms.Label labelOptimalElevator;
        private System.Windows.Forms.Label labelChooseElevator;
    }
}

