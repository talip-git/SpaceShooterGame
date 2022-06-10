using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemySceneManager : MonoBehaviour
{
    public GameObject [] enemies;
    public GameObject player;
    public Text score;
    public int nextScene;
    void Update()
    {
        if (checkenemies(enemies))
        {
            score.text = "Success!";
            StartCoroutine(changeScene());
        }
        if(player == null)
        {
            StartCoroutine(die());
        }
    }
    bool checkenemies(GameObject [] enemies)
    {
        foreach(var i in enemies)
        {
            if(i != null)
            {
                return false;
            }
        }
        return true;
    }
    IEnumerator changeScene()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(nextScene);
    }
    IEnumerator die()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);
    }
}
