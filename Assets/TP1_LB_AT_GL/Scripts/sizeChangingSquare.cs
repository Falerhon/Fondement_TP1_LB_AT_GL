using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// MADE BY: Guillaume Lévesque
/// 
/// Class that has for purpose to demonstrate transformation of component 
/// by increasing it's size and rotating everytime a component of the class PoolBall collide with it
///  </summary>
public class sizeChangingSquare : MonoBehaviour
{

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.GetComponent<PoolBall>() != null)
		{
			transform.localScale = transform.localScale * 1.05f;
			transform.Rotate(0.0f,0.0f,5.0f,Space.Self);
		}
	}
}
