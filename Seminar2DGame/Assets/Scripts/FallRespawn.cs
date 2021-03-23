﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallRespawn : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.transform.position = spawnPoint.position;
            Heart.numOfHearts -= 1;
        }
    }
}
