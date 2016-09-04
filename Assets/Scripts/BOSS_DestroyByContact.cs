using UnityEngine;
using System.Collections;

public class BOSS_DestroyByContact : MonoBehaviour
{

    public GameObject explosion;
    public GameObject playerExplosion;


    GameObject GameController;
    void Start()
    {
        GameController = GameObject.Find("GameController_Proto");
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Enemy")
        {
            return;
        }

        if (explosion != null)
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }

        if (other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            GameController.GetComponent<GameController_Proto>().GameOver();
        }
        GameController.GetComponent<GameController_Proto>().UpdateLife();

        if (GameController.GetComponent<GameController_Proto>().Life <= 0)
        {
            GameController.GetComponent<GameController_Proto>().AddScore(500);
            GameController.GetComponent<GameController_Proto>().BOSSLife.text = "STAGE CLEAR";
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

    }

}
