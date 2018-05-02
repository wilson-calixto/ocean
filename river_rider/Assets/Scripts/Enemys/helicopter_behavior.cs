using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helicopter_behavior : MonoBehaviour {
	
	public float speed;	

	Rigidbody2D rb;
	int direction=1;
	Animator anim;
	
	void Awake(){
		rb=GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}
	
	void Update () {
		
		if(GameStateManager.GameState == GameState.Dead){
			stop_to_move();
		}else{
			move();
		}	
	}

	void stop_to_move(){
		rb.velocity=new Vector2(0,0);
	}

	void move(){
		rb.velocity=new Vector2(speed*direction,speed*-1);
	}

	

	void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "InvisibleWall" || coll.gameObject.tag == "Enemy" || coll.gameObject.tag == "Fuel")
            ChangeDirection();        	
    }
	

    void ChangeDirection(){
    	if(direction==1){    		
    		anim.SetBool ("Turn_to_right", false);
    		anim.SetBool ("Turn_to_left", true);
    		direction=-1;	
    	}else{    		
    		anim.SetBool ("Turn_to_left", false);
    		anim.SetBool ("Turn_to_right", true);
    		direction=1;
    	}
    }
}
