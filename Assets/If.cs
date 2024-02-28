using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        //this.gameObject.SetActive(false);
    }
    void Start()
    {
        int playerLocation = 21;
        int spawnLocation = 20;
        if (playerLocation == spawnLocation) this.Spawn();
        else this.NotSpawn();
      
    }

    void Spawn()
    {
        Debug.Log("Spawn");
    }
    void NotSpawn()
    {
        Debug.Log("NotSpawn");
    }
}
