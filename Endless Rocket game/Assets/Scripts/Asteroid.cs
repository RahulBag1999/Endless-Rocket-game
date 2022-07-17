using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private GameObject Spaceship;
    [SerializeField] private float rotationSpeed;
    void Start()
    {
        Spaceship = GameObject.FindGameObjectWithTag("Spaceship");
    }

    private void FixedUpdate()
    {
        transform.Rotate(0, 0, 1 * rotationSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Border")
        {
            Destroy(this.gameObject);
        }
        else if(collision.tag=="Spaceship")
        {
            Destroy(Spaceship);
        }
    }
}
