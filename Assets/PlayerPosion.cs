using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       this.minions = new List<GameObject>();
    }

    // Update is called once per frame
    float playerPosX;
    List<GameObject> minions;
    public GameObject minionPrefab;
    void Update()
    {
        playerPosX=transform.position.x;
        //int playerLocation = 21;
        int spawnLocation = 3;
        if (playerPosX >= spawnLocation) this.Spawn();
        
    }   
    void Spawn()
    {
        Debug.Log("Spawn");
        if (minions.Count >= 7) return;
        int index = minions.Count + 1;
        GameObject minion = Instantiate(minionPrefab);
        minion.name = "MinionPrefab" + index;
        this.minions.Add(minion);
        minion.transform.position = transform.position;
        minion.SetActive(true);
    }
    
}
