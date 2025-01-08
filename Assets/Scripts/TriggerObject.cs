using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerObject : MonoBehaviour
{

    [Header("Condition")]
    public UnityEvent action;

    public bool Test = false;
    private void OnCollisionStay(Collision collision)
    {
        action.Invoke();
        Debug.Log("Suka");
    }
    private void Update()
    {
        if (Test)
        {
            action?.Invoke();
        }

        Test = false;
    }
}
