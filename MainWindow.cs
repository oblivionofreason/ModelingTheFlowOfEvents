using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ModelingTheFlowOfEvents
{
    public partial class MainWindow : Form
    {
        private readonly Flow flow = new Flow();
        private Dictionary<double, int> events = new Dictionary<double, int>();
        private ContinuousDistribution continuousDistribution;
        private DiscreteDistribution discreteDistribution;
        public MainWindow() => InitializeComponent();
        private void BuildButtonClick(object sender, EventArgs e)
        {
            double totalTime = Convert.ToDouble(totalTimeTextBox.Text);
            switch (continuousDistributionBox.SelectedIndex)
            {
                case 0:
                    ExponentialDistribution exponentialDistribution = new ExponentialDistribution(Convert.ToDouble(lambdaTextBox.Text));
                    continuousDistribution = exponentialDistribution;
                    break;
            }
            switch (discreteDistributionBox.SelectedIndex)
            {
                case 0:
                    UniformDistribution uniformDistribution = new UniformDistribution(Convert.ToInt32(leftBoundaryValueTextBox.Text), Convert.ToInt32(rightBoundaryValueTextBox.Text));
                    discreteDistribution = uniformDistribution;
                    break;
                case 1:
                    GeometricDistribution geometricDistribution = new GeometricDistribution(Convert.ToDouble(eventProbabilityTextBox.Text));
                    discreteDistribution = geometricDistribution;
                    break;
            }
            events = flow.GenerateEvents(continuousDistribution, discreteDistribution, totalTime);
            Model model = new Model(totalTime, events);
            model.Show();
        }
        private void ContinuousDistributionBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (continuousDistributionBox.SelectedIndex == 0)
                exponentialDistributionPanel.Visible = true;
        }
        private void DiscreteDistributionBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (discreteDistributionBox.SelectedIndex == 0)
            {
                uniformDistributionPanel.Visible = true;
                geometricDistributionPanel.Visible = false;
                leftBoundaryValueTextBox.Clear();
                rightBoundaryValueTextBox.Clear();
            }
            else if (discreteDistributionBox.SelectedIndex == 1)
            {
                geometricDistributionPanel.Visible = true;
                uniformDistributionPanel.Visible = false;
                eventProbabilityTextBox.Clear();
            }
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
                    buildButton.Focus();
                return;
            }
            e.Handled = true;
        }
    }
}
