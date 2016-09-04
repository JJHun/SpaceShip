using UnityEngine;
using System.Collections;

public class PlayerCreate : MonoBehaviour {

    static string body;
    static string engine;
    static string weapon;

	// Use this for initialization
	void Start () {
        body = SceneStack.GetBody();
        engine = SceneStack.GetEngine();
        weapon = SceneStack.GetWeapon();

        if ( body == "body1")
        {
            gameObject.transform.FindChild("Fighter").gameObject.SetActive(true);
        }
        else if(body == "body2")
        {
            gameObject.transform.FindChild("Done_Player").gameObject.SetActive(true);
        }

        if( engine == "booster1")
        {
            gameObject.transform.FindChild("EngineTrails1").gameObject.SetActive(true);
        }
        else if( engine == "booster2")
        {
            gameObject.transform.FindChild("EngineTrails2").gameObject.SetActive(true);
        }

    }
	
	// Update is called once per frame
	void Update () {
	    
	}
}
