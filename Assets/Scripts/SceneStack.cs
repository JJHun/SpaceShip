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

    public static void SetPrevScene(string pScene)
    {
        prevScene = pScene;
    }

    public static void SetNextScene(string nScene)
    {
        nextScene = nScene;
    
    }
    
    public static string GetPrevScene()
    {
        return prevScene;
    }

    public static string GetNextScene()
    {
        return nextScene;
    }

}