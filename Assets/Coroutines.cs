using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float timer;
    public GameObject Courotine;
    void Start()
    {
        StartCoroutine(OnOff());
    }

    IEnumerator OnOff()
    {
        while (true)
        {
            if (Courotine.activeSelf == true)
            {
                Courotine.SetActive(false);
            }
            else Courotine.SetActive(true);
            yield return new WaitForSeconds(timer);
        }
        
        
    }
}
