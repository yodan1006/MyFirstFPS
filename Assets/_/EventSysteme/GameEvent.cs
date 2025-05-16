using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New GameEvent", menuName = "Events systeme/HameEvent")]
public class GameEvent : ScriptableObject
{

    private List<GameEventListener> listeners = new List<GameEventListener>();
    public void SubscribeToEvent(
        GameEventListener listener)
    {
        listeners.Add(listener);
    }

    public void UnsubscribeFromEvent(
        GameEventListener listener)
    {
        listeners.Remove(listener);
    }

    public void Raise()
    {
        for (int i = listeners.Count; i >= 0; i--)
        {
            listeners[i].OnRaiseEvent();
        }
    }
}