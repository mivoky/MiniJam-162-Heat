using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerObject : MonoBehaviour
{

    [Header("Condition")]
    public UnityEvent action;

    public bool Test = false;
    private void OnTriggerEnter(Collider other)
    {
        action?.Invoke();
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
