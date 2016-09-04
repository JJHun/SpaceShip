
//UI 조이스틱 스크립트

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SS_JoyStickMN : MonoBehaviour {

    // 조이스틱 오브젝트 정의
    public GameObject _joyStickObj;
    public GameObject _joyStickObjBg; // 배경 판을 이용하여, 최초 터치 인식
    private BoxCollider _collider;
    private Vector3 _iniPos;


    // 조이스틱 사용여부 체크
    private bool _followObj;
    private int _touchInt;// 현재 터치 순서
    static public int _touchIntSave; // 터치 순서 저장

    // 플레이어 조종시
    public GameObject _targetObj; // 타겟이 존재할때
    public float _speed; // 타겟의 이동속력
    private Vector3 _diretionVec; // 타겟의 이동 방향 벡터


	// Use this for initialization
	void Start () {

        // 조이스틱 콜라이더 저장
        if (_joyStickObj != null) _collider = _joyStickObjBg.GetComponent<BoxCollider>();
        _iniPos = _joyStickObj.transform.localPosition; //최초 위치 저장
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.touchCount > 0)
        {
            //조이스틱 움직임이 발생하고 있지 않을때, 발동
            if (!_followObj)
            {
                // 현재 1점 터치인지, 2점 터치인지를 체크
                if (Input.touchCount == 1)
                {
                    _touchInt = 0;   
                }
                else if (Input.touchCount > 1)
                {
                    _touchInt = 1;
                }
                _touchIntSave = _touchInt;

                // 터치가 시작할때, 충돌체크
                if (Input.GetTouch(_touchInt).phase == TouchPhase.Began)
                {
                    RaycastHit hit;
                    Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(_touchInt).position);
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.collider == _collider)
                        {
                            _followObj = true; // 조이스틱 이동 시작
                        }
                    }
                }
            }
            else // 조이스틱 이동이 시작되었을때
            {
                // 중간에 다른 버튼을 눌렀을때, 터치 카운트 조정 코드
                if (Input.touchCount == 1)
                {
                    _touchInt = 0;
                }
                else if (Input.touchCount == 2)
                {
                    _touchInt = _touchIntSave;
                }
                
                // 조이스틱 터치좌표로 이동 코드
                _joyStickObj.transform.localPosition = new Vector3(Input.GetTouch(_touchInt).position.x, Input.GetTouch(_touchInt).position.y, _iniPos.z);

                // 타겟 움직임 관련
                // 방햑벡터 생성, 초기 조이스틱 좌표로 보간을 한다.
                _diretionVec = (new Vector3(Input.GetTouch(_touchInt).position.x - _iniPos.x, 0, Input.GetTouch(_touchInt).position.y - _iniPos.y)).normalized;

                // 타겟이 존재할때, 타겟움직임
                if (_targetObj != null)
                {
                    _targetObj.transform.localPosition += _diretionVec * Time.deltaTime * _speed;
                }
            }

            //조이스틱 컨트롤이 끝났을때, 초기화 관련
            if (Input.GetTouch(_touchInt).phase == TouchPhase.Ended && _followObj)
            {
                _joyStickObj.transform.localPosition = _iniPos;
                _followObj = false;
            }
        }

        
	}
}
