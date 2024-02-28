using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] private float timer;
    public GameObject Person;
    [SerializeField] private float speed;
    void Start()
    {
        StartCoroutine(GoTo());
    }

    IEnumerator GoTo()
    {
        float t = 3f;
        while(timer<=t)
        {
            timer += Time.deltaTime;
            transform.position += Vector3.left * speed * Time.deltaTime; //* timer / t;
            Debug.Log(timer);
            yield return null;
            
        }
        yield return new WaitForSeconds(5);
        float t1 = 6f;
        while (timer <= t1)
        {
            timer += Time.deltaTime;
            transform.position += Vector3.up * speed * Time.deltaTime * timer / t1;
            yield return null;  
        }

        
    }
}
