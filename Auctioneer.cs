using System;
using System.Collections.Generic;

namespace Module
{
    public class Auctioneer : IAuctionSubject
    {
        private List<IAuctionObserver> observers = new List<IAuctionObserver>();
        private int currentBid = 0;

        public void AttachObserver(IAuctionObserver observer)
        {
            observers.Add(observer);
        }

        public void DetachObserver(IAuctionObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.UpdateBid(currentBid);
            }
        }

        public void StartAuction()
        {
            Console.WriteLine("Auctioneer starts the auction!");

            Random rnd = new Random();
            while (true)
            {
                int newBid = rnd.Next(currentBid + 1, currentBid + 100);
                Console.WriteLine($"Current bid: {currentBid}. Next bid: {newBid}");

                currentBid = newBid;
                NotifyObservers();

                Console.WriteLine("Waiting for bids...");
                Console.ReadKey();
            }
        }
    }
}
