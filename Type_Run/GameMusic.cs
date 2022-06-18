using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour
{
    private AudioSource AudioSource;
    void Start()
    {
        AudioSource = this.GetComponent<AudioSource>();
        
    }

    
    void Update()
    {
        
    }
    public void PlayMusic()
    {
        AudioSource.Play();
    }
    public void StopMusic()
    {
        AudioSource.Stop();
    }
}
