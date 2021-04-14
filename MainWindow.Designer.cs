namespace ModelingTheFlowOfEvents
{
    partial class MainWindow
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
            this.exponentialDistributionPanel = new System.Windows.Forms.Panel();
            this.lambdaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buildButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.uniformDistributionPanel = new System.Windows.Forms.Panel();
            this.rightBoundaryValueTextBox = new System.Windows.Forms.TextBox();
            this.leftBoundaryValueTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalTimeTextBox = new System.Windows.Forms.TextBox();
            this.geometricDistributionPanel = new System.Windows.Forms.Panel();
            this.eventProbabilityTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.discreteDistributionBox = new System.Windows.Forms.ComboBox();
            this.continuousDistributionBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.exponentialDistributionPanel.SuspendLayout();
            this.uniformDistributionPanel.SuspendLayout();
            this.geometricDistributionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(82, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select interval length distribution:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exponentialDistributionPanel
            // 
            this.exponentialDistributionPanel.Controls.Add(this.lambdaTextBox);
            this.exponentialDistributionPanel.Controls.Add(this.label2);
            this.exponentialDistributionPanel.Location = new System.Drawing.Point(82, 116);
            this.exponentialDistributionPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.exponentialDistributionPanel.Name = "exponentialDistributionPanel";
            this.exponentialDistributionPanel.Size = new System.Drawing.Size(472, 63);
            this.exponentialDistributionPanel.TabIndex = 1;
            this.exponentialDistributionPanel.Visible = false;
            // 
            // lambdaTextBox
            // 
            this.lambdaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lambdaTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lambdaTextBox.Location = new System.Drawing.Point(171, 25);
            this.lambdaTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lambdaTextBox.MaxLength = 1;
            this.lambdaTextBox.Multiline = true;
            this.lambdaTextBox.Name = "lambdaTextBox";
            this.lambdaTextBox.Size = new System.Drawing.Size(100, 17);
            this.lambdaTextBox.TabIndex = 2;
            this.lambdaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the flow rate:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buildButton
            // 
            this.buildButton.BackColor = System.Drawing.SystemColors.Window;
            this.buildButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buildButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buildButton.Location = new System.Drawing.Point(467, 353);
            this.buildButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(162, 33);
            this.buildButton.TabIndex = 7;
            this.buildButton.Text = "Build";
            this.buildButton.UseVisualStyleBackColor = false;
            this.buildButton.Click += new System.EventHandler(this.BuildButtonClick);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(82, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select event volume distribution:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uniformDistributionPanel
            // 
            this.uniformDistributionPanel.Controls.Add(this.rightBoundaryValueTextBox);
            this.uniformDistributionPanel.Controls.Add(this.leftBoundaryValueTextBox);
            this.uniformDistributionPanel.Controls.Add(this.label4);
            this.uniformDistributionPanel.Controls.Add(this.label5);
            this.uniformDistributionPanel.Location = new System.Drawing.Point(82, 219);
            this.uniformDistributionPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uniformDistributionPanel.Name = "uniformDistributionPanel";
            this.uniformDistributionPanel.Size = new System.Drawing.Size(467, 131);
            this.uniformDistributionPanel.TabIndex = 5;
            this.uniformDistributionPanel.Visible = false;
            // 
            // rightBoundaryValueTextBox
            // 
            this.rightBoundaryValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rightBoundaryValueTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightBoundaryValueTextBox.Location = new System.Drawing.Point(268, 85);
            this.rightBoundaryValueTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rightBoundaryValueTextBox.MaxLength = 7;
            this.rightBoundaryValueTextBox.Multiline = true;
            this.rightBoundaryValueTextBox.Name = "rightBoundaryValueTextBox";
            this.rightBoundaryValueTextBox.Size = new System.Drawing.Size(100, 17);
            this.rightBoundaryValueTextBox.TabIndex = 5;
            this.rightBoundaryValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // leftBoundaryValueTextBox
            // 
            this.leftBoundaryValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.leftBoundaryValueTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftBoundaryValueTextBox.Location = new System.Drawing.Point(258, 32);
            this.leftBoundaryValueTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.leftBoundaryValueTextBox.MaxLength = 7;
            this.leftBoundaryValueTextBox.Multiline = true;
            this.leftBoundaryValueTextBox.Name = "leftBoundaryValueTextBox";
            this.leftBoundaryValueTextBox.Size = new System.Drawing.Size(100, 17);
            this.leftBoundaryValueTextBox.TabIndex = 4;
            this.leftBoundaryValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "Enter the left boundary value:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(0, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "Enter the right boundary value:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(82, 353);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 33);
            this.label6.TabIndex = 6;
            this.label6.Text = "Time:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalTimeTextBox
            // 
            this.totalTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalTimeTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalTimeTextBox.Location = new System.Drawing.Point(143, 363);
            this.totalTimeTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.totalTimeTextBox.MaxLength = 3;
            this.totalTimeTextBox.Multiline = true;
            this.totalTimeTextBox.Name = "totalTimeTextBox";
            this.totalTimeTextBox.Size = new System.Drawing.Size(100, 17);
            this.totalTimeTextBox.TabIndex = 6;
            this.totalTimeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // geometricDistributionPanel
            // 
            this.geometricDistributionPanel.Controls.Add(this.eventProbabilityTextBox);
            this.geometricDistributionPanel.Controls.Add(this.label7);
            this.geometricDistributionPanel.Location = new System.Drawing.Point(82, 241);
            this.geometricDistributionPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.geometricDistributionPanel.Name = "geometricDistributionPanel";
            this.geometricDistributionPanel.Size = new System.Drawing.Size(547, 33);
            this.geometricDistributionPanel.TabIndex = 9;
            this.geometricDistributionPanel.Visible = false;
            // 
            // eventProbabilityTextBox
            // 
            this.eventProbabilityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventProbabilityTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventProbabilityTextBox.Location = new System.Drawing.Point(373, 10);
            this.eventProbabilityTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.eventProbabilityTextBox.MaxLength = 7;
            this.eventProbabilityTextBox.Multiline = true;
            this.eventProbabilityTextBox.Name = "eventProbabilityTextBox";
            this.eventProbabilityTextBox.Size = new System.Drawing.Size(100, 17);
            this.eventProbabilityTextBox.TabIndex = 4;
            this.eventProbabilityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(369, 33);
            this.label7.TabIndex = 2;
            this.label7.Text = "Enter the probability of the event occurring:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // discreteDistributionBox
            // 
            this.discreteDistributionBox.BackColor = System.Drawing.Color.White;
            this.discreteDistributionBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discreteDistributionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.discreteDistributionBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discreteDistributionBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discreteDistributionBox.FormattingEnabled = true;
            this.discreteDistributionBox.Items.AddRange(new object[] {
            "Uniform distribution",
            "Geometric distribution"});
            this.discreteDistributionBox.Location = new System.Drawing.Point(382, 190);
            this.discreteDistributionBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.discreteDistributionBox.Name = "discreteDistributionBox";
            this.discreteDistributionBox.Size = new System.Drawing.Size(247, 26);
            this.discreteDistributionBox.TabIndex = 3;
            this.discreteDistributionBox.SelectedIndexChanged += new System.EventHandler(this.DiscreteDistributionBoxSelectedIndexChanged);
            // 
            // continuousDistributionBox
            // 
            this.continuousDistributionBox.BackColor = System.Drawing.Color.White;
            this.continuousDistributionBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continuousDistributionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.continuousDistributionBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continuousDistributionBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.continuousDistributionBox.Items.AddRange(new object[] {
            "Exponential distribution"});
            this.continuousDistributionBox.Location = new System.Drawing.Point(382, 81);
            this.continuousDistributionBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.continuousDistributionBox.Name = "continuousDistributionBox";
            this.continuousDistributionBox.Size = new System.Drawing.Size(247, 26);
            this.continuousDistributionBox.TabIndex = 1;
            this.continuousDistributionBox.SelectedIndexChanged += new System.EventHandler(this.ContinuousDistributionBoxSelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(189, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(360, 33);
            this.label8.TabIndex = 10;
            this.label8.Text = "Modeling the flow of events";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(723, 446);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.continuousDistributionBox);
            this.Controls.Add(this.discreteDistributionBox);
            this.Controls.Add(this.uniformDistributionPanel);
            this.Controls.Add(this.geometricDistributionPanel);
            this.Controls.Add(this.totalTimeTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buildButton);
            this.Controls.Add(this.exponentialDistributionPanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.exponentialDistributionPanel.ResumeLayout(false);
            this.exponentialDistributionPanel.PerformLayout();
            this.uniformDistributionPanel.ResumeLayout(false);
            this.uniformDistributionPanel.PerformLayout();
            this.geometricDistributionPanel.ResumeLayout(false);
            this.geometricDistributionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel exponentialDistributionPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lambdaTextBox;
        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel uniformDistributionPanel;
        private System.Windows.Forms.TextBox leftBoundaryValueTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rightBoundaryValueTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalTimeTextBox;
        private System.Windows.Forms.Panel geometricDistributionPanel;
        private System.Windows.Forms.TextBox eventProbabilityTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox discreteDistributionBox;
        private System.Windows.Forms.ComboBox continuousDistributionBox;
        private System.Windows.Forms.Label label8;
    }
}