using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    //Script
    public BirdScript BirdScript;

    //GameObject
    public GameObject Tubes;
    public GameObject Gold;

    //Variable
    int x;

    void Start()
    {
        StartCoroutine(Spawner());
    }

    

    void Update()
    {
       
        

    }

    public IEnumerator Spawner()
    {
        
        while (BirdScript.dead==false)
        {
            float random = Random.Range(0.5f, -0.2f);
            Instantiate(Tubes, new Vector3(1, random, 0), Quaternion.identity);

            if (x==2)
            {
                
                Instantiate(Gold, new Vector3(1, random, 0), Quaternion.identity);
                x = 0;
            }
            x++;
            yield return new WaitForSeconds(2f);
        }
        
        
    }
}
