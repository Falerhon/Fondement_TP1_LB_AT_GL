using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// MADE BY : Léa Bouchard
/// Simple class that triggers and "animation" when the player overlaps
/// the gameobject
/// </summary>
public class BoxController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            DeathAnimation();
    }

    private void DeathAnimation()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);
        transform.eulerAngles = new Vector3(0, 0, -15);
    }
}
