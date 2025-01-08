using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persecutor : MonoBehaviour
{
    public Transform Object;
    public float Speed = 1.0f;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(Object.transform.position, transform.position, Speed * Time.deltaTime);
    }
}
