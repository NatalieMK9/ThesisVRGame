/*
 * This code plays a sound effect whenever the trigger on the hologun is pulled
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaBuster : MonoBehaviour
{
    private GameObject PewPew;
    public AudioClip Buster;

    // The Buster sound effect is mapped to the audiosource
    void dothething()
    {   AudioSource source = GetComponent<AudioSource>();
        source.clip = Buster;
        source.Play();
    }
}
