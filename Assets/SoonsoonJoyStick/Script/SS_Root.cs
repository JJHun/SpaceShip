
//UI 해상도 조정 스크립트

using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class SS_Root : MonoBehaviour
{
    public float _targetHeight;
	
	void Update () 
    {
        transform.localScale = new Vector3(1,1,1) * 2.0f / Screen.height;
	}
}
