using UnityEngine.Events;
using UnityEngine;

public class ActivityItem : MonoBehaviour
{
    [Header("Condition")]

    public UnityEvent ActionActive;
    public UnityEvent ActionInactive;

    public bool Active;

    private AudioSource _audioSource;
    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    public void Execute()
    {
        _audioSource.Play();
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
