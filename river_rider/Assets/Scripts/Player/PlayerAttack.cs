using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

	public GameObject spawn_bullet;
    public GameObject bullet;
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space)){
            GameObject g = Instantiate(bullet, spawn_bullet.transform.position, Quaternion.identity);
        }
		
	}
}
