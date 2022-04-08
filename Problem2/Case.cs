/*
 * The group members, Harmanpreet Dhillon, 000816379, Jordan Webber, 000803303, Ramandeep Ghotra, 000818354, 
 * certify that this material is our original work. No other person's work has been used without due acknowledgement. 
 * We have not made my work available to anyone else.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// Represents a case
    /// </summary>
    public class Case
    {
        private double _length;
        private double _width;
        private double _height;

        /// <summary>
        /// Gets and sets the length
        /// </summary>
        public double Length
        {
            get => _length;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Length), "Length of the case cannot be 0 or less");
                }
            }
        }

        /// <summary>
        /// Gets and sets the width
        /// </summary>
        public double Width
        {
            get => _width;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Width), "Width of the case cannot be 0 or less");
                }
                _width = value;
            }
        }

        /// <summary>
        /// Gets and sets the height
        /// </summary>
        public double Height
        {
            get => _height;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Height), "Height of the case cannot be 0 or less");
                }
                _height = value;
            }
        }

        /// <summary>
        /// Gets and sets the number of fans
        /// </summary>
        public int NumberOfFans { get; set; }

        /// <summary>
        /// Gets and sets the number of vents
        /// </summary>
        public int NumberOfVents { get; set; }
    }
}
