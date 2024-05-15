namespace Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auctioneer auctioneer = new Auctioneer();

            AuctionParticipant participant1 = new AuctionParticipant("Participant 1");
            AuctionParticipant participant2 = new AuctionParticipant("Participant 2");

            auctioneer.AttachObserver(participant1);
            auctioneer.AttachObserver(participant2);

            auctioneer.StartAuction();

            participant1.UpdateBid(40);
        }
    }
}
