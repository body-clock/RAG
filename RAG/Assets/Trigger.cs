using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Trigger : MonoBehaviour
{

    public AudioMixerSnapshot Room1;
    public AudioMixerSnapshot Room2;

    public AudioClip HydraulicDoor;

    private AudioSource aud;

    void Awake()
    {
        aud = GetComponent<AudioSource>();
        Room1.TransitionTo(1f);
    }

    void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Room1Out"))
        {
            Room1.TransitionTo(1f);
            aud.clip = HydraulicDoor;
            aud.Play();
        }

        if (gameObject.CompareTag("Room2In"))
        {
            Room2.TransitionTo(1f);
            Debug.Log("transition attempt");
        }
    }

}
