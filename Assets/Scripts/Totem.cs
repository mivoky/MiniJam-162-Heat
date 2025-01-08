using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Totem : MonoBehaviour
{
    public bool IceActive;

    public Material Ice;
    public Material Fire;
    [Header("Condition")]
    public UnityEvent IceActionActive;
    public UnityEvent FireActionActive;

    private MeshRenderer _meshRenderer;
    private AudioSource _audioSource;
    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _audioSource = GetComponent<AudioSource>();
        if (IceActive)
        {
            IceActionActive?.Invoke();
            _meshRenderer.material = Ice;
        }
    }
    public void Execute(bool ice)
    {
        Debug.Log(ice);
        if (ice == true && !IceActive)
        {
            IceActionActive?.Invoke();
            _meshRenderer.material = Ice;
            IceActive = !IceActive;
            _audioSource.Play();
        }
        if (ice == false && IceActive == true)
        {
            Debug.Log("ChangeMode to Fire");
            FireActionActive?.Invoke();
            _meshRenderer.material = Fire;
            IceActive = !IceActive;
            _audioSource.Play();
        }
    }
}
