using UnityEngine;
using System.Collections;

public class BOSS_Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.Rotate(0.0f, 90.0f * Time.deltaTime, 0.0f); 
        /*
        Quaternion newRotation = Quaternion.LookRotation(movement);

        //한번에 회전해버리는 함수 : 순식간에 바뀌어 회전한다는 느낌이 없음
        //rigdbody.MoveRotation(newRotation);
        rigdbody.rotation = Quaternion.Slerp(rigdbody.rotation, newRotation, rotateSpeed * Time.deltaTime);
        */
    }
}
