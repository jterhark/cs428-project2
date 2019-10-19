using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{

    private int level = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScaleDown()
    {
        Debug.Log("SCALER: Something Happened!");
        
        if (level < 2)
        {
            return;
        }

        level--;

        var localScale = transform.localScale;
        var newX = localScale.x / 30.0f;
        var newY = localScale.y / 30.0f;
        var newZ = localScale.z / 30.0f;
        transform.localScale = new Vector3(0.2f,0.2f,0.2f);
        
    }
    
    public void ScaleUp()
    {
        Debug.Log("SCALER: Something Happened!");
        
        if (level > 2)
        {
            return;
        }

        level++;

        var localScale = transform.localScale;
        var newX = localScale.x * 30.0f;
        var newY = localScale.y * 30.0f;
        var newZ = localScale.z * 30.0f;
        transform.localScale += new Vector3(-newX,-newY,-newZ);
        
    }
}

public class What : MonoBehaviour
{
    public void ScaleDown()
    {
        Debug.Log("SCALER: Second Class");
    }
}
