using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", 2f);  
    }

    // Update is called once per frame
    private void Destroy()
    {
      Destroy(gameObject);
    }
}
