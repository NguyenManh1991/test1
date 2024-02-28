using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Ex2Color : MonoBehaviour
{
    // Start is called before the first frame update
    
    private float timer;
    public SpriteShapeRenderer Ast;
        void Start()
    {
        StartCoroutine(ColorR());
    }

    IEnumerator ColorR()
    {
        while (timer<=2)

        {
            timer += Time.deltaTime;
            Ast.color = Color.Lerp(Color.red, Color.green, timer/2);
            yield return null;
            
        }

    }
}
