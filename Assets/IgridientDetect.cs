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
    private Material material;
    private float intencity = 0;
    public ParticleSystem Particle;
    public GameObject Spawner;
    private void Awake()
    {
        material = GetComponent<MeshRenderer>().material;
        GetComponent<MeshRenderer>().material = material;

    }


    void OnTriggerEnter(Collider other)
    {
       
        Vector3 contactPosition = other.gameObject.transform.position;
        contactPosition.y = gameObject.transform.position.y;
        if (other.tag == "ColorPicker")
        {
            Material BaseMaterial = other.GetComponent<MeshRenderer>().material;
            BaseMaterial.color = material.color;
            
        } else if (other.tag == "ColorGiver")
        {
            var ingredient = other.GetComponent<MixableColor>();
            if (ingredient == null)
            {
                return;
            }
            var GoalColor = material.color * intencity + ingredient.Color * ingredient.Intencity;
            intencity += ingredient.Intencity;

            GoalColor /= intencity;
            material.color = new Color(GoalColor.r, GoalColor.g, GoalColor.b, 1f);

            
            Destroy(other.gameObject);
        } else
        {
            return;
        }
        Particle.startColor = material.color;
        Particle.Play();
        
    }
   
}
