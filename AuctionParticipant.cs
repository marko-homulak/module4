using System;

namespace Module
{
    public class AuctionParticipant : IAuctionObserver
    {
        private string name;

        public AuctionParticipant(string name)
        {
            this.name = name;
        }

        public void UpdateBid(int newBid)
        {
            Console.WriteLine($"{name} raises card with bid: {newBid}");
        }
    }
}
