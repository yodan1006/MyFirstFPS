using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    public GameEvent gameEvent;
    public UnityEvent onRaise;


    private void OnEnable()
    {
        gameEvent.SubscribeToEvent(this);
    }

    private void OnDisable()
    {
        gameEvent.UnsubscribeFromEvent(this);
    }

    public void OnRaiseEvent()
    {
        onRaise.Invoke();
    }
}