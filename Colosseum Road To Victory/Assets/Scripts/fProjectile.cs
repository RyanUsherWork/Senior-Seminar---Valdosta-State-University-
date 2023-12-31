﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fProjectile : MonoBehaviour
{
    public float ProjectileSpeed;// This controls how fast the projectile goes.
    private Rigidbody2D rigidBody;// This Rigidbody2D component is refrenced off of the Fireball prefab.


    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = transform.right * ProjectileSpeed;
        Destroy(gameObject, 3f);

        FindObjectOfType<AudioManager>().Play("FireBallSwoosh");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")//This if statement destroys any game object with the tag "Enemy".
        {
            FindObjectOfType<AudioManager>().Play("FireBallDeath");
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
