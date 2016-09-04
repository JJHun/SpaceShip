using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DispMsg : MonoBehaviour {

    public Text textName1;
    public Text textName2;
    public Text textName3;

    public static Text textContent1;
    public static Text textContent2;
    public static Text textContent3;

    void Start()
    {
        textContent1 = textName1;
        textContent2 = textName2;
        textContent3 = textName3;
    }

    public static void dispMessage( string msg)

    {
        // 우주선 기체
        if (msg == "body1")
        {
            textContent1.text = "Body\n기본 우주선. HP : 5";   
        }
        else if (msg == "body2")
        {
            textContent1.text = "Body\n강화 우주선. HP : 15";
        }

        // 우주선 엔진
        else if (msg == "booster1")
        {
            textContent2.text = "Engine\n기본 엔진. SPEED : 2";
        }
        else if (msg == "booster2")
        {
            textContent2.text = "Engine\n강화 엔진. SPEED : 2.5";
        }

        // 우주선 무기
        else if (msg == "weapon1")
        {
            textContent3.text = "Weapon\n기본형. dmg : 1";
        }
        else if ( msg == "weapon2")
        {
            textContent3.text = "Weapon\n폭발형. dmg : 2 , range : 2.5";
        }
        else if (msg == "weapon3")
        {
            textContent3.text = "Weapon\n냉기형. dmg : 1.5 , special : 적 50% 느려짐";
        }
    } // func end
    
}
