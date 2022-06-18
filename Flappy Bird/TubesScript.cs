using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubesScript : MonoBehaviour
{

    public float speed = 0.5f;

    void Start()
    {
        Destroy(gameObject,4);
    }

    
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
    
}
