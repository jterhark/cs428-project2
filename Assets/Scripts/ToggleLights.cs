using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLights : MonoBehaviour
{
    private bool toggled = false;
    public GameObject light;

    // Start is called before the first frame update
    void Start()
    {
        var l = this.gameObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeLights() {
        Debug.Log("triggered!");
        
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
