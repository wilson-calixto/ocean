using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {
	
	public int attackDamage=1;	
	public float velocidade=1;
	public int current_points=0;
	public float current_fuel=100;
	public int max_fuel=100;
    PlayerHealth health;

	Rigidbody2D rb;
	Animator anim;
	float last_h;



	// Use this for initialization
	void Awake(){
		rb=GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator> ();
		last_h=Input.GetAxis("Horizontal");		
		health = GetComponent <PlayerHealth> ();

	}
		

	// Update is called once per frame
	void Update () {
		

		rb.AddForce(new Vector2(Input.GetAxis("Horizontal")*velocidade,0));
		rb.AddForce(new Vector2(0,Input.GetAxis("Vertical")*velocidade));				
		float h = Input.GetAxisRaw ("Horizontal");      
		checksLimits();
		Animating (h);
		checksFuel();

	}       

	void checksFuel(){
		
		current_fuel=current_fuel-0.1f;

		if(current_fuel <= 0){
			health.Die();
		}

	}
	void checksLimits(){

		// Verificando o posicionamento do player dentro dos limites da câmera.
		var distanceZ = (transform.position - Camera.main.transform.position).z;

		var leftBorder = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, distanceZ)).x;

		var rightBorder = Camera.main.ViewportToWorldPoint (new Vector3 (1, 0, distanceZ)).x;

		var topBorder = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, distanceZ)).y;

		var bottomBorder = Camera.main.ViewportToWorldPoint (new Vector3 (0, 1, distanceZ)).y;

		transform.position = new Vector3 (
			Mathf.Clamp (transform.position.x, leftBorder, rightBorder),
			Mathf.Clamp (transform.position.y, topBorder, bottomBorder),
			transform.position.z
		);

	}
   	//VERIFICA SE MUDOU DA ESQ PRA DIR E SETA O TIGRER
    void Animating (float h)
    {   
		  
        if(h < last_h){
        	
        	anim.SetBool ("Going_to_front", false);        
        	anim.SetBool ("Turn_to_left", false);        
        	anim.SetBool ("Turn_to_right", true);
        }
        if(h > last_h){
        	
        	anim.SetBool ("Turn_to_right", false);
        	anim.SetBool ("Going_to_front", false);        	        	
        	anim.SetBool ("Turn_to_left", true);
        }
        last_h=h;
    }

    public void takePoints (int points){
		current_points += points;
		ScoreManagerScript.Score = current_points;
	}

	public void takeFuel (float fuel){
		if(current_fuel<max_fuel){
			current_fuel += fuel;
		}
	}
}
