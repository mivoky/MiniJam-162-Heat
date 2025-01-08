using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revival : MonoBehaviour
{
    public GameData GameData;
    public float Speed;

    private MeshRenderer _material;
    private float _alpha;

    private void Start()
    {
        _material = GetComponent<MeshRenderer>();
    }
    private void Update()
    {
        if (GameData.EndGame && _alpha <= 1)
        {
            _alpha += Speed / 100 * Time.deltaTime;
            _material.material.color = new Color(1f, 1f, 1f, _alpha);
        }
    }
}
