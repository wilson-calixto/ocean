using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallBehaviour : MonoBehaviour {


	Rigidbody2D rb;
	
	public float speed;	


	void Awake ()
    {
        rb=GetComponent<Rigidbody2D>();
    
    }

   	void Update(){
   		if(GameStateManager.GameState == GameState.Dead){
			rb.velocity=new Vector2(0,0);
		}else{
			rb.velocity=new Vector2(0,speed*-1);
		}	
		
	}

	
	

	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "End") {	
			Destroy(gameObject);
		}


	}
	public void Die(){
		Destroy(gameObject);
	}

}
