using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    //to store current sources
    private AudioSource LargeSource;
    private AudioSource MediumSource;
    private AudioSource MediumSource2;
    
    //geting our sources for each room
    
    public GameObject BigLargeSource;
    
    public GameObject Room1MediumSource;
    public GameObject Room1MediumSource2;
    
    public GameObject Room2MediumSource;
    public GameObject Room2MediumSource2;
   
    public GameObject Room3MediumSource;
    public GameObject Room3MediumSource2;
    
    public GameObject Room4MediumSource;
    public GameObject Room4MediumSource2;
    
    //audioclip arrays
    public AudioClip[] Large;
    public AudioClip[] Medium;
    public AudioClip[] Small;

    void Start()
    {
        LargeSource = BigLargeSource.GetComponent<AudioSource>();
        MediumSource = Room1MediumSource.GetComponent<AudioSource>();
        MediumSource2 = Room1MediumSource2.GetComponent<AudioSource>();

        GenerateRandomRoomSounds();
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("1"))
        {
            //set our audiosources to current room source
            MediumSource = Room2MediumSource.GetComponent<AudioSource>();
            MediumSource2 = Room2MediumSource2.GetComponent<AudioSource>();
            
            //randomize the clips of the audiosources
            GenerateRandomRoomSounds();
            
        } else if (gameObject.CompareTag("2"))
        {
            MediumSource = Room3MediumSource.GetComponent<AudioSource>();
            MediumSource2 = Room3MediumSource2.GetComponent<AudioSource>();

            GenerateRandomRoomSounds();
            
        } else if (gameObject.CompareTag("3"))
        {
            MediumSource = Room4MediumSource.GetComponent<AudioSource>();
            MediumSource2 = Room4MediumSource2.GetComponent<AudioSource>();

            GenerateRandomRoomSounds();
            
        } else if (gameObject.CompareTag("4"))
        {
            MediumSource = Room1MediumSource.GetComponent<AudioSource>();
            MediumSource2 = Room1MediumSource2.GetComponent<AudioSource>();

            GenerateRandomRoomSounds();
        }
    }

    void GenerateRandomRoomSounds()
    {
        //LargeSource.clip = Large[Random.Range(0, 3)];

        MediumSource.clip = Medium[Random.Range(0, 4)];
        MediumSource.Play();
        
        MediumSource2.clip = Medium[Random.Range(0, 4)];
        MediumSource2.Play();
    }
}
