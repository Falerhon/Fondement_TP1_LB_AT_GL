using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// MADE BY: Guillaume Lévesque
/// 
/// Sole purpose of this class is to allow the return of a vector2
/// allow object that collide to apply a force based on the reflection
///  </summary>
public class PoolWall : MonoBehaviour
{
	[SerializeField] private Vector2 reboundDirrection;
	
	public Vector2 GetReboundDirrection()
	{
		return (reboundDirrection);
	}
}
