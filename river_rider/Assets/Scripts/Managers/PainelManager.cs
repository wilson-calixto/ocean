using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PainelManager : MonoBehaviour {
	
	 
	public GameObject[] numbersList; 
	public GameObject[] spawnGameObjetcList; 

	int current_points;
	GameObject player;
    
	// Use this for initialization
	void Awake () {
		player = GameObject.FindGameObjectWithTag ("Player");  
		print();
	}
	
	// Update is called once per frame
	void Update () {
		current_points = player.GetComponent<PlayerBehaviour>().current_points;		
	}

	void print(){

		int i=0;
		int points=0;
		GameObject g = Instantiate(numbersList[points], spawnGameObjetcList[i].transform.position, Quaternion.identity);

	//	gameObjetcList[i].renderer.material.color = Color(0.777, 08, 0.604);


		//gameObjetcList[i].GetComponent<Renderer>().material.color = Color(255, 255, 255);  //=spriteList[points];


	}
}
