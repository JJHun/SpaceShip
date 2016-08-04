using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void OnStartButtonClicked()
    {
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
        SceneManager.LoadScene("Help");

    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
