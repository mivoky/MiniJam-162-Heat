using UnityEngine.Events;
using UnityEngine;

public class ActivityItem : MonoBehaviour
{
    [Header("Condition")]

    public UnityEvent ActionActive;
    public UnityEvent ActionInactive;

    public bool Active;

    public void Execute()
    {
        Active = !Active;
        if (Active)
        {
            ActionActive?.Invoke();
        }
        else 
        {
            ActionInactive?.Invoke();
        }
    }
    public void DebugMenu(string msg)
    {
        Debug.Log(msg);
    }
}
