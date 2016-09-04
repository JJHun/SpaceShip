using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    
    // Use this for initialization
    void Start()
    {
        
        

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void OnStartButtonClicked()
    {
        SoundManager.MenuSound();
        SceneStack.prevScene = "MainMenu";
        SceneManager.LoadScene("StageSelection");

    }

    public void OnRankingButtonClicked()
    {
        SoundManager.MenuSound();

        SceneManager.LoadScene("Ranking");

    }

    public void OnSettingButtonClicked()
    {

        SoundManager.MenuSound();

        SceneManager.LoadScene("Setting");
       
    }

    public void OnHelpButtonClicked()
    {
        SoundManager.MenuSound();


        SceneManager.LoadScene("Help");
    }

    public void OnExiteButtonClicked()
    {
        Application.Quit();

    }
}
