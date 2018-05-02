using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class submarineBehaviour : MonoBehaviour {
	
	public float xSpeed;	
	
	Rigidbody2D rb;
	int direction=-1;

	void Awake(){
		rb=GetComponent<Rigidbody2D>();
		 
	}
	
	// Update is called once per frame
	void Update () {

		if(GameStateManager.GameState == GameState.Dead){
			stop_to_move();
		}else{
			go_to_front();
		}	
		
        
	}


	void stop_to_move(){
		rb.velocity=new Vector2(0,0);
	}

	void go_to_front(){
		rb.velocity=new Vector2(xSpeed*direction,xSpeed*-1);
	}

	void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "InvisibleWall" || coll.gameObject.tag == "Fuel")
            Stop_to_move_on_x_axis();        	
    }

    void Stop_to_move_on_x_axis(){   	
    		direction=0;    	
    }
	
	

 
}
