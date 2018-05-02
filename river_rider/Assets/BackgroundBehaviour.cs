using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundBehaviour : MonoBehaviour {

  public Vector2 velocity;
  
  void Awake ()
    {
        GetComponent<Rigidbody2D>().velocity = velocity;    
    }


}
