using UnityEngine;
using System.Collections;

public class RandomRotate : MonoBehaviour {

    float tumble = 5;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
