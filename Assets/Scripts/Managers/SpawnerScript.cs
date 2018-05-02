using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {            
        GameStateManager.GameState = GameState.Playing;
        Spawn();
    }

    void Spawn()
    {    
       if (GameStateManager.GameState == GameState.Playing)
       {    
            if(number_of_part < 4){
                GameObject go = Instantiate(parts[0], this.transform.position , Quaternion.identity) as GameObject;
                number_of_part++;
            }else{
                GameObject go = Instantiate(parts[1], this.transform.position , Quaternion.identity) as GameObject;
                number_of_part=0;            
            }       

            Invoke("Spawn",time);
        }
    }

    public GameObject[] parts;
    private int number_of_part=0;    
    

    public float time;
    
}
