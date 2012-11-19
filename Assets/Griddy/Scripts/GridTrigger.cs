using UnityEngine;

public enum TriggerEvent
{
    StartHover,
    StopHover,
    OnRightClick,
    OnLeftClick
}

/*
 * The Trigger can determine what types of events it responds to,
 * but it does so independently of what the game state is.
 */
/* Specific logic on how to handle a triggered event.
 * Note, this is not the result, merely more handling of
 * the input.
 * 
 * The Trigger doesn't care what the game state is, it's role
 * is to report the events (that it's listening for) to the
 * controller.
 */ 
public class GridTrigger : MonoBehaviour
{
    public GridController2 controller2;
	public int test;
 
    void Awake ()
    {
        if (!controller2) {
            Debug.LogError ("Controller not defined.");
        }
    }
 
    public void StartHover ()
    {
        controller2.Trigger (TriggerEvent.StartHover);
    }
 
    public void StopHover ()
    {
        controller2.Trigger (TriggerEvent.StopHover);
    }

    public void OnRightClick ()
    {
        controller2.Trigger (TriggerEvent.OnRightClick);
    }

    public void OnLeftClick ()
    {
        controller2.Trigger (TriggerEvent.OnLeftClick);
    }
}