using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartBehaviour : MonoBehaviour {
  public Vector2 velocity;
  
  //public GameObject bound;
  //public Transform bound_transform;

  void Start() {
      //Transform bound_transform = bound.GetComponent<Transform>();
     // Physics2D.IgnoreCollision(bound_transform.GetComponent<Collider2D>(), GetComponent<Collider2D>());
  }
  
  void Awake ()
    {
        GetComponent<Rigidbody2D>().velocity = velocity;            

    }

  // Use this for initialization
  void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "End")
            Die();        
    }

    void Die ()
    {
        Destroy(gameObject);         
        
    }


}
