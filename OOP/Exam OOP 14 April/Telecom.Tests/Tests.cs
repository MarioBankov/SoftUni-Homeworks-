namespace Telecom.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class Tests
    {
        Phone p;
        [SetUp]
        public void Init()
        {
            p = new Phone("nokia", "1000");
        }
        [Test]
        public void ConstructorInisializeDrictionary()
        {
            int expectedCount = 0;

            Assert.AreEqual(expectedCount, p.Count);
        }
        [Test]
        public void MakeSetsCorrectry()
        {
            string expectedMake = "nokia";
            Assert.AreEqual(expectedMake, p.Make);

        }
        [Test]
        public void NullOrEmptyMakeThrows()
        {
            Assert.Throws<ArgumentException>(() => new Phone("","123"));
        }
        [Test]
        public void ModelSetsCorrecty()
        {
            string expectedModel = "1000";
            Assert.AreEqual(expectedModel, p.Model);
        }
        [Test]
        public void NullOrEmplyModelThrows()
        {
            Assert.Throws<ArgumentException>(() => new Phone("12", ""));
        }
        [Test]
        public void CountWorksCorrectly()
        {
            p.AddContact("Pepi","088854545");
            int expectedCount = 1;
            Assert.AreEqual(expectedCount, p.Count);
        }
        [Test]
        public void AddSameContactThrows()
        {
            p.AddContact("Pepi", "088854545");
            Assert.Throws<InvalidOperationException>(() => p.AddContact("Pepi", "088854545"));
        }
        [Test]
        public void AddWorksCorrectly()
        {
            p.AddContact("Pepi", "088854545");
            p.AddContact("Pepo", "0884545454512");
            int expectedCount = 2;
            Assert.AreEqual(expectedCount, p.Count);
        }
        [Test]
        public void CallUnexsistingContactThrows()
        {
            Assert.Throws<InvalidOperationException>(() => p.Call("asd"));
        }
        [Test]
        public void CallWorksCorrectly()
        {
            p.AddContact("Pepi", "088854545");
            string expectedResult= $"Calling Pepi - 088854545...";
            Assert.AreEqual(expectedResult, p.Call("Pepi"));
        }
    }
}