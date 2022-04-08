using System;
using System.Collections.Generic;

namespace Problem4
{
    class Auctioneer : IObservable<Art>
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
                    buyer.OnNext(art);
                }
            }


            return new Unsubscriber<Art>(buyers, buyer);
        }


        //public bool ShowArtToBuyer(Art art, IObserver<Art> buyer)
        //{
        //    int numBids = art.NumberOfBids;
        //    buyer.OnNext(art);
        //    if (numBids != art.NumberOfBids)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}

        //public void NotifyAllBuyers(Art art)
        //{
        //    if (!artList.Contains(art))
        //    {
        //        artList.Add(art);
        //    }

        //    foreach (var artPiece in this.artList)
        //    {

        //        int numBids = art.NumberOfBids;


        //        if (art.NumberOfBids == 5)
        //        {
        //            artList.Remove(art);
        //            buyer.OnCompleted();
        //            buyers.Remove(buyer);
        //        }

        //    }
        //}


    }
}
