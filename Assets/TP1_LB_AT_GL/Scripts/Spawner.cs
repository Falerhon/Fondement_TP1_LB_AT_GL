using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// MADE BY : Alexandre Tremblay
/// 
/// Simple class that spawns any gameobject (or prefabs) placed as it's ObjectToSpawn
/// </summary>
public class Spawner : MonoBehaviour
{

    [SerializeField] private GameObject ObjectToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        Instantiate(ObjectToSpawn, this.gameObject.transform);
    }
}
