using System.Collections.Generic;

namespace ModelingTheFlowOfEvents
{
    class Flow
    {
        private readonly Dictionary<double, int> events = new Dictionary<double, int>();
        public Dictionary<double, int> GenerateEvents(ContinuousDistribution intervalOfDistribution, DiscreteDistribution sizeOfDistribution, double totalTime)
        {
            events.Clear();
            double currentTime = default;
            while (currentTime <= totalTime)
            {
                currentTime += intervalOfDistribution.NextValue();
                events.Add(currentTime, sizeOfDistribution.NextValue());
            }
            return events;
        }
    }
}
