using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Totem : MonoBehaviour
{
    public AudioClip ActivateIce;
    public AudioClip ActivateFire;

    public GameData GameData;

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
    }
    public void Execute(bool ice)
    {
        if (ice && !IceActive)
        {
            IceActionActive?.Invoke();
            _meshRenderer.material = Ice;
            GameData.TotalScore += 1;
            IceActive = !IceActive;
            _audioSource.PlayOneShot(ActivateIce, 0.7F);
        }
        if (!ice && IceActive)
        {
            FireActionActive?.Invoke();
            _meshRenderer.material = Fire;
            GameData.TotalScore -= 1;
            IceActive = !IceActive;
            _audioSource.PlayOneShot(ActivateFire, 0.7f);
        }
    }
}
