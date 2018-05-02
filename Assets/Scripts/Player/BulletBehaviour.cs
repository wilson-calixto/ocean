using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {
  public Vector2 velocity;
  
  void Awake ()
    {
        GetComponent<Rigidbody2D>().velocity = velocity;    
    }

  // Use this for initialization
  void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "Enemy" || coll.gameObject.tag == "InvisibleWall" || coll.gameObject.tag == "Fuel" )
            Die();        
    }

    void Die ()
    {
        Destroy(gameObject);         
        
    }


}
