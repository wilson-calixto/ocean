﻿using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
    
    public int attackDamage = 10;
    public int points_per_enemy=10;    
    GameObject player;
    PlayerHealth playerHealth;
    PlayerBehaviour playerBehaviour;
    
    float timer;

    void Awake ()
    {
        player = GameObject.FindGameObjectWithTag ("Player");
        playerHealth = player.GetComponent <PlayerHealth> ();
        playerBehaviour=player.GetComponent<PlayerBehaviour>();
    }

    

	void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "End")
            Die();
        if (coll.gameObject.tag == "Player")
            Attack ();
        if (coll.gameObject.tag == "Bullet"){
            playerBehaviour.takePoints(points_per_enemy);
            Die();
        }

    }

    
    void Attack ()
    {
        if (playerHealth.currentHealth > 0) {
            playerHealth.TakeDamage (attackDamage);
            Die();
        }    
    }

    void Die ()
    {
        Destroy(gameObject);         
        
    }
}
