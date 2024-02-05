using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// MADE BY: Guillaume Lévesque
/// 
/// class that handle collision of pool Ball on wall and other ball
/// also give basic force to ball on start up if is basic ball
/// </summary>
public class PoolBall : MonoBehaviour
{
   [SerializeField] private Rigidbody2D rigidBody;

    public bool isStart;
    Vector2 currentAngle;

    // Start is called before the first frame update
    void Start()
    {
        if (isStart)
        {
            rigidBody.AddForce(new Vector2(5.0f, 0.0f),ForceMode2D.Impulse);
        }    
    }

    
    
    //
	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.gameObject.GetComponent<PoolWall>() != null)
        {
           
            PoolWall wall = collision.gameObject.GetComponent<PoolWall>();
            Vector2 reflection = wall.GetReboundDirrection();
            Vector2 forceToApply = currentAngle * reflection;
				rigidBody.AddForce(forceToApply.normalized*120,ForceMode2D.Force);
        }
        if (collision.gameObject.GetComponent<sizeChangingSquare>())
        {
            Vector2 futureAngle = transform.position- collision.gameObject.transform.position;
            rigidBody.AddForce(futureAngle * 60.0f);
        }

	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
             currentAngle = rigidBody.velocity;
        
	}

    public void Decelerate()
    {
        rigidBody.AddForce(-1 * rigidBody.velocity , ForceMode2D.Force);
    }
}
