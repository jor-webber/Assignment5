using System;
using System.Collections.Generic;
using System.Text;
/*
 * The group members, Harmanpreet Dhillon, 000816379, Jordan Webber, 000803303, Ramandeep Ghotra, 000818354, 
 * certify that this material is our original work. No other person's work has been used without due acknowledgement. 
 * We have not made my work available to anyone else.
 */
namespace Problem3
{
    /// <summary>
    /// Handler abstract class
    /// </summary>
    public abstract class IHandler
    {
        /// <summary>
        /// Successor
        /// </summary>
        protected IHandler successor;

        /// <summary>
        /// Sets the successor if one is available
        /// </summary>
        /// <param name="successor">Successor name</param>
        public void SetSuccessor(IHandler successor)
        {
            this.successor = successor;
        }

        /// <summary>
        /// Abstract method 
        /// </summary>
        /// <param name="mail">Mail object</param>
        public abstract void HandleRequest(Mail mail);
    }

    /// <summary>
    /// Mail class for mail object.
    /// </summary>
    public class Mail
    {
        /// <summary>
        /// Sender Name
        /// </summary>
        public string SenderName { get; set; }
        /// <summary>
        /// Sender Address
        /// </summary>
        public string SenderAddress { get; set; }
        /// <summary>
        /// Receiver Name
        /// </summary>
        public string ReceiverName { get; set; }
        /// <summary>
        /// Receiver Address
        /// </summary>
        public string ReceiverAddress { get; set; }
        /// <summary>
        /// Flagged or unflagged mail
        /// </summary>
        public MailType Type { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="senderName">Sender name</param>
        /// <param name="senderAddress">Sender address</param>
        /// <param name="receiverName">Receiver name</param>
        /// <param name="receiverAddress">Receiver address</param>
        public Mail(string senderName, string senderAddress, string receiverName, string receiverAddress)
        {
            SenderName = senderName;
            SenderAddress = senderAddress;
            ReceiverName = receiverName;
            ReceiverAddress = receiverAddress;
        }

        /// <summary>
        /// Type of mail
        /// </summary>
        public enum MailType
        {
            Flagged,
            NotFlagged
        }

        /// <summary>
        /// Class to handle mail requests that are flagged
        /// </summary>
        public class FlaggedMail : IHandler
        {
            /// <summary>
            /// Review Queue
            /// </summary>
            Queue<Mail> reviewQueue = new Queue<Mail> ();
            /// <summary>
            /// Handle request by adding all flagged mail to review queue
            /// </summary>
            /// <param name="mail"></param>
            public override void HandleRequest(Mail mail)
            {
                if (mail.Type == MailType.Flagged)
                {
                    reviewQueue.Enqueue (mail);
                } else if (successor != null)
                {
                    successor.HandleRequest(mail);
                }
            }
        }

        /// <summary>
        /// Handle request by delivering mail
        /// </summary>
        public class NotFlaggedMail : IHandler
        {
            public override void HandleRequest(Mail mail)
            {
                if (mail.Type == MailType.NotFlagged)
                {
                    Console.WriteLine ("Mail delivered to: {0} at address: {1}", mail.ReceiverName, mail.ReceiverAddress);   
                }
            }
        }

    }



}
