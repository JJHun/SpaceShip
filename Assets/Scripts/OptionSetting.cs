using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class OptionSetting : MonoBehaviour {

    public Text effectText;
    public Text BGMText;

    // Use this for initialization
    void Start () {
        if (SoundManager.IsOnEffect() == false ) effectText.text = "OFF";
        if (SoundManager.IsOnBGM() == false) BGMText.text = "OFF";

    }

    // Update is called once per frame
    void Update () {
	    
	}

    public void EffectClicked()
    {
        SoundManager.ToggleEffect();
        if (effectText.text == "ON") effectText.text = "OFF";
        else effectText.text = "ON";
    }
    public void BGMClicked()
    {
        SoundManager.ToggleBGM();
        if (BGMText.text == "ON") BGMText.text = "OFF";
        else BGMText.text = "ON";
    }
    public void BackClicked()
    {
        SoundManager.MenuSound();
        SceneManager.LoadScene("MainMenu");
    }
}
