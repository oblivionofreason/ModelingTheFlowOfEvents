using System;
using System.Threading;

namespace ModelingTheFlowOfEvents
{
    class ExponentialDistribution : ContinuousDistribution
    {
        public double Lambda { get; set; }
        public ExponentialDistribution(double lambda)
        {
            Lambda = lambda;
            Thread.Sleep(100);
        }
        public override double NextValue() => -(Math.Log(baseGenerator.NextDouble()) / Lambda);
    }
}
