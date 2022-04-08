using System;
using System.ComponentModel.DataAnnotations;

namespace Problem2
{
    /// <summary>
    /// Represents memory
    /// </summary>
    public class Memory
    {
        private double _readSpeed;
        private double _writeSpeed;
        private string _type;

        /// <summary>
        /// Gets and sets the read speed
        /// </summary>
        public double ReadSpeed
        {
            get => _readSpeed;
            set
            {
                if (value < 1)
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

        /// <summary>
        /// Gets and sets the type
        /// </summary>
        [MaxLength(4)]
        public string Type
        {
            get => _type;
            set
            {
                if (!value.ToUpper().Equals("DDR1") && !value.ToUpper().Equals("DDR2") &&
                    !value.ToUpper().Equals("DDR3") && !value.ToUpper().Equals("DDR4"))
                {
                    throw new ArgumentOutOfRangeException(nameof(Type), "Memory type must be DDR1, DDR2, DDR3, or DDR4");
                }
                _type = value;
            }
        }

        /// <summary>
        /// Gets and sets the amount in GB
        /// </summary>
        public double AmountInGb { get; set; }
    }
}
