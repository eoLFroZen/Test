using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    public class DummyTests
    {
        [Test]
        public void DummyLosesHealthWhenBeenAttacked()
        {
            int health = 10;
            int attackPoints = 5;
            Dummy dummy = new Dummy(10, health);

            dummy.TakeAttack(attackPoints);

            Assert.AreEqual(health - attackPoints, dummy.Health);
        }

        [Test]
        public void DeadDummyThrowsExceptionWhenBeenAttacked()
        {
            Dummy dummy = new Dummy(0, 10);

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(1));
            Assert.AreEqual("Dummy is dead.", ex.Message);
        }

        [Test]
        public void DeadDummyGivesExperience()
        {
            Dummy dummy = new Dummy(0, 10);

            int experience = dummy.GiveExperience();

            Assert.AreEqual(10, experience);
        }

        [Test]
        public void AliveDummyDoesNotGiveExperienceAndThrowsException()
        {
            Dummy dummy = new Dummy(2, 10);

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
            Assert.AreEqual("Target is not dead.", ex.Message);
        }
    }
}
