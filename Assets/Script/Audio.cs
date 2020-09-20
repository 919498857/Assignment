using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Audio : MonoBehaviour
{   
    public AudioClip[] audios;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().clip = audios[0];
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 15  && Time.time < 16) {
            GetComponent<AudioSource>().clip = audios[1];
            GetComponent<AudioSource>().Play();
        }
    }
}
