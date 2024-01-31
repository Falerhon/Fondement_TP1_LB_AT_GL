using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

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
