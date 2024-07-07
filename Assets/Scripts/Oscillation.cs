using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillation : MonoBehaviour
{
    public float Distance = 1.0f;
    public float Speed = 1.0f;

    private Vector3 _bottomDeadPoint;
    private Vector3 _startPoint;
    private bool _moveToStart;
    private void Start()
    {
        _startPoint = transform.position;
        _bottomDeadPoint = transform.position - transform.up * Distance;
    }
    private void Update()
    {
        if (transform.position == _startPoint)
        {
            _moveToStart = false;
        }
        if (transform.position == _bottomDeadPoint)
        {
            _moveToStart = true;
        }
        if (_moveToStart)
        {
            transform.position = Vector3.MoveTowards(transform.position, _startPoint, Speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, _bottomDeadPoint, Speed * Time.deltaTime);
        }
    }
}
