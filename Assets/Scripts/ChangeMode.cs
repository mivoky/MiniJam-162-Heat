﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMode : MonoBehaviour
{
    public GameData GameData;
    
    public Material Ice;
    public Material Fire;
    public Material Deactivate;

    public bool IceMode = false;
    public bool FireMod = false;

    private int _layerMask;
    private MeshRenderer _meshRenderer;
    private void Start()
    {
        _layerMask = ~(1 << LayerMask.NameToLayer("Ignore RayCast"));
        _meshRenderer = GetComponent<MeshRenderer>();
        _meshRenderer.material = Deactivate;
        if (IceMode)
        {
            _meshRenderer.material = Ice;
        }
        if (FireMod) 
        {
            _meshRenderer.material = Fire;
        }
    }
    //private void Update()
    //{
    //    RaycastHit hit;

    //    if (Physics.Raycast(transform.position, transform.up * 5, out hit, _layerMask))
    //    {
    //        if (IceMode && hit.collider.gameObject.GetComponent<CharacterController>() != null)
    //        {
    //            GameData.IcePlayer = true;
    //        }
    //        if (FireMod && hit.collider.gameObject.GetComponent<CharacterController>() != null)
    //        {
    //            GameData.IcePlayer = false;
    //        }
    //    }

    private void OnTriggerEnter(Collider other)
    {
        if (IceMode && other.GetComponent<CharacterController>() != null) 
        {
            GameData.IcePlayer = true;
        }
        if (FireMod && other.GetComponent<CharacterController>() != null)
        {
            GameData.IcePlayer = false;
        }
    }
    public void ChangeElement(bool ice)
    {
        if (ice)
        {
            IceMode = true;
            FireMod = false;
            _meshRenderer.material = Ice;
        }
        else
        {
            IceMode = false;
            FireMod = true;
            _meshRenderer.material = Fire;
        }
    }
    public void DeactivateElement()
    {
        IceMode = false;
        FireMod = false;
        _meshRenderer.material = Deactivate;
    }
}
