namespace Module
{
    public interface IAuctionSubject
    {
        void AttachObserver(IAuctionObserver observer);
        void DetachObserver(IAuctionObserver observer);
        void NotifyObservers();
    }
}
