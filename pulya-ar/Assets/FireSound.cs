using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSound : MonoBehaviour
{
    public AudioClip Sound;
    public AudioSource source;
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void playSound()
    {
        source.PlayOneShot(Sound);
    }
}
