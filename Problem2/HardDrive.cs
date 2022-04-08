/*
 * The group members, Harmanpreet Dhillon, 000816379, Jordan Webber, 000803303, Ramandeep Ghotra, 000818354, 
 * certify that this material is our original work. No other person's work has been used without due acknowledgement. 
 * We have not made my work available to anyone else.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Configuration;

namespace Problem2
{
    /// <summary>
    /// Represents a hard drive
    /// </summary>
    public class HardDrive
    {
        private string _type;
        private double _readSpeed;
        private double _writeSpeed;

        /// <summary>
        /// Gets and sets the capacity
        /// </summary>
        public double Capacity { get; set; }

        /// <summary>
        /// Gets and sets the type
        /// </summary>
        [MaxLength(3)]
        public string Type { 

            get => _type;
            set
            {
                if (!value.Equals("SSD") || !value.Equals("HDD"))
                {
                    throw new ArgumentException("Type must be either SSD or HDD");
                }

                _type = value;
            }
        }

        /// <summary>
        /// Gets and sets the read speed
        /// </summary>
        public double ReadSpeed
        {
            get => _readSpeed;
            set
            {
                if(value < 1)
                {
                    throw new ArgumentOutOfRangeException($"Read speed cannot be less than 1");
                }

                _readSpeed = value;
            }
        }

        /// <summary>
        /// Gets and sets write speed
        /// </summary>
        public double WriteSpeed
        {
            get => _writeSpeed;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException($"Write speed cannot be less than 1");
                }
                _writeSpeed = value;
            }
        }
    }
}
