using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Assemble : MonoBehaviour {

    static GameObject[] body;
    static GameObject[] booster;

    static GameObject body1;
    static GameObject body2;
    static GameObject booster1;
    static GameObject booster2;
    
    static string boo;
    static string bod;
    static string wea;
    static bool ready;


	// Use this for initialization
	void Start () {
        body = new GameObject[2];
        booster = new GameObject[2];

        body[0] = body1;
        body[1] = body2;
        booster[0] = booster1;
        booster[1] = booster2;
        
        bod = "";
        boo = "";
        wea = "";

        ready = false;

        body1 = GameObject.Find("Fighter");
        body2 = GameObject.Find("Done_Player");
        booster1 = GameObject.Find("EngineTrails1");
        booster2 = GameObject.Find("EngineTrails2");

        body1.SetActive(false);
        body2.SetActive(false);
        booster1.SetActive(false);
        booster2.SetActive(false);


    }

    // Update is called once per frame
    void Update () {
     
        if ( bod != "" && boo != "" && wea != "")
        {
            ready = true;
        }
	}

    public static void SetComponent(string component)
    {
        if(component == "body1")
        {
            if( bod != "body1")
            {
                // 기존 body 삭제
                body2.SetActive(false);
                bod = "body1";
                body1.SetActive(true);
                // 현재 body 생성
            }
        }
        else if (component == "body2")
        {
            body1.SetActive(false);
            bod = "body2";
            body2.SetActive(true);
        }
        else if (component == "booster1")
        {
            booster2.SetActive(false);
            boo = "booster1";
            booster1.SetActive(true);
        }
        else if (component == "booster2")
        {
            booster1.SetActive(false);
            boo = "booster2";
            booster2.SetActive(true);
        }
        else if (component == "weapon1")
        {
            wea = "weapon1";
        }
        else if (component == "weapon2")
        {
            wea = "weapon2";
        }
        else if (component == "weapon3")
        {
            wea = "weapon3";
        }
    }

    public void OnGameStartButton()
    {
        if( ready == true)
        {
            SceneManager.LoadScene(SceneStack.GetNextScene());
        }
    }

    public void OnBackButton()
    {
        SceneManager.LoadScene(SceneStack.GetPrevScene());
    }

}
