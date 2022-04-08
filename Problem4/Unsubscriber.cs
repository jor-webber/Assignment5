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
