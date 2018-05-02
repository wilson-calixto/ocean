using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;
public class jetBehaviour : MonoBehaviour {
	
	Rigidbody2D rb;	
	
	Transform player;
    NavMeshAgent nav;


		// Use this for initialization
	void Awake(){
		rb=GetComponent<Rigidbody2D>();
		move();
		
	}

	void move(){
		nav = GetComponent<NavMeshAgent>();
		player = GameObject.FindGameObjectWithTag("Player").transform;
		nav.SetDestination(player.position);       

	}
	
		
	void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "InvisibleWall")
    		Destroy(gameObject);
    }


    
}
