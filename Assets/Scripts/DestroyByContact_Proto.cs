using UnityEngine;
using System.Collections;

public class DestroyByContact_Proto : MonoBehaviour {

    public GameObject explosion;
    public GameObject playerExplosion;

    GameObject GameController;
	void Start () {
        GameController = GameObject.Find("GameController_Proto");
	}

	void OnTriggerEnter(Collider other)
    {
    
        if(other.gameObject.tag == "Enemy")
        {
            return;
        }
        
        if (explosion != null)
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }
       
        if(other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
           GameController.GetComponent<GameController_Proto>().GameOver();
        }


        GameController.GetComponent<GameController_Proto>().AddScore(10);
        Destroy(gameObject);
        Destroy(other.gameObject);

    }

}
