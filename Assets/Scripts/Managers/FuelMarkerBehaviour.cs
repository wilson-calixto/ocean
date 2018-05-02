using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelMarkerBehaviour : MonoBehaviour {
    
    
    GameObject player;    
    PlayerBehaviour playerBehaviour;
    
    float timer;

    void Awake ()
    {
        player = GameObject.FindGameObjectWithTag ("Player");        
        playerBehaviour=player.GetComponent<PlayerBehaviour>();
    }


	// Update is called once per frame
	void Update () {
        if(GameStateManager.GameState == GameState.Playing && playerBehaviour.current_fuel >= 0){
            
            float x=0f;
            if(playerBehaviour.current_fuel > 90f){
                 x = 2.6f;
            }
            if(playerBehaviour.current_fuel > 80f && playerBehaviour.current_fuel < 90f ){
                 x = 2.24f;
            }

            if(playerBehaviour.current_fuel > 70f && playerBehaviour.current_fuel < 80f ){
                 x = 1.88f;
            }
            if(playerBehaviour.current_fuel > 60f && playerBehaviour.current_fuel < 70f ){
                 x = 1.56f;
            }
            if(playerBehaviour.current_fuel > 50f && playerBehaviour.current_fuel < 60f ){
                 x = 1.2f;
            }
            if(playerBehaviour.current_fuel > 40f && playerBehaviour.current_fuel < 50f ){
                 x = 0.80f;
            }
            if(playerBehaviour.current_fuel > 30f && playerBehaviour.current_fuel < 40f ){
                 x = 0.4f;
            }
            if(playerBehaviour.current_fuel > 20f && playerBehaviour.current_fuel < 30f ){
                 x = 0.0f;
            }
            if(playerBehaviour.current_fuel > 10f && playerBehaviour.current_fuel < 20f ){
                 x = -0.6f;
            }
            if(playerBehaviour.current_fuel <= 10f){
                 x = -1f;
            }
            

            transform.position = new Vector3 ( x, transform.position.y, transform.position.z);    
        }
		


	}
}
