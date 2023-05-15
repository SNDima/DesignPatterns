namespace ObserverPattern
{
    internal interface IProductPublisher
    {
        void RegisterObserver(IProductObserver observer);
        void RemoveObserver(IProductObserver observer);
        void NotifyObservers();
    }
}
