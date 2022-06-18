using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{



    Rigidbody2D rgb;
    AudioSource AudioSource;
    public AudioClip GoldAudio;
    public AudioClip UpAudio;
    public AudioClip DeathAudio;

    //publics input
    public GameManager GameManager;


    //Variables
    public float velocity = 2;
    public bool dead;
   
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
        AudioSource = GetComponent<AudioSource>();
    }



    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rgb.velocity = Vector3.up * velocity;
            AudioSource.PlayOneShot(UpAudio);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Tube")
        {
            GameManager.BirdDeath();
            AudioSource.PlayOneShot(DeathAudio);            
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
        if (collision.gameObject.name=="TubesBetween")
        {
            
            GameManager.ScoreUpdate();

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Golds")
        {
            GameManager.GoldUpdate();
            AudioSource.PlayOneShot(GoldAudio);
        }
        
    }




}
