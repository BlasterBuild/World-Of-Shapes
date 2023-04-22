using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public ParticleSystem destroyer;
    float spawn_rate = 10.0f;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        CircleCollider2D bullet_collider = other.gameObject.GetComponent<CircleCollider2D>();
        if(other.collider == bullet_collider)
        {
            
            Instantiate(destroyer.gameObject, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }

   
}
