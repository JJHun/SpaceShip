
//UI 버튼 오브젝트 스크립트

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SS_Button : MonoBehaviour
{
    //초기 설정
    private BoxCollider _collider;
    private int _touchInt;

    //함수 호출 구문
    public GameObject Target;
    public string FunctionName;

    //버튼 크기 변화 구문
    public bool _buttonScaleUse;
    private bool _buttonScale;
    private float _buttonScaleTimer;
    public float ScaleTimerLim;
    public Vector3 ScaleFactorVec;
    public Vector3 iniScale;

	// Use this for initialization
	void Start () {

        iniScale = transform.localScale; // 초기 크기 저장
        _collider = GetComponent<BoxCollider>(); // 콜라이더 저장
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.touchCount > 0)
        {
            // 조이스틱의 현재 터치 숫자를 가져옴 ; 버그로 보임, 0->1->0 으로 치환시 1로 인식
            if (SS_JoyStickMN._touchIntSave == 1)
            {
                _touchInt = 0;
            }
            else
            {
                // 현재 터치 카운트를 저장
                _touchInt = Input.touchCount - 1;
            }

            // 터치가 발생할때
            if (Input.GetTouch(_touchInt).phase == TouchPhase.Began)
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(_touchInt).position);
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider == _collider)
                    {
                        // 버튼 커짐 효과를 사용할때
                        if(_buttonScaleUse) _buttonScale = true;

                        // 호출하고자 하는 함수가 있을때
                        if (Target != null)
                        {
                            Target.SendMessage(FunctionName, SendMessageOptions.DontRequireReceiver);
                        }
                    }
                }
            }
        }


        // 버튼 스케일 사용시
        if (_buttonScaleUse)
        {
            if (_buttonScale)
            {
                if (_buttonScaleTimer < ScaleTimerLim)
                {
                    _buttonScaleTimer += Time.deltaTime;
                    // 스케일 문구 정의
                    transform.localScale = Vector3.Slerp(transform.localScale, ScaleFactorVec, _buttonScaleTimer / ScaleTimerLim);
                }
                else
                {
                    //초기화
                    transform.localScale = iniScale;
                    _buttonScale = false;
                    _buttonScaleTimer = 0;
                }
            }
        }
	}
}
