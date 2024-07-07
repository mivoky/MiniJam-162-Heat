using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveBlock : MonoBehaviour
{
    public Material ActiveBlock;
    public Material InActiveBlock;

    private MeshRenderer _meshRenderer;
    private BoxCollider _boxCollider;
    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _boxCollider = GetComponent<BoxCollider>();
    }
    public void ActivateBlock(bool active) 
    {
        if (!active)
        {
            _meshRenderer.material = ActiveBlock;
            _boxCollider.enabled = false;
        }
        else 
        {
            _meshRenderer.material = InActiveBlock;
            _boxCollider.enabled = true;
        }
    }
}
