using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreatTotem : MonoBehaviour
{
    public GameData GameData;
    public Material Ice;

    private MeshRenderer _meshRenderer;
    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }
    public void Execute() 
    {
        if (GameData.IcePlayer)
        {
            _meshRenderer.material = Ice;
            GameData.EndGame = true;
        }
        
    }
}
