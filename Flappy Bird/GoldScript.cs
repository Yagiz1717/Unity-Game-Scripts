using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldScript : MonoBehaviour
{

     

    //Variable
    public float speed = 0.5f;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.gameObject.name=="YellowBird" || collision.gameObject.name == "RedBird" || collision.gameObject.name == "BlueBird")
        {
           
            Destroy(gameObject);

            

        }
    }




}
