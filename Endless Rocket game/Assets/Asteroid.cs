using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private GameObject Spaceship;
    void Start()
    {
        Spaceship = GameObject.FindGameObjectWithTag("Spaceship");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Border")
        {
            Destroy(this.gameObject);
        }
        else if(collision.tag=="Spaceship")
        {
            Destroy(Spaceship.gameObject);
        }
    }
}
