using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

/* 1. 이전 Scene, 다음 Scene 정보 저장 ( 씬 전환에 사용 )
 *      변수
 *      string prevScene
 *      string nextScene
 *      함수 
 *      get
 *      set
 *      
 * 2. Assemble 씬에서 Game 씬으로 전환할 때 기체 정보 임시 저장
 *      변수
 *      string body
 *      string engine
 *      string weapon
 *      함수
 *      get
 *      set
 *      
 */

public class SceneStack : MonoBehaviour {

    public static string prevScene;
    public static string nextScene;

    static string body;
    static string engine;
    static string weapon;



    void Awake()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadScene("MainMenu");
    }

    // 이전, 다음 씬 저장
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

    // Assemble -> Game 에서 기체 정보 저장
    public static string GetBody()
    {
        return body;
    }
    public static string GetEngine()
    {
        return engine;
    }
    public static string GetWeapon()
    {
        return weapon;
    }
    public static void SetBody(string x)
    {
        body = x;
    }
    public static void SetEngine(string x)
    {
        engine = x;
    }
    public static void SetWeapon(string x)
    {
        weapon = x;
    }


}