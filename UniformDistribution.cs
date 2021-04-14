using System;

namespace ModelingTheFlowOfEvents
{
    class UniformDistribution : DiscreteDistribution
    {
        public int Lhs { get; set; }
        public int Rhs { get; set; }
        public UniformDistribution(int lhs, int rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }
        public override int NextValue() => baseGenerator.Next(Lhs, Rhs + 1);
    }
}
