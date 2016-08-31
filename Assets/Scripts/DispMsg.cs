using UnityEngine;
using System.Collections;

public class DispMsg : MonoBehaviour {

    float nextTime = 0;
	
	// Update is called once per frame
	void Update () {
		if(Time.time > nextTime)
        {
            if(lengthMsg1 < dispMsg1.Length)
            {
                lengthMsg1++;
            }
            if (lengthMsg2 < dispMsg2.Length)
            {
                lengthMsg2++;
            }
            if (lengthMsg3 < dispMsg3.Length)
            {
                lengthMsg3++;
            }
            nextTime = Time.time + 0.01f;
        }
    } // update end 

    public static string dispMsg1="";
    public static string dispMsg2="";
    public static string dispMsg3="";
    public static int lengthMsg1;
    public static int lengthMsg2;
    public static int lengthMsg3;
    public static void dispMessage( string msg)

    {
        // 우주선 기체
        if (msg == "body1")
        {
            lengthMsg1 = 0;
            dispMsg1 = "기본 우주선. HP : 5";
        }
        else if (msg == "body2")
        {
            lengthMsg1 = 0;
            dispMsg1 = "강화 우주선. HP : 15";
        }

        // 우주선 엔진
        else if (msg == "booster1")
        {
            lengthMsg2 = 0;
            dispMsg2 = "기본 엔진. SPEED : 2";
        }
        else if (msg == "booster2")
        {
            lengthMsg2 = 0;
            dispMsg2 = "강화 엔진. SPEED : 2.5";
        }

        // 우주선 무기
        else if (msg == "weapon1")
        {
            lengthMsg3 = 0;
            dispMsg3 = "기본형. dmg : 1";
        }
        else if ( msg == "weapon2")
        {
            lengthMsg3 = 0;
            dispMsg3 = "폭발형. dmg : 2 , range : 2.5";
        }
        else if (msg == "weapon3")
        {
            lengthMsg3 = 0;
            dispMsg3 = "냉기형. dmg : 1.5 , special : 적 50% 느려짐";
        }
    } // func end

    public GUIStyle msgWnd;

	void OnGUI()
	{
		// 기준 화면폭
		const float screenWidth = 1136;

		// 기준 크기에 대한 창 크기와 좌표
		const float msgwWidth = 400;
		const float msgwHeight = 400;
		const float msgwPosX = screenWidth / 2;
		const float msgwPosY = 400;

		// 화면 폭으로부터 1픽셀을 계산한다
		float factorSize = Screen.width / screenWidth;

		float msgwX;
		float msgwY;
		float msgwW = msgwWidth * factorSize;
		float msgwH = msgwHeight * factorSize;

        //폰트 스타일
        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = (int)(15 * factorSize);

        //메시지 표시
        msgwX = msgwPosX * factorSize;
        msgwY = msgwPosY * factorSize;
        GUI.Box(new Rect(msgwX, msgwY, msgwW, msgwH), "", msgWnd);

        //메시지 그림자
        myStyle.normal.textColor = Color.black;

        msgwX = (msgwPosX + 22) * factorSize;
        msgwY = (msgwPosY + 22) * factorSize;
        GUI.Label(new Rect(msgwX, msgwY, msgwW, msgwH), dispMsg1.Substring(0, lengthMsg1), myStyle);
        GUI.Label(new Rect(msgwX, msgwY + 120, msgwW, msgwH), dispMsg2.Substring(0, lengthMsg2), myStyle);
        GUI.Label(new Rect(msgwX, msgwY + 240, msgwW, msgwH), dispMsg3.Substring(0, lengthMsg3), myStyle);


        //메시지
        myStyle.normal.textColor = Color.white;

        msgwX = (msgwPosX + 20) * factorSize;
        msgwY = (msgwPosY + 20) * factorSize;
        GUI.Label(new Rect(msgwX, msgwY, msgwW, msgwH), dispMsg1.Substring(0, lengthMsg1), myStyle);
        GUI.Label(new Rect(msgwX, msgwY + 120, msgwW, msgwH), dispMsg2.Substring(0, lengthMsg2), myStyle);
        GUI.Label(new Rect(msgwX, msgwY + 240, msgwW, msgwH), dispMsg3.Substring(0, lengthMsg3), myStyle);

    }


}
