using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloner : MonoBehaviour
{
    public GameObject cloneObject;
    public GameObject location;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoClone()
    {
        Debug.Log("Cloning...");
        var obj = Object.Instantiate(cloneObject, location.transform.position, Quaternion.Euler(0, 0, 0));
        obj.SetActive(true);
    }
}
