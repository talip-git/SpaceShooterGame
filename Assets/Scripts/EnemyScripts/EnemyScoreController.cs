using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScoreController : MonoBehaviour
{
    private static Text text;
    private Color start = new Color(255f,0,0,255f);
    private Color mid = new Color(255f,138f,138f,255f);
    private Color end = Color.white;
    void Start()
    {
        text = GetComponent<Text>();
        StartCoroutine(colorchange());
    }
    IEnumerator colorchange()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);
            if(text.color == start)
            {
                text.color = mid;
            }
            if(text.color == mid)
            {
                text.color = end;
            }
            else
            {
                text.color = start;
            }
        }
    }
}
