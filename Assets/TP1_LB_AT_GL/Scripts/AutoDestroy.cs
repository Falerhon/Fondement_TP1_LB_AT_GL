using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
/// <summary>
/// MADE BY : Alexandre Tremblay
/// 
/// Simple class that checks every 2s if the object is too far and destroys it if it is
/// Also calls the paret's spawn function if it exists
/// </summary>
public class AutoDestroy : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(DistanceCheck());
        StartCoroutine(VelocityCheck());
    }

    IEnumerator DistanceCheck()
    {
        yield return new WaitForSeconds(2f);

        if(Vector2.Distance(transform.position, Vector2.zero) > 30)
        {
            Destroy(this.gameObject);
        }
        else
        {
            StartCoroutine(DistanceCheck());
        }
    }

    IEnumerator VelocityCheck()
    {
        yield return new WaitForSeconds(5f);

        if (gameObject.GetComponent<Rigidbody2D>().velocity.magnitude <= 0.1f)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Debug.Log("Velocity magnitude : " + gameObject.GetComponent<Rigidbody2D>().velocity.magnitude);
            StartCoroutine(VelocityCheck());
        }
    }

    private void OnDestroy()
    {
        if(gameObject.transform.parent.gameObject.GetComponent<Spawner>())
        {
            gameObject.transform.parent.gameObject.GetComponent<Spawner>().Spawn();
        }
    }
}
