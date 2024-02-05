using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

/// <summary>
/// MADE BY: Guillaume Lévesque
/// 
///  </summary>
public class CannnonSquare : MonoBehaviour
{
	[SerializeField] private Vector2 launchAngle;
	[SerializeField] private Rigidbody2D rigidBody;
	private int launchDirrectionX=-1;

	// Start is called before the first frame update
	void Start()
    {
		AddImpulse(launchAngle);
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.GetComponent<PoolWall>() != null)
		{
			AddImpulse(new Vector2(launchAngle.x*launchDirrectionX,launchAngle.y));
			launchDirrectionX *= -1;
		}
	}

	private void AddImpulse(Vector2 dirrection){
		rigidBody.AddForce(dirrection, ForceMode2D.Impulse);
	}
}
