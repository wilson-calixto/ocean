using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth;
    public int currentHealth;
    bool isDead;    

    void Awake ()
    {

        currentHealth = startingHealth;
    }

    public void TakeDamage (int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0 && !isDead) {
            Die ();
        }
    }
    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "InvisibleWall" )
            Die();          
    }
    public void Die ()
    {
        GameStateManager.GameState = GameState.Dead;
    	Destroy(gameObject);         
    	
    }
}
