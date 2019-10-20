using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float xSpeed, ySpeed, zSpeed;

    private float deltaTime;
    private float x, y, z;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deltaTime = Time.deltaTime;
        x += Time.deltaTime * xSpeed;
        y += Time.deltaTime * ySpeed;
        z += Time.deltaTime * zSpeed;
        this.transform.rotation = Quaternion.Euler(x,y,z);
    }
}
