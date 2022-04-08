/*
 * The group members, Harmanpreet Dhillon, 000816379, Jordan Webber, 000803303, Ramandeep Ghotra, 000818354, 
 * certify that this material is our original work. No other person's work has been used without due acknowledgement. 
 * We have not made my work available to anyone else.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Problem4
{
    public class Unsubscriber<T> : IDisposable
    {
        private List<IObserver<T>> observers;
        private IObserver<T> observer;

        /// <summary>
        /// Create a new instance of a unsubscriber
        /// </summary>
        /// <param name="observers"></param>
        /// <param name="observer"></param>
        internal Unsubscriber(List<IObserver<T>> observers, IObserver<T> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }

        /// <summary>
        /// Removes an observer 
        /// </summary>
        public void Dispose()
        {
            if(this.observers.Contains(this.observer))
            {
                this.observers.Remove(this.observer);
            }
        }
    }
}
