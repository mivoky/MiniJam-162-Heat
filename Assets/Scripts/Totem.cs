using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Totem : MonoBehaviour
{
    public GameData GameData;

    public bool IceActive;

    public Material Ice;
    public Material Fire;
    [Header("Condition")]
    public UnityEvent IceActionActive;
    public UnityEvent FireActionActive;

    private MeshRenderer _meshRenderer;
    
    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }
    public void Execute(bool ice)
    {
        if (ice && !IceActive)
        {
            IceActionActive?.Invoke();
            _meshRenderer.material = Ice;
            GameData.TotalScore += 1;
            IceActive = !IceActive;
        }
        if (!ice && IceActive)
        {
            FireActionActive?.Invoke();
            _meshRenderer.material = Fire;
            GameData.TotalScore -= 1;
            IceActive = !IceActive;
        }
    }
}
