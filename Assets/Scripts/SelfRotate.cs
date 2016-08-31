using UnityEngine;
using System.Collections;

public class SelfRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 90 * Time.deltaTime, 0);
	}
}
