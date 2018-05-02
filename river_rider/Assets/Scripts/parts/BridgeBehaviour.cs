﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeBehaviour: MonoBehaviour {
	PlayerBehaviour playerBehaviour;
	GameObject player;	
	Rigidbody2D rb;
	public int points_per_bridge=10;
	public float speed;	


	void Awake ()
    {
        rb=GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag ("Player");
        playerBehaviour = player.GetComponent <PlayerBehaviour> ();
    }

   	void Update(){

		if(GameStateManager.GameState == GameState.Dead){
			rb.velocity=new Vector2(0,0);
		}else{
			rb.velocity=new Vector2(0,speed*-1);
		}	
		
		
	}

	
	

	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "Bullet") {
			playerBehaviour.takeFuel(points_per_bridge	);		
			Destroy(gameObject);
		}
		if (other.gameObject.tag == "Player") {
			Destroy(other.gameObject);
		}
		if (other.gameObject.tag == "End"){
            Die();    
		}


	}
	public void Die(){
		Destroy(gameObject);
	}

	
}
