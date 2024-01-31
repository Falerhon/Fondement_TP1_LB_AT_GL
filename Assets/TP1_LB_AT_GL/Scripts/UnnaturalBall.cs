using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UnnaturalBall : MonoBehaviour
{
    private Spawner spawner;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DistanceCheck());

        spawner = FindFirstObjectByType<Spawner>();
    }
    IEnumerator DistanceCheck()
    {
        yield return new WaitForSeconds(2f);

        if(Vector2.Distance(transform.position, Vector2.zero) > 30)
        {
            spawner.Spawn();
            Destroy(this.gameObject);
        }
        else
        {
            StartCoroutine(DistanceCheck());
        }
    }
}
