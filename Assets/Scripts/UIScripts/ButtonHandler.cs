using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonHandler : MonoBehaviour
{
    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;

   

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    public void changeScene()
    {
        SceneManager.LoadScene("Level1");
    }

    public void SelectLevel1(){
        
        SceneManager.LoadScene("Level1");
    }

     public void SelectLevel2(){
        
        SceneManager.LoadScene("Level2");
    }

     public void SelectLevel3(){
        
        SceneManager.LoadScene("Level3");
    }

      public void SelectLevel4(){
        
        SceneManager.LoadScene("Level4");
    }

     public void SelectEnemyLevel1(){
        
        SceneManager.LoadScene("EnemyLevel1");
    }

     public void SelectEnemyLevel2(){
        
        SceneManager.LoadScene("EnemyLevel2");
    }

    public void NavigateToLevelSelectionScene(){
        SceneManager.LoadScene("LevelSelectionScene");
    }

    public void BackToInitialScene(){
        SceneManager.LoadScene("InıtialScene");
    }
    
}
