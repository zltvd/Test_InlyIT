using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowController : MonoBehaviour, ISubject
{
    public List<IObserver> _observers = new List<IObserver>();
    public void Attach(IObserver observer)
    {
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);
        }
    }
    public void Detach(IObserver observer)
    {
        if (_observers.Contains(observer))
        {
            _observers.Remove(observer);
        }
    }
    public void Notify(int i)
    {
        foreach (var observer in _observers)
        {
            if (observer != null)
            {
                observer.OpenWindow(i);
            }
        }
    }
}
