using System;
using UnityEngine;

public class StunEnemy : MonoBehaviour
{
    [SerializeField] PlayerPhysics playerPhysics;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerPhysics.isStunned = true;
        }
    }
}
