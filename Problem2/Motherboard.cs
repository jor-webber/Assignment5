using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// Represents a motherboard
    /// </summary>
    public class Motherboard
    {
        /// <summary>
        /// Gets and sets the number of memory slots
        /// </summary>
        public int NumberOfMemorySlots { get; set; }
        /// <summary>
        /// Gets and sets the power consumption
        /// </summary>
        public double PowerConsumption { get; set; }

        /// <summary>
        /// Gets and sets the number of PCI ports
        /// </summary>
        public int NumberOfPciPorts { get; set; }

        /// <summary>
        /// Gets and sets the form factor
        /// </summary>
        public string FormFactor { get; set; }

        /// <summary>
        /// Gets and sets the hard drive limit
        /// </summary>
        public int HardDriveLimit { get; set; }

        /// <summary>
        /// Gets and sets the CPU
        /// </summary>
        public Cpu Cpu { get; set; }

        /// <summary>
        /// Gets and sets the memory
        /// </summary>
        public Memory Memory { get; set; }

        /// <summary>
        /// Gets and sets the graphics card
        /// </summary>
        public GraphicsCard GraphicsCard { get; set; }

    }
}
