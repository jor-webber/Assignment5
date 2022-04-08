using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// Represents a graphics card
    /// </summary>
    public class GraphicsCard
    {
        private int _fanCount;
        private double _speed;
        private double _videoMemory;
        private int _numberOfCudaCores;

        /// <summary>
        /// Get and sets the fan count
        /// </summary>
        public int FanCount
        {
            get => _fanCount;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(FanCount),"Fan count cannot be less than 0");
                }
                _fanCount = value;
            }
        }

        /// <summary>
        /// Gets and sets the speed
        /// </summary>
        public double Speed
        {
            get => _speed;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Speed), "Speed cannot be 0 or less");
                }
                _speed = value;
            }
        }

        /// <summary>
        /// Gets and sets the video memory
        /// </summary>
        public double VideoMemory
        { 
            get => _videoMemory;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(VideoMemory), "Video memory cannot be 0 or less");
                }
                _videoMemory = value;
            }
        }

        /// <summary>
        /// Gets and sets the number of cuda cores
        /// </summary>
        public int NumberOfCudaCores
        {
            get => _numberOfCudaCores;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(NumberOfCudaCores), "The number of cuda cores cannot be less than 0");
                }
                _numberOfCudaCores = value;
            }
        }
    }
}
