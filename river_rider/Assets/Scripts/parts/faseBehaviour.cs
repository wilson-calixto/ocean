using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faseBehaviour : MonoBehaviour {


  public GameObject[] gameObjects;
  public GameObject[] spawnPointPositions;
  
  
  void Awake ()
    {     
    	int number_of_enemys = Random.Range(1, 7);
    	for (int c=0;c<number_of_enemys;c++){
	      	int indexOfGameObject = Random.Range(0, gameObjects.Length);
	        int position = Random.Range(0, spawnPointPositions.Length);
	      	GameObject go = Instantiate(gameObjects[indexOfGameObject], spawnPointPositions[position].transform.position, Quaternion.identity) as GameObject;


    	}
    }


}
