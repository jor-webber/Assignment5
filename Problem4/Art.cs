using System;
using System.Collections.Generic;
using System.Text;

namespace Problem4
{
    public class Art
    {
        /// <summary>
        /// Name of the art piece 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Name of the artist 
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        /// Starting price/Current highest bid
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Year art was created 
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// current number of bids it has 
        /// </summary>
        public int NumberOfBids { get; set; }

        /// <summary>
        /// Current highest bidder
        /// </summary>
        public IObserver<Art> HighestBidder { get; set; }

        /// <summary>
        /// Create a new art piece for auction
        /// </summary>
        /// <param name="name">Name of art piece</param>
        /// <param name="artist">Name of artist</param>
        /// <param name="price">current price</param>
        /// <param name="year">year it was made</param>
        public Art(string name, string artist, int price, int year)
        {
            Name = name;
            Artist = artist;
            Price = price;
            Year = year;
            NumberOfBids = 0;
            HighestBidder = null;
        }

        /// <summary>
        /// Place a bid on a art piece 
        /// </summary>
        /// <param name="price">new bid price</param>
        /// <param name="bidder">name of the bidder</param>
        /// <returns>if bid was accepted or rejected</returns>
        /// <exception cref="ArgumentException"></exception>
        public bool PlaceBid(int price, IObserver<Art> bidder)
        {
            if (price <= Price)
            {
                throw new ArgumentException("Bid must be greater than the current price");
            }

            if (NumberOfBids == 5 || HighestBidder == bidder)
            {
                return false;
            }

            Price = price;
            HighestBidder = bidder;
            NumberOfBids += 1;

            return true;
        }
    }
}
