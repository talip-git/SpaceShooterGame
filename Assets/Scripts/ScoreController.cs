using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    public static int currentScore;
    public int nextScene;
    public int succesScore;
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score: " + currentScore;
        if (currentScore >= succesScore)
        {
            text.text = "Success!!";
            StartCoroutine(changeScene());
        }
    }
    IEnumerator changeScene()
    {
        yield return new WaitForSeconds(4);
        currentScore = 0;
        SceneManager.LoadScene(nextScene);
    }
}
