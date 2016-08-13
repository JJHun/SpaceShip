using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneStack : MonoBehaviour {

    public static string prevScene;
    public static string nextScene;

    void Awake()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadScene("MainMenu");
    }

    void SetPrevScene(string pScene)
    {
        prevScene = pScene;
    }

    void SetNextScene(string nScene)
    {
        nextScene = nScene;
    
    }
    
    string GetPrevScene()
    {
        return prevScene;
    }

    string GetNextScene()
    {
        return nextScene;
    }

}