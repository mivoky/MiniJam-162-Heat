using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    public List<Transform> Points;
    public int NumPosition;
    public float CameraSpeed;
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Points[NumPosition].position, CameraSpeed * Time.deltaTime);
    }
    public void ChangePoint(int num)
    {
        NumPosition = num;
    }
}
