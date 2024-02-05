using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// MADE BY: Guillaume Lévesque
///  
/// class that sole purpose is to make a physic based rotation
/// start everytime a poolBall collide with it we increase the angular velocity
///  </summary>
public class RotatingSquare : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.angularVelocity =300;
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.GetComponent<PoolBall>() != null)
		{
			rb.angularVelocity += 50;
		}
	}
}
