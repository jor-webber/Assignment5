using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem2;

namespace UnitTests
{
    /// <summary>
    /// Holds the test methods for Assignment 5
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Tests the creation of a <see cref="Case"/> class.
        /// </summary>
        [TestMethod]
        public void TestCreateCase()
        {
            var computerCase = new Case
            {
                Length = 20.2,
                Width = 15.5,
                Height = 18.1,
                NumberOfFans = 3,
                NumberOfVents = 3
            };

            Assert.AreEqual(20.2, computerCase.Length);
            Assert.AreEqual(3, computerCase.NumberOfFans);
            Assert.AreEqual(15.5, computerCase.Width);
        }

        /// <summary>
        /// Tests the creation of a <see cref="Cpu"/> class.
        /// </summary>
        [TestMethod]
        public void TestCreateCpu()
        {
            var cpu = new Cpu
            {
                Speed = 4.5,
                Manufacturer = "AMD",
                SocketType = "Yes",
                CacheSize = 100,
                NumberOfCores = 5
            };

            Assert.AreEqual(4.5, cpu.Speed);
            Assert.AreEqual("AMD", cpu.Manufacturer);
            Assert.AreEqual(100, cpu.CacheSize);
        }

        /// <summary>
        /// Tests the creation of a <see cref="Memory"/> class.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCreateMemory()
        {
            var memory = new Memory
            {
                ReadSpeed = 3200,
                WriteSpeed = 3200,
                Type = "DDRR",
                AmountInGb = 16
            };
        }

        /// <summary>
        /// Tests the creation of a <see cref="Motherboard"/> class.
        /// </summary>
        [TestMethod]
        public void TestCreateMotherboard()
        {
            var cpu = new Cpu();
            var memory = new Memory();
            var graphicsCard = new GraphicsCard();
            var motherboard = new Motherboard
            {
                NumberOfMemorySlots = 4,
                PowerConsumption = 300,
                NumberOfPciPorts = 2,
                FormFactor = "Big",
                HardDriveLimit = 3,
                Cpu = cpu,
                Memory = memory,
                GraphicsCard = graphicsCard
            };

            Assert.IsNotNull(motherboard.GraphicsCard);
            Assert.IsNotNull(motherboard.Cpu);
            Assert.IsNotNull(motherboard.Memory);
        }
    }
}
