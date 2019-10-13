using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLights : MonoBehaviour
{
    public static bool toggle = false;

    // Start is called before the first frame update
    void Start()
    {
        var l = this.gameObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void DoSomething() {
        Debug.Log("triggered!");
        var light = GameObject.Find("deskLight");
        if (light.activeSelf)
        {
            light.SetActive(false);
        }
        else
        {
            light.SetActive(true);
        }
    }
}
