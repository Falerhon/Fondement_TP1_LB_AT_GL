using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// MADE BY : Léa Bouchard
/// Simple class that add a small velocity to the gameobject
/// </summary>
public class DragonController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidBody;

    // Update is called once per frame
    void Update()
    {
        rigidBody.velocity = new Vector2(2, 0);
    }
}
