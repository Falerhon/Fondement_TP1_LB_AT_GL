using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*Source : This class have been created with the help of :
 *  https://www.youtube.com/watch?v=zit45k6CUMk (Unity Parallax Tutorial - How to infinite scrolling background)
*/
public class Parallax : MonoBehaviour
{
    private float lenght;
    private float startPos;
    public Camera cam;
    public float parallaxEffect;

    // Start is called before the first frame update
    void Start()
    {
        Bounds boundSize = GetComponent<SpriteRenderer>().bounds;
        startPos = transform.position.x - (boundSize.size.x);
        lenght = boundSize.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float dist = cam.transform.position.x * parallaxEffect;
        transform.position = new Vector3(startPos + dist, transform.position.y, transform.position.z);

        //check if camera is going out of background's bounds
        float bounds = cam.transform.position.x * (1 - parallaxEffect);
        if (bounds > startPos + lenght)
            startPos += lenght;
        else if (bounds < startPos - lenght)
            startPos -= lenght;

    }
}
