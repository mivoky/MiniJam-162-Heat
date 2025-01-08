using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerTexture : MonoBehaviour
{
    public GameData GameData;
    public Material Ice;
    public Material Fire;

    private MeshRenderer _meshRenderer;
    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }
    private void Update()
    {
        if (GameData.IcePlayer)
        {
            _meshRenderer.material = Ice;
        }
        else
        {
            _meshRenderer.material = Fire;
        }
    }
}
