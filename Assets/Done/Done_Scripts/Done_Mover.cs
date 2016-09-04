using UnityEngine;
using System.Collections;

public class Done_Mover : MonoBehaviour
{
    //기본 움직임 속도 맞추기
    
	public float speed;

	void Start ()
	{
		GetComponent<Rigidbody>().velocity = transform.forward * speed;
	}

 /*   void start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -1) * speed;
    }*/
}
