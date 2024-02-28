using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RanDom : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject minion;
    
    void Start()
    {
        StartCoroutine(Randoma());
    }

    IEnumerator Randoma()
    {
        while (true)
        {
            GameObject minions = Instantiate(minion);
            var x = Random.Range(1, 10);
            var y = Random.Range(1, 10);
            minions.transform.position = new Vector3(x, y);
            yield return new WaitForSeconds(2f);
        }
    }
}