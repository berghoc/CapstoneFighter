﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sSensor : MonoBehaviour
{
    public enum PHitCollider
    {
        NoCol,
        BodyCol,
        HitCol
    };

    void Start(){}

    [SerializeField] PHitCollider _instance;
    [SerializeField] Transform _parent;
    public PHitCollider GetPHitCollider
    {
        get { return _instance;}
        set { _instance = value; }
    }
    public Transform GetParent
    {
        get {return _parent;}
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_instance != PHitCollider.NoCol)
        {
            var tempScript = other.GetComponent<sSensor>();
            if (_parent != tempScript.GetParent)
            {
                Debug.Log(other.name);
            }
        }
    }
}
