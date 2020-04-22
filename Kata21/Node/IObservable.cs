using System;
using System.Collections.Generic;
using System.Text;

namespace Kata21
{
    public interface IObservable
    {
        void AttachObserver(IObserver observer);
        void DetachObserver(IObserver observer);
        void NotifyAllObservers();
    }
}
