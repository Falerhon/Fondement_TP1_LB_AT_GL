using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// MADE BY : Léa Bouchard
/// Class that manage the parallax effect
/// It moves the different layers according to their parallaxEffect
/// and if the camera is moving out of bounds, moves the background
/// </summary>
/*Source : This class have been created with the help of :
 *  https://www.youtube.com/watch?v=zit45k6CUMk (Unity Parallax Tutorial - How to infinite scrolling background)
*/
public class Parallax : MonoBehaviour
{
    private float lenght;
    private float startPos;
    public Camera cam;
    public float parallaxEffect;

    void Start()
    {
        Bounds boundSize = GetComponent<SpriteRenderer>().bounds;
        startPos = transform.position.x - (boundSize.size.x);
        lenght = boundSize.size.x;
    }

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
