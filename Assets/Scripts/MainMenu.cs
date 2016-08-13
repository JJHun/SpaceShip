using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    private int helpEvent = 0;
    private string helpMessage;

    // Use this for initialization
    void Start()
    {
        helpEvent = 0;
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void OnStartButtonClicked()
    {
        SceneStack.prevScene = "MainMenu";
        SceneManager.LoadScene("StageSelection");

    }

    public void OnRankingButtonClicked()
    {

        SceneManager.LoadScene("Ranking");

    }

    public void OnStoreButtonClicked()
    {
        SceneManager.LoadScene("Store");

    }

    public void OnSettingButtonClicked()
    {
        SceneManager.LoadScene("Setting");
       
    }

    public void OnHelpButtonClicked()
    {
        helpEvent = 1;
        helpMessage = "";
    }

    void OnGUI()
    {
        
    }

}
