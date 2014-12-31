namespace VehicleApp
{
    partial class VehicleUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.vehicleNameTextBox = new System.Windows.Forms.TextBox();
            this.regNoTextBox = new System.Windows.Forms.TextBox();
            this.inputSpeedTextBox = new System.Windows.Forms.TextBox();
            this.minSpeedTextBox = new System.Windows.Forms.TextBox();
            this.averageSpeedTextBox = new System.Windows.Forms.TextBox();
            this.maxSpeedTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vehicle Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Reg No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Min Speed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Max Speed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Average";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Kilo/Hr";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(282, 48);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(282, 94);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 4;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(282, 167);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 5;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // vehicleNameTextBox
            // 
            this.vehicleNameTextBox.Location = new System.Drawing.Point(107, 25);
            this.vehicleNameTextBox.Name = "vehicleNameTextBox";
            this.vehicleNameTextBox.Size = new System.Drawing.Size(169, 20);
            this.vehicleNameTextBox.TabIndex = 0;
            // 
            // regNoTextBox
            // 
            this.regNoTextBox.Location = new System.Drawing.Point(107, 50);
            this.regNoTextBox.Name = "regNoTextBox";
            this.regNoTextBox.Size = new System.Drawing.Size(169, 20);
            this.regNoTextBox.TabIndex = 1;
            // 
            // inputSpeedTextBox
            // 
            this.inputSpeedTextBox.Location = new System.Drawing.Point(107, 96);
            this.inputSpeedTextBox.Name = "inputSpeedTextBox";
            this.inputSpeedTextBox.Size = new System.Drawing.Size(123, 20);
            this.inputSpeedTextBox.TabIndex = 3;
            // 
            // minSpeedTextBox
            // 
            this.minSpeedTextBox.Location = new System.Drawing.Point(107, 142);
            this.minSpeedTextBox.Name = "minSpeedTextBox";
            this.minSpeedTextBox.ReadOnly = true;
            this.minSpeedTextBox.Size = new System.Drawing.Size(169, 20);
            this.minSpeedTextBox.TabIndex = 6;
            // 
            // averageSpeedTextBox
            // 
            this.averageSpeedTextBox.Location = new System.Drawing.Point(107, 196);
            this.averageSpeedTextBox.Name = "averageSpeedTextBox";
            this.averageSpeedTextBox.ReadOnly = true;
            this.averageSpeedTextBox.Size = new System.Drawing.Size(169, 20);
            this.averageSpeedTextBox.TabIndex = 8;
            // 
            // maxSpeedTextBox
            // 
            this.maxSpeedTextBox.Location = new System.Drawing.Point(107, 169);
            this.maxSpeedTextBox.Name = "maxSpeedTextBox";
            this.maxSpeedTextBox.ReadOnly = true;
            this.maxSpeedTextBox.Size = new System.Drawing.Size(169, 20);
            this.maxSpeedTextBox.TabIndex = 7;
            // 
            // VehicleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 245);
            this.Controls.Add(this.averageSpeedTextBox);
            this.Controls.Add(this.maxSpeedTextBox);
            this.Controls.Add(this.minSpeedTextBox);
            this.Controls.Add(this.inputSpeedTextBox);
            this.Controls.Add(this.regNoTextBox);
            this.Controls.Add(this.vehicleNameTextBox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VehicleUI";
            this.Text = "Vehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox vehicleNameTextBox;
        private System.Windows.Forms.TextBox regNoTextBox;
        private System.Windows.Forms.TextBox inputSpeedTextBox;
        private System.Windows.Forms.TextBox minSpeedTextBox;
        private System.Windows.Forms.TextBox averageSpeedTextBox;
        private System.Windows.Forms.TextBox maxSpeedTextBox;
    }
}

