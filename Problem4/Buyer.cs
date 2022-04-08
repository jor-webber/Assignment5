using System;
using System.Collections.Generic;
using System.Text;

namespace Problem4
{
    public class Buyer : IObserver<Art>
    {
        /// <summary>
        /// Name of buyer
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Buyer's budget
        /// </summary>
        public int Budget { get; set; }

        /// <summary>
        /// Buyer's most recent bid 
        /// </summary>
        public Art MostRecentBid { get; set; }

        /// <summary>
        /// Art purchased by Buyer
        /// </summary>
        public Art ArtPurchased { get; set; }

        /// <summary>
        /// List of art pieces 
        /// </summary>
        private List<Art> ArtPieces { get; set; } = new List<Art>();

        private IDisposable AuctionAttendee;

        /// <summary>
        /// Creates a new buyer 
        /// </summary>
        /// <param name="name">Name of buyer</param>
        /// <param name="budget">Buyer's budget</param>
        public Buyer(string name, int budget)
        {
            Name = name;
            Budget = budget;
            MostRecentBid = null;
            ArtPurchased = null;
        }

        /// <summary>
        /// register new buyer 
        /// </summary>
        /// <param name="auctioneer"></param>
        public void AttendAuction(Auctioneer auctioneer)
        {
            this.AuctionAttendee = auctioneer.Subscribe(this);
        }

        /// <summary>
        /// unregister the buyer
        /// </summary>
        public void LeaveAuction()
        {
            this.AuctionAttendee.Dispose();
            this.ArtPieces.Clear();
        }

        /// <summary>
        /// Notify buyers that auctioneer will not be sending anymore notifications
        /// </summary>
        public void OnCompleted()
        {
            this.ArtPieces.Clear();
        }

        /// <summary>
        /// Notify buyers that the auctioneer has experienced an error  
        /// </summary>
        /// <param name="error"></param>
        public void OnError(Exception error)
        {
            Console.WriteLine(error.ToString()); 
        }

        /// <summary>
        /// Provides buyer with new data 
        /// </summary>
        /// <param name="value"></param>
        public void OnNext(Art value)
        {
            Console.WriteLine(value.ToString());
        }
    }
}
