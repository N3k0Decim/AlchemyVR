using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.VFX;
using Random = UnityEngine.Random;

public class IgridientDetect : MonoBehaviour

{
    public GameObject Object;

    public Material white;
    public Material red;
    public Material blue;
    public Material green;
    public Material violet;
    public Material orange;
    public Material yellow;

    void OnTriggerEnter(Collider other)
    {
        Material ingredient = other.GetComponent<MeshRenderer>().material;
        Material BaseColor = Object.GetComponent<MeshRenderer>().material;

        
            Object.GetComponent<MeshRenderer>().material = ingredient;
       
    
        

    }
}
