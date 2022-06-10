using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{
    public Text text;
    int count;
    int intialCount;
    void FixedUpdate()
    {
        string[] parts = text.text.Split(' ');
        count = int.Parse(parts[1]);
        if (5 * count > 150)
        {
            text.text = "Sucess!";
            StartCoroutine(changeScene());
        }
        //destroyExplosions(explosions);
    }
    void destroyExplosions(GameObject [] explosions)
    {
        for(int i = 0; i < explosions.Length; i++)
        {
            StartCoroutine(destroy(explosions[i]));
        }
    }
    IEnumerator changeScene()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(2);
    }
    IEnumerator destroy(GameObject explosion)
    {
        yield return new WaitForSeconds(2);
        Destroy(explosion);
    }
}
