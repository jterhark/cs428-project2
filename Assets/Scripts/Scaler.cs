using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{

    private int level = 2;
    public Vector3 ScaleLevelOne, ScaleLevelTwo, ScaleLevelThree;

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

        Scale();

    }

    void Scale()
    {
        switch (level)
        {
            case 1:
                transform.localScale = ScaleLevelOne;
                break;
            case 2:
                transform.localScale = ScaleLevelTwo;
                break;
            case 3:
                transform.localScale = ScaleLevelThree;
                break;
        }
    }

    public void ScaleUp()
    {
        Debug.Log("SCALER: Something Happened!");
        
        if (level > 2)
        {
            return;
        }

        level++;
        
        Scale();

        
    }
}

public class What : MonoBehaviour
{
    public void ScaleDown()
    {
        Debug.Log("SCALER: Second Class");
    }
}
