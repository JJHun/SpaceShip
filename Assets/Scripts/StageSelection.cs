using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageSelection : MonoBehaviour {

    public string map1;
    public string map2;
    public string map3;
    public string map4;
    public string map5;

    string selectedmap = "";

    public Text text;
    public static Text textContent;

    void Start()
    {
        textContent = text;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Back();
        }

        DispInform();
    }

    public void Map1()
    {
        SoundManager.ButtonSound();
        selectedmap = map1;
    }
    public void Map2()
    {
        SoundManager.ButtonSound();
        selectedmap = map2;
    }
    public void Map3()
    {
        SoundManager.ButtonSound();
        selectedmap = map3;
    }
    public void Map4()
    {
        SoundManager.ButtonSound();
        selectedmap = map4;
    }
    public void Map5()
    {
        SoundManager.ButtonSound();
        selectedmap = map5;
       
    }

    public void Back()
    {
        SoundManager.MenuSound();
        SceneManager.LoadScene("MainMenu");
    }

    public void Next()
    {
        if (selectedmap != "")
        {
            SoundManager.MenuSound();
            SceneStack.SetNextScene(selectedmap);
            SceneStack.SetPrevScene("StageSelection");
            SceneManager.LoadScene("Assemble");
        }
    }

    void DispInform()
    {
        if (selectedmap == map1)
            textContent.text = "1번맵";
        else if (selectedmap == map2)
            textContent.text = "2번맵";
        else if (selectedmap == map3)
            textContent.text = "3번맵";
        else if (selectedmap == map4)
            textContent.text = "4번맵";
        else if (selectedmap == map5)
            textContent.text = "5번맵";
    }
}
