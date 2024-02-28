using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex3Quaternion : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 A;
    public Vector3 B;
    private float timer;
    void Start()
    {
        StartCoroutine(QaTerNion());
    }

    IEnumerator QaTerNion()
    {
        float t = 1f;
        while (timer<=t) {
            timer += Time.deltaTime;
            transform.rotation = Quaternion.Lerp(Quaternion.Euler(A),Quaternion.Euler(B), timer / t);
            yield return null;
        }

    }
}
