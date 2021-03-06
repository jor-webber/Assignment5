/*
 * The group members, Harmanpreet Dhillon, 000816379, Jordan Webber, 000803303, Ramandeep Ghotra, 000818354, 
 * certify that this material is our original work. No other person's work has been used without due acknowledgement. 
 * We have not made my work available to anyone else.
 */

using System;
using System.Collections.Generic;

namespace Problem4
{
    /// <summary>
    /// Creates the auctioneer
    /// </summary>
    public class Auctioneer : IObservable<Art>
    {
        /// <summary>
        /// Maintain a list of buyers
        /// </summary>
        private List<IObserver<Art>> buyers;

        /// <summary>
        /// Maintain a list of art 
        /// </summary>
        private List<Art> artList;

        /// <summary>
        /// Constructor
        /// </summary>
        public Auctioneer()
        {
            this.buyers = new List<IObserver<Art>>();
            this.artList = new List<Art>();
        }

        /// <summary>
        /// Adds buyer to auction
        /// </summary>
        /// <param name="buyer"></param>
        /// <returns></returns>
        public IDisposable Subscribe(IObserver<Art> buyer)
        {
            if (!this.buyers.Contains(buyer))
            {
                this.buyers.Add(buyer);

                foreach (var art in this.artList)
                {

                    if (art.NumberOfBids == 5)
                    {
                        artList.Remove(art);
                        buyer.OnCompleted();

                    }

                    buyer.OnNext(art);
                }
            }


            return new Unsubscriber<Art>(buyers, buyer);
        }

    }
}
