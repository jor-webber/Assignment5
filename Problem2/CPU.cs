using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// Represents a cpu
    /// </summary>
    public class Cpu
    {
        private double _speed;
        private string _manufacturer;
        private int _numberOfCores;

        /// <summary>
        /// Gets and sets the speed
        /// </summary>
        public double Speed { 
            get => _speed;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Speed cannot be 0 or lower");
                }
                _speed = value;
            }
        }

        /// <summary>
        /// Gets and sets the manufacturer
        /// </summary>
        public string Manufacturer { 
            get => _manufacturer;
            set
            {
                if (!value.ToUpper().Equals("INTEL") || !value.ToUpper().Equals("AMD"))
                {
                    throw new ArgumentException("Manufacturer must be either Intel and AMD");
                }
                _manufacturer = value.ToUpper();
            }
        }

        /// <summary>
        /// Gets and sets the socket type
        /// </summary>
        public string SocketType { get; set; }

        /// <summary>
        /// Gets and sets the cache size
        /// </summary>
        public double CacheSize { get; set; }

        /// <summary>
        /// Gets and sets the number of cores
        /// </summary>
        public int NumberOfCores { 
            get => _numberOfCores;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Number of cores cannot be less than 1");
                }
                _numberOfCores = value;
            }
        }
    }
}
