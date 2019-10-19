using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityAudio : MonoBehaviour
{
    public AudioSource audio;
    public double velocityThreshold;
    private Rigidbody _body;
    
    // Start is called before the first frame update
    void Start()
    {
        _body = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (audio.isPlaying && _body.velocity.magnitude < velocityThreshold)
        {
            audio.Stop();
        }

        if (audio.isPlaying && _body.velocity.magnitude >= velocityThreshold)
        {
            return;
        }

        if (_body.velocity.magnitude >= velocityThreshold)
        {
            audio.Play();            
        }

        
    }
}
