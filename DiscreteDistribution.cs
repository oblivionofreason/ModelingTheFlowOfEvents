using System;

namespace ModelingTheFlowOfEvents
{
    abstract class DiscreteDistribution
    {
        protected readonly Random baseGenerator = new Random();
        public abstract int NextValue();
    }
}
