using System;
using UnityEngine;

public class EventController
{
    public Action baseEvent;

    public void AddListener(Action action) => baseEvent += action;

    public void RemoveListener(Action action) => baseEvent -= action;

    public void InvokeEvent() => baseEvent?.Invoke();
    
}
