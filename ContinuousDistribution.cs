using System;

namespace ModelingTheFlowOfEvents
{
    abstract class ContinuousDistribution
    {
        protected readonly Random baseGenerator = new Random();
        public abstract double NextValue();
    }
}
