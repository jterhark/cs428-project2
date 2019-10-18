using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnCollision : MonoBehaviour
{

    private AudioSource src;

    // Start is called before the first frame update
    void Start()
    {
        src = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) {
        Debug.Log("EVENT: Collision");
        src.Play();
    }

    void OnCollisionExit(Collision collision) {
        Debug.Log("EVENT: Collision Exit");
        src.Stop();
    }

    public static void DoSomething(string param)
    {
    }
}
