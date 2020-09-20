using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Audio : MonoBehaviour
{   
    public AudioClip audios;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 6  && Time.time < 7) {
            GetComponent<AudioSource>().clip = audios;
            GetComponent<AudioSource>().Play();
        }
    }
}
