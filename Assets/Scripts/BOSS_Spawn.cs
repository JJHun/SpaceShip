using UnityEngine;
using System.Collections;

public class BOSS_Spawn : MonoBehaviour {
    public GameObject player;
    GameObject GameControll;
    public GameObject BOSS;


    bool spawn = true;
    void Start()
    {
        GameControll = GameObject.Find("GameController_Proto");
    }
    // Update is called once per frame
    void FixedUpdate () {
        
	    if(GameObject.Find("GameController_Proto").GetComponent<GameController_Proto>().score >= 100)
        {
       
        //Vector3 spawnPosition = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.z + 10);
                if (spawn)
                {

                Vector3 spawnSite = new Vector3(player.transform.position.x, 0, player.transform.position.z + 50);
                    Instantiate(BOSS, spawnSite, Quaternion.Euler(new Vector3(0, Random.Range(-45, 45), 0)));
                    spawn = false;
                GameControll.GetComponent<GameController_Proto>().UpdateLife();
                }
         }

    }
}

