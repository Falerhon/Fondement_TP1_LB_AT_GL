using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// MADE BY : Alexandre Tremblay
/// 
/// Simple class that modifies the physical material of a collider2d.
/// It randomly modifies the bounciness every 2 sec
/// 
/// </summary>
public class PhysMatModifier : MonoBehaviour
{
    [SerializeField] private PhysicsMaterial2D DefaultMaterial;
    [SerializeField] private float MinBounciness = 0f;
    [SerializeField] private float MaxBounciness = 1f;

    // Start is called before the first frame update
    void Start()
    {
        DefaultMaterial = new PhysicsMaterial2D();
        StartCoroutine(MaterialModifier());
    }

    IEnumerator MaterialModifier()
    {
        yield return new WaitForSeconds(2f);

        float bounciness = Random.Range(MinBounciness, MaxBounciness);
        PhysicsMaterial2D material = DefaultMaterial;

        material.bounciness = bounciness;

        gameObject.GetComponent<Collider2D>().sharedMaterial = material;

        Debug.Log("New bounciness : " + bounciness);


        StartCoroutine(MaterialModifier());
        
    }
}
