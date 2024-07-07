using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelWall : MonoBehaviour
{
    public Material ActiveMaterial;
    public Material InActiveMaterial;
    public int UnlockScore;

    private BoxCollider _boxCollider;
    private MeshRenderer _meshRenderer;
    private int _score = 0;
    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _boxCollider = GetComponent<BoxCollider>();
    }
    private void Update()
    {
        if (_score >= UnlockScore)
        {
            _meshRenderer.material = InActiveMaterial;
            _boxCollider.enabled = false;
        }
        else 
        {
            _meshRenderer.material = ActiveMaterial;
            _boxCollider.enabled = true;
        }
    }
    public void Score(int score)
    {
        _score = _score + score;
    }
}
