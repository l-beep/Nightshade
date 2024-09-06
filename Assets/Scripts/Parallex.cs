using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Parallex : MonoBehaviour
{
    private float startPos, length;
    public float parallexEffect;

    public GameObject Cam;

    private void Start()
    {
        startPos = transform.position.x;
        
    }

    private void Update()
    {
       float distance =  Cam.transform.position.x * parallexEffect;
        length = this.GetComponent<SpriteRenderer>().bounds.size.x;
        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);

        float temp = Cam.transform.position.x * (1 - parallexEffect);
        if(temp > startPos + length)
        {
            startPos += length;

        }
    }
}
