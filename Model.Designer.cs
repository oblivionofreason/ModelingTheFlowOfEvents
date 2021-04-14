namespace ModelingTheFlowOfEvents
{
    partial class Model
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.sizeOfEventsPerIntervalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.eventsPerIntervalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.restoreButton1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.leftBorderTextBox1 = new System.Windows.Forms.TextBox();
            this.rightBorderTextBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.intervalTextBox1 = new System.Windows.Forms.TextBox();
            this.updateButton1 = new System.Windows.Forms.Button();
            this.updateButton2 = new System.Windows.Forms.Button();
            this.intervalTextBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rightBorderTextBox2 = new System.Windows.Forms.TextBox();
            this.leftBorderTextBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.restoreButton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sizeOfEventsPerIntervalChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsPerIntervalChart)).BeginInit();
            this.SuspendLayout();
            // 
            // sizeOfEventsPerIntervalChart
            // 
            this.sizeOfEventsPerIntervalChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea3.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea3.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea3.AxisY.MajorGrid.Interval = 0D;
            chartArea3.AxisY.MajorGrid.IntervalOffset = 0D;
            chartArea3.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea3.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea3.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            chartArea3.Name = "ChartArea1";
            this.sizeOfEventsPerIntervalChart.ChartAreas.Add(chartArea3);
            this.sizeOfEventsPerIntervalChart.Location = new System.Drawing.Point(770, 83);
            this.sizeOfEventsPerIntervalChart.Name = "sizeOfEventsPerIntervalChart";
            series3.BorderColor = System.Drawing.Color.Black;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.DodgerBlue;
            series3.CustomProperties = "DrawSideBySide=False, EmptyPointValue=Zero, PointWidth=1, LabelStyle=Left";
            series3.EmptyPointStyle.AxisLabel = "g";
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series3.MarkerBorderColor = System.Drawing.Color.Transparent;
            series3.MarkerBorderWidth = 2;
            series3.Name = "Series1";
            series3.YValuesPerPoint = 2;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.sizeOfEventsPerIntervalChart.Series.Add(series3);
            this.sizeOfEventsPerIntervalChart.Size = new System.Drawing.Size(625, 400);
            this.sizeOfEventsPerIntervalChart.TabIndex = 3;
            this.sizeOfEventsPerIntervalChart.TabStop = false;
            this.sizeOfEventsPerIntervalChart.Text = "chart1";
            title3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title3.Name = "Title1";
            title3.Text = "Event size per interval";
            this.sizeOfEventsPerIntervalChart.Titles.Add(title3);
            // 
            // eventsPerIntervalChart
            // 
            this.eventsPerIntervalChart.BackColor = System.Drawing.SystemColors.Window;
            this.eventsPerIntervalChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea4.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea4.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea4.AxisX.LabelStyle.Interval = 0D;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisX.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.None;
            chartArea4.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea4.AxisX.ScaleBreakStyle.Spacing = 0D;
            chartArea4.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea4.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea4.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.LabelStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisY.MajorGrid.Interval = 0D;
            chartArea4.AxisY.MajorGrid.IntervalOffset = 0D;
            chartArea4.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea4.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea4.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            chartArea4.Name = "ChartArea1";
            this.eventsPerIntervalChart.ChartAreas.Add(chartArea4);
            this.eventsPerIntervalChart.Location = new System.Drawing.Point(49, 83);
            this.eventsPerIntervalChart.Name = "eventsPerIntervalChart";
            series4.BorderColor = System.Drawing.Color.Black;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.DodgerBlue;
            series4.CustomProperties = "DrawSideBySide=False, EmptyPointValue=Zero, PointWidth=1, LabelStyle=Left";
            series4.EmptyPointStyle.AxisLabel = "g";
            series4.EmptyPointStyle.CustomProperties = "DrawingStyle=Wedge";
            series4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series4.MarkerBorderColor = System.Drawing.Color.Transparent;
            series4.MarkerBorderWidth = 2;
            series4.Name = "Series1";
            series4.YValuesPerPoint = 2;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.eventsPerIntervalChart.Series.Add(series4);
            this.eventsPerIntervalChart.Size = new System.Drawing.Size(625, 400);
            this.eventsPerIntervalChart.TabIndex = 4;
            this.eventsPerIntervalChart.TabStop = false;
            this.eventsPerIntervalChart.Text = "chart1";
            title4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title4.Name = "Title1";
            title4.Text = "Event number per interval";
            this.eventsPerIntervalChart.Titles.Add(title4);
            // 
            // restoreButton1
            // 
            this.restoreButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restoreButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreButton1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restoreButton1.Location = new System.Drawing.Point(489, 525);
            this.restoreButton1.Name = "restoreButton1";
            this.restoreButton1.Size = new System.Drawing.Size(162, 33);
            this.restoreButton1.TabIndex = 5;
            this.restoreButton1.Text = "Restore";
            this.restoreButton1.UseVisualStyleBackColor = true;
            this.restoreButton1.Click += new System.EventHandler(this.LeftRestoreButtonClick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(89, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Left border:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(89, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Right border:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // leftBorderTextBox1
            // 
            this.leftBorderTextBox1.BackColor = System.Drawing.Color.White;
            this.leftBorderTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.leftBorderTextBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftBorderTextBox1.Location = new System.Drawing.Point(209, 491);
            this.leftBorderTextBox1.Multiline = true;
            this.leftBorderTextBox1.Name = "leftBorderTextBox1";
            this.leftBorderTextBox1.Size = new System.Drawing.Size(100, 17);
            this.leftBorderTextBox1.TabIndex = 1;
            this.leftBorderTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // rightBorderTextBox1
            // 
            this.rightBorderTextBox1.BackColor = System.Drawing.Color.White;
            this.rightBorderTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rightBorderTextBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightBorderTextBox1.Location = new System.Drawing.Point(215, 534);
            this.rightBorderTextBox1.Multiline = true;
            this.rightBorderTextBox1.Name = "rightBorderTextBox1";
            this.rightBorderTextBox1.Size = new System.Drawing.Size(100, 17);
            this.rightBorderTextBox1.TabIndex = 2;
            this.rightBorderTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(317, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Interval:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // intervalTextBox1
            // 
            this.intervalTextBox1.BackColor = System.Drawing.Color.White;
            this.intervalTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.intervalTextBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intervalTextBox1.Location = new System.Drawing.Point(400, 491);
            this.intervalTextBox1.Multiline = true;
            this.intervalTextBox1.Name = "intervalTextBox1";
            this.intervalTextBox1.Size = new System.Drawing.Size(100, 17);
            this.intervalTextBox1.TabIndex = 3;
            this.intervalTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // updateButton1
            // 
            this.updateButton1.BackColor = System.Drawing.Color.Transparent;
            this.updateButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton1.Location = new System.Drawing.Point(321, 525);
            this.updateButton1.Name = "updateButton1";
            this.updateButton1.Size = new System.Drawing.Size(162, 33);
            this.updateButton1.TabIndex = 4;
            this.updateButton1.Text = "Update";
            this.updateButton1.UseVisualStyleBackColor = false;
            this.updateButton1.Click += new System.EventHandler(this.LeftUpdateButtonClick);
            // 
            // updateButton2
            // 
            this.updateButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton2.Location = new System.Drawing.Point(1042, 525);
            this.updateButton2.Name = "updateButton2";
            this.updateButton2.Size = new System.Drawing.Size(162, 33);
            this.updateButton2.TabIndex = 9;
            this.updateButton2.Text = "Update";
            this.updateButton2.UseVisualStyleBackColor = true;
            this.updateButton2.Click += new System.EventHandler(this.RightUpdateButtonClick);
            // 
            // intervalTextBox2
            // 
            this.intervalTextBox2.BackColor = System.Drawing.Color.White;
            this.intervalTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.intervalTextBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intervalTextBox2.Location = new System.Drawing.Point(1124, 491);
            this.intervalTextBox2.Multiline = true;
            this.intervalTextBox2.Name = "intervalTextBox2";
            this.intervalTextBox2.Size = new System.Drawing.Size(100, 17);
            this.intervalTextBox2.TabIndex = 8;
            this.intervalTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1038, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Interval:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rightBorderTextBox2
            // 
            this.rightBorderTextBox2.BackColor = System.Drawing.Color.White;
            this.rightBorderTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rightBorderTextBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightBorderTextBox2.Location = new System.Drawing.Point(936, 534);
            this.rightBorderTextBox2.Multiline = true;
            this.rightBorderTextBox2.Name = "rightBorderTextBox2";
            this.rightBorderTextBox2.Size = new System.Drawing.Size(100, 17);
            this.rightBorderTextBox2.TabIndex = 7;
            this.rightBorderTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // leftBorderTextBox2
            // 
            this.leftBorderTextBox2.BackColor = System.Drawing.Color.White;
            this.leftBorderTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.leftBorderTextBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftBorderTextBox2.Location = new System.Drawing.Point(925, 491);
            this.leftBorderTextBox2.Multiline = true;
            this.leftBorderTextBox2.Name = "leftBorderTextBox2";
            this.leftBorderTextBox2.Size = new System.Drawing.Size(100, 17);
            this.leftBorderTextBox2.TabIndex = 6;
            this.leftBorderTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(810, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 33);
            this.label5.TabIndex = 15;
            this.label5.Text = "Right border:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(810, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 33);
            this.label6.TabIndex = 14;
            this.label6.Text = "Left border:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // restoreButton2
            // 
            this.restoreButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restoreButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreButton2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restoreButton2.Location = new System.Drawing.Point(1210, 525);
            this.restoreButton2.Name = "restoreButton2";
            this.restoreButton2.Size = new System.Drawing.Size(162, 33);
            this.restoreButton2.TabIndex = 10;
            this.restoreButton2.Text = "Restore";
            this.restoreButton2.UseVisualStyleBackColor = true;
            this.restoreButton2.Click += new System.EventHandler(this.RightRestoreButtonClick);
            // 
            // Model
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1425, 639);
            this.Controls.Add(this.restoreButton2);
            this.Controls.Add(this.updateButton2);
            this.Controls.Add(this.intervalTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rightBorderTextBox2);
            this.Controls.Add(this.leftBorderTextBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.updateButton1);
            this.Controls.Add(this.intervalTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rightBorderTextBox1);
            this.Controls.Add(this.leftBorderTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.restoreButton1);
            this.Controls.Add(this.eventsPerIntervalChart);
            this.Controls.Add(this.sizeOfEventsPerIntervalChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Model";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ModelLoad);
            ((System.ComponentModel.ISupportInitialize)(this.sizeOfEventsPerIntervalChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsPerIntervalChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart eventsPerIntervalChart;
        private System.Windows.Forms.Button restoreButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox leftBorderTextBox1;
        private System.Windows.Forms.TextBox rightBorderTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox intervalTextBox1;
        private System.Windows.Forms.Button updateButton1;
        private System.Windows.Forms.DataVisualization.Charting.Chart sizeOfEventsPerIntervalChart;
        private System.Windows.Forms.Button updateButton2;
        private System.Windows.Forms.TextBox intervalTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rightBorderTextBox2;
        private System.Windows.Forms.TextBox leftBorderTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button restoreButton2;
    }
}

