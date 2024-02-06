using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// MADE BY : Alexandre Tremblay
/// 
/// Simple class that adds a force to a rigidbody2D
/// </summary>
public class AddForce : MonoBehaviour
{

    [SerializeField] private Rigidbody2D Rigidbody;
    [SerializeField] private Vector2 Force;

    // Update is called once per frame
    void Update()
    {
        Rigidbody.AddForce(Force);
    }
}
