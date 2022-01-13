using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawn : MonoBehaviour
{

    public GameObject Prefab;
    public Transform SpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }
    public void Spawn()
    {
        GameObject.Instantiate(Prefab, SpawnPoint.position, SpawnPoint.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
