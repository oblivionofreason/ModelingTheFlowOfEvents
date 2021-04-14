using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ModelingTheFlowOfEvents
{
    public partial class Model : Form
    {
        private readonly Dictionary<double, int> events = new Dictionary<double, int>(); // коллекция событий (время : объем)
        private readonly List<int> eventsPerInterval = new List<int>(); // коллекция, содержащая количество событий за указанный интервал
        private readonly List<int> sizeOfEventsPerInterval = new List<int>(); // коллекция, содержащая количество событий за указанный интервал
        private readonly double totalTime;
        private double leftChartInterval;
        private double rightChartInterval;
        public Model(double totalTime, Dictionary<double, int> events)
        {
            InitializeComponent();
            this.totalTime = totalTime;
            this.events = events;
            leftChartInterval = 1;
            rightChartInterval = 1;
        }
        private void ModelLoad(object sender, EventArgs e)
        {
            BuildEventsPerIntervalCollection();
            BuildSizeOfEventsPerIntervalCollection();
            eventsPerIntervalChart.ChartAreas[0].AxisX.Minimum = 0;
            eventsPerIntervalChart.ChartAreas[0].AxisX.Maximum = totalTime;
            sizeOfEventsPerIntervalChart.ChartAreas[0].AxisX.Minimum = 0;
            sizeOfEventsPerIntervalChart.ChartAreas[0].AxisX.Maximum = totalTime;
            for (int i = 0; i < eventsPerInterval.Count; ++i)
                eventsPerIntervalChart.Series[0].Points.AddXY(i * 1 - 1 / 2, eventsPerInterval[i]);
            for (int i = 0; i < sizeOfEventsPerInterval.Count; ++i)
                sizeOfEventsPerIntervalChart.Series[0].Points.AddXY(i * 1 - 1 / 2, sizeOfEventsPerInterval[i]);
        }
        private void BuildEventsPerIntervalCollection()
        {
            eventsPerIntervalChart.Series[0].Points.Clear();
            eventsPerInterval.Clear();
            eventsPerInterval.Insert(0, 0);
            double currentTime = default;
            int eventCounter = default;
            foreach (var item in events.Keys)
            {
                while (!(item >= currentTime && item <= currentTime + leftChartInterval))
                {
                    eventsPerInterval.Add(eventCounter);
                    eventCounter = 0;
                    currentTime += leftChartInterval;
                }
                eventCounter++;
            }
        }
        private void BuildSizeOfEventsPerIntervalCollection()
        {
            sizeOfEventsPerIntervalChart.Series[0].Points.Clear();
            sizeOfEventsPerInterval.Clear();
            sizeOfEventsPerInterval.Insert(0, 0);
            double currentTime = default;
            int sizeCounter = default;
            foreach (KeyValuePair<double, int> kvp in events)
            {
                while (!(kvp.Key >= currentTime && kvp.Key <= currentTime + rightChartInterval))
                {
                    sizeOfEventsPerInterval.Add(sizeCounter);
                    sizeCounter = 0;
                    currentTime += rightChartInterval;
                }
                sizeCounter += kvp.Value;
            }
        }
        private void LeftUpdateButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(intervalTextBox1.Text) || Convert.ToDouble(intervalTextBox1.Text) == 0 || Convert.ToDouble(intervalTextBox1.Text) > totalTime)
                leftChartInterval = 1;
            else
                leftChartInterval = Convert.ToDouble(intervalTextBox1.Text);
            BuildEventsPerIntervalCollection();
            double leftBorder;
            double rightBorder;
            if (string.IsNullOrEmpty(leftBorderTextBox1.Text))
                leftBorder = 0;
            else
                leftBorder = Convert.ToDouble(leftBorderTextBox1.Text);
            if (string.IsNullOrEmpty(rightBorderTextBox1.Text) || Convert.ToDouble(rightBorderTextBox1.Text) > totalTime)
                rightBorder = totalTime;
            else
                rightBorder = Convert.ToDouble(rightBorderTextBox1.Text);
            eventsPerIntervalChart.ChartAreas[0].AxisX.Minimum = leftBorder;
            eventsPerIntervalChart.ChartAreas[0].AxisX.Maximum = rightBorder;
            for (int i = 0; i < eventsPerInterval.Count; ++i)
                eventsPerIntervalChart.Series[0].Points.AddXY((i * leftChartInterval) - leftChartInterval / 2, eventsPerInterval[i]);
        }
        private void RightUpdateButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(intervalTextBox2.Text) || Convert.ToDouble(intervalTextBox2.Text) == 0 || Convert.ToDouble(intervalTextBox2.Text) > totalTime)
                rightChartInterval = 1;
            else
                rightChartInterval = Convert.ToDouble(intervalTextBox2.Text);
            BuildSizeOfEventsPerIntervalCollection();
            double leftBorder;
            double rightBorder;
            if (string.IsNullOrEmpty(leftBorderTextBox2.Text))
                leftBorder = 0;
            else
                leftBorder = Convert.ToDouble(leftBorderTextBox2.Text);
            if (string.IsNullOrEmpty(rightBorderTextBox2.Text) || Convert.ToDouble(rightBorderTextBox2.Text) > totalTime)
                rightBorder = totalTime;
            else
                rightBorder = Convert.ToDouble(rightBorderTextBox2.Text);
            sizeOfEventsPerIntervalChart.ChartAreas[0].AxisX.Minimum = leftBorder;
            sizeOfEventsPerIntervalChart.ChartAreas[0].AxisX.Maximum = rightBorder;
            for (int i = 0; i < sizeOfEventsPerInterval.Count; ++i)
                sizeOfEventsPerIntervalChart.Series[0].Points.AddXY((i * rightChartInterval) - rightChartInterval / 2, sizeOfEventsPerInterval[i]);
        }
        private void LeftRestoreButtonClick(object sender, EventArgs e)
        {
            eventsPerIntervalChart.Series[0].Points.Clear();
            leftChartInterval = 1;
            BuildEventsPerIntervalCollection();
            eventsPerIntervalChart.ChartAreas[0].AxisX.Minimum = 0;
            eventsPerIntervalChart.ChartAreas[0].AxisX.Maximum = totalTime;
            for (int i = 0; i < eventsPerInterval.Count; ++i)
                eventsPerIntervalChart.Series[0].Points.AddXY(i * leftChartInterval - leftChartInterval / 2, eventsPerInterval[i]);
        }
        private void RightRestoreButtonClick(object sender, EventArgs e)
        {
            sizeOfEventsPerIntervalChart.Series[0].Points.Clear();
            rightChartInterval = 1;
            BuildSizeOfEventsPerIntervalCollection();
            sizeOfEventsPerIntervalChart.ChartAreas[0].AxisX.Minimum = 0;
            sizeOfEventsPerIntervalChart.ChartAreas[0].AxisX.Maximum = totalTime;
            for (int i = 0; i < sizeOfEventsPerInterval.Count; ++i)
                sizeOfEventsPerIntervalChart.Series[0].Points.AddXY(i * rightChartInterval - rightChartInterval / 2, sizeOfEventsPerInterval[i]);
        }
        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            if (e.KeyChar == ',')
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    updateButton1.Focus();
                return;
            }
            e.Handled = true;
        }
    }
}
