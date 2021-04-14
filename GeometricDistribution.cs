using System;
using System.Threading;

namespace ModelingTheFlowOfEvents
{
    class GeometricDistribution : DiscreteDistribution
    {
        public double EventProbability { get; set; }
        public GeometricDistribution(double eventProbability)
        {
            EventProbability = eventProbability;
            Thread.Sleep(100);
        }
        public override int NextValue() => (int)(Math.Log(baseGenerator.NextDouble()) / Math.Log(1 - EventProbability));
    }
}
