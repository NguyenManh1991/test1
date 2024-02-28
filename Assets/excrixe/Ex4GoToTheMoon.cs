using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEditor;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Ex4GoToTheMoon : MonoBehaviour
{
    protected Vector3 worldPosition;
    private Coroutine axn;
    private float t = 2f;
    [SerializeField] private float Timer;
    Queue<Vector2> positionQueue = new Queue<Vector2>();
    public GameObject minion;

    private void Awake()
    {
        GameObject minions = Instantiate(minion);
        minions.transform.position = transform.position;
        //StartCoroutine(Dc());
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            worldPosition.z = 0;
            positionQueue.Enqueue(worldPosition);


        }

        if (Timer > 0 && Timer < t ||positionQueue.Count==0) return;

        var position = positionQueue.Dequeue();

        //StopAllCoroutines();
        if (axn != null)
            StopCoroutine(axn);
        axn = StartCoroutine(Dc(position));
    }

    IEnumerator Dc(Vector2 position)
    {

        Timer = 0;
        var tempPosition = transform.position;
        while (Timer <= t)
        {


            Timer += Time.deltaTime;
            Vector3 pos = Vector3.Lerp(tempPosition, position, Timer / t);
            this.transform.position = pos;
            yield return null;
        }
        //yield return new WaitForSeconds(3f);
        //while(true)
        //{
        //    GameObject minions= Instantiate(minion);
        //    minions.transform.position = transform.position;
        //}

    }
}
