using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixableColor : MonoBehaviour
{
    public Color Color;
    public float Intencity;
    private Material material;

    private void Awake()
    {
        material = GetComponent<MeshRenderer>().material;
        material.color = Color;
        GetComponent<MeshRenderer>().material = material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
