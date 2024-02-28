using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Go : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float timer;
    public GameObject motobike;
    private float t=0;
    public GameObject a;
    public GameObject b;
    void Start()
    {
        StartCoroutine(walk());
    }

    IEnumerator walk()
    {
       while(t<=timer) {
            t += Time.deltaTime;
            motobike.transform.position = Vector3.Lerp(a.transform.position, b.transform.position, t/timer);
            yield return null;
        }
    }
    
}
