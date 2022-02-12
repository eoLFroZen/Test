using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    public class AxeTests
    {
        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            int durabilityPoints = 10;
            Axe axe = new Axe(10, durabilityPoints);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.AreEqual(durabilityPoints - 1, axe.DurabilityPoints);
        }

        [Test]
        public void BrokenAxeThrowsExceptionWhenAttack()
        {
            int durabilityPoints = 0;
            Axe axe = new Axe(10, durabilityPoints);
            Dummy dummy = new Dummy(10, 10);

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.AreEqual("Axe is broken.", ex.Message);
        }
    }
}