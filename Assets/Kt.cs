using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Kt : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int number;
    void OnValidate()
    {
        
        if(IsPrime(number))
        {
            Debug.Log("Day la so nt");
        }
        else Debug.Log("Day k phai so nguyen to");
    }

    bool IsPrime( int number)
    {
        if(number <= 1) return false;
        if(number==2) return true;
        for(int i=2;i<=Mathf.Sqrt(number);i++)
        {
            if (number % i == 0)
                return false;

        }
        return true;
    }
}
