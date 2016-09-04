using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;

public class Rank : MonoBehaviour {

    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;

    static Text textContent1;
    static Text textContent2;
    static Text textContent3;
    static Text textContent4;


    // Use this for initialization
    void Start () {
        textContent1 = text1;
        textContent2 = text2;
        textContent3 = text3;
        textContent4 = text4;

        Parse();
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnBackButton();
        }
    }

    
    string strPath = "Assets/Resources/";

    public void Parse()  // 10칸 , 41, 21 , 5
    {
        TextAsset data = Resources.Load("Data", typeof(TextAsset)) as TextAsset;
        StringReader sr = new StringReader(data.text);

        // 한 줄 읽기
        string source = sr.ReadLine();
        string[] values;
        
        while( source != null)
        {
            values = source.Split('\t');   // values[0] , [1] ...
            if( values.Length == 0)
            {
                sr.Close();
                return;
            }
            
            // text 에 저장
            textContent1.text += values[0]+"\n";
            //textContent2.text += values[1];
            textContent2.text += System.DateTime.Now + "\n";
            textContent3.text += values[2]+"\n";     
            textContent4.text += values[3]+"\n";

            source = sr.ReadLine();
        }
    }

    public void OnBackButton()
    {
        SoundManager.MenuSound();
        SceneManager.LoadScene("MainMenu");
    }
}
