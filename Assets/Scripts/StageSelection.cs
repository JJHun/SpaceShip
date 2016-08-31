using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StageSelection : MonoBehaviour {

    private int gameStage; // 미선택
    private string[] nextGameScene;

    public int NumOfGameScene;
    public string GameScene1;
    public string GameScene2;
    public string GameScene3;
    public string GameScene4;
    public string GameScene5;

    public string MainMenu;
    

    // Use this for initialization
    void Start () {
        gameStage = -1;
        nextGameScene = new string[NumOfGameScene+1];

        nextGameScene[1] = GameScene1;
        nextGameScene[2] = GameScene2;
        nextGameScene[3] = GameScene3;
        nextGameScene[4] = GameScene4;
        nextGameScene[5] = GameScene5;

        nextGameScene[0] = MainMenu;


    }

    // Update is called once per frame
    void Update () {

        if (gameStage == 0)
        {
            SceneManager.LoadScene(MainMenu);
        }
        else if( gameStage > 0)
        {
            // Application.LoadLevel(nextGameScene[gameStage]);
           SceneManager.LoadScene("Assemble");
     
        }
        
	}

    void OnGUI()
    {
        for (int i = 0; i <= (NumOfGameScene - 1) / 4; i++)
        {
            for (int j = 0; j < 4 && (i * 4 + j) < NumOfGameScene; j++)
            {
                if (GUI.Button(new Rect((Screen.width / 6) + (j*110), (Screen.height / 3) +(i*110), 100, 100), nextGameScene[i * 4 + j + 1]))
                {
                    gameStage = i * 4 + j + 1;
                    SceneStack.SetNextScene(nextGameScene[gameStage]);
                    SceneStack.SetPrevScene("StageSelection");
                }

            }
        }

        if (GUI.Button(new Rect(Screen.width / 4 * 3, 30, 100, 50), "back"))
        {
            SceneManager.LoadScene(SceneStack.prevScene);
        }
    }
}
