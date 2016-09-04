
//UI 오브젝트 배치 정렬 스크립트


using UnityEngine;
using System.Collections;

// 정렬 타입 선언
public enum AnchorType
{
    None = 0, // 없음
    Center, // 정가운데
    CenterTop, //가운데 위
    CenterBottom, // 가운데하단
    Left, // 왼쪽
    LefTop, // 왼쪽 위
    LeftBottom, // 좌측하단
    Right, // 오른쪽
    RightTop, // 오른쪽 위
    RightBottom, // 우측하단
}

[ExecuteInEditMode]
public class SS_AnchorPointMN : MonoBehaviour
{
    // 정렬 타입 선언
    public AnchorType _anchorPointType;

    // 해상도값 가져오기
    private float ScreenWidthHalf;
    private float ScreenHeightHalf;


    // Update is called once per frame
    void Update()
    {
        ScreenWidthHalf = Screen.width * 0.5f; // 가로 해상도
        ScreenHeightHalf = Screen.height * 0.5f;// 세로 해상도

        // 해상도에 따른 정렬구문
        switch (_anchorPointType)
        {
            case AnchorType.RightBottom:
                transform.localPosition = new Vector3(ScreenWidthHalf, -ScreenHeightHalf, 0);
                break;

            case AnchorType.LeftBottom:
                transform.localPosition = new Vector3(-ScreenWidthHalf, -ScreenHeightHalf, 0);
                break;

            case AnchorType.CenterBottom:
                transform.localPosition = new Vector3(0, -ScreenHeightHalf, 0);
                break;

            case AnchorType.Center:
                transform.localPosition = new Vector3(0, 0, 0);
                break;

            case AnchorType.Left:
                transform.localPosition = new Vector3(-ScreenWidthHalf, 0, 0);
                break;

            case AnchorType.LefTop:
                transform.localPosition = new Vector3(-ScreenWidthHalf, ScreenHeightHalf, 0);
                break;
            case AnchorType.CenterTop:
                transform.localPosition = new Vector3(0, ScreenHeightHalf, 0);
                break;
            case AnchorType.RightTop:
                transform.localPosition = new Vector3(ScreenWidthHalf, ScreenHeightHalf, 0);
                break;
            case AnchorType.Right:
                transform.localPosition = new Vector3(ScreenWidthHalf, 0, 0);
                break;
        }
    }
}
