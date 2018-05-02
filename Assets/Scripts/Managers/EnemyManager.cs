using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject enemy;
    public GameObject enemy2;
    public GameObject enemy3;
    public float spawnTime = 3f;
    
/*
    void Start ()
    {
        InvokeRepeating ("Spawn", spawnTime, spawnTime);
    }

    void Spawn ()
    {
        if (playerHealth.currentHealth <= 0f) {
            return;
        }        

        Vector3 position = new Vector3 ( Random.Range (-8.68f, 5.27f), Random.Range (2f, 6.0f) ,0);

        Instantiate(enemy, position, Quaternion.identity );
        
        position = new Vector3 ( Random.Range (-8.68f, 5.27f), Random.Range (2f, 6.0f) ,0);
        Instantiate(enemy2, position, Quaternion.identity );
        
        position = new Vector3 ( Random.Range (-8.68f, 5.27f), Random.Range (2f, 6.0f) ,0);

        Instantiate(enemy3, position, Quaternion.identity );
		//int spawnPointIndex = Random.Range (0, spawnPoints.Length);


        //Instantiate (enemy, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
    }
*/

    public GameObject SpawnObject;
    public GameObject where;
    
    public float time = 5f;
    
  
    
// Use this for initialization
    void Start()
    {
        //SpawnObject = SpawnObjects[Random.Range(0, SpawnObjects.Length)];
        Spawn();
    }
 
    void Spawn()
    {
//        if (GameStateManager.GameState == GameState.Playing)
  //      {
            //random y position
            //float y = Random.Range(-0.5f, 1f);
            GameObject g = Instantiate(SpawnObject, where.transform.position, Quaternion.identity);

            //GameObject go = Instantiate(SpawnObject, where.transform.position, Quaternion.identity) as GameObject;
    //    }
        Invoke("Spawn", time);
    }

}
