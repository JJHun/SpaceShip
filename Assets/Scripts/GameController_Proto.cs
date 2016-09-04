using UnityEngine;
using System.Collections;

public class GameController_Proto : MonoBehaviour {

    public GameObject[] hazards;
    public Vector3 spawnValues;
    public int hazardCount;


    //플레이어 위치값
    public GameObject player;


    public float startWait = 1;
    public float spawnWait = 0.75f;
    public float waveWait = 2;

    public GUIText scoreText;
    public GUIText restartText;
    public GUIText gameOverText;
    public GUIText BOSSLife;
 //   public GUIText StartMessage;
    private bool gameOver;
    private bool restart;
    public int score;

    public int Life;
    GameObject DestroyByContact_BOSS;
    void Start()
    {
        DestroyByContact_BOSS = GameObject.Find("DestroyByContact_BOSS");
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
        BOSSLife.text = "";
        score = 0;
        Life = 41;
        UpdateScore();
        StartCoroutine(SpawnWaves());

    }


    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }
    void UpdateScore()
    {
        scoreText.text = "Score : " + score;
    }
    public void GameOver()
    {
        gameOverText.text = "Game Over!";
        gameOver = true;
    }

    public void UpdateLife()
    {
        Life -= 1;
        BOSSLife.text = "BOSS Life : " + Life;
    }
   /* public void StartMsg()
    {
        StartMessage.text = "Mission Object : 스코어 1000을 모아  PROBE를 소환해 격파하시오.";
    }*/



    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);

        while (true)
        {
            for (int i = 0; i < hazardCount; ++i)
            {
                //어떤 적 오브젝트를 선택할 것인가 - 랜덤선택
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];

                // 처음 리스폰 포지션 선택
                //Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, player.transform.position.z+10);
                Vector3 spawnPosition = new Vector3(Random.Range(-player.transform.position.x, player.transform.position.x), 0, player.transform.position.z + 30);

                /*Vector3 spawnPosition
                    = new Vector3(Random.Range(-spawnValues.x, spawnValues.x) , 
                                                spawnValues.y , 
                                                player.transform.position.z + Random.Range(-spawnValues.z, spawnValues.z));
                */

                //처음 날라가는 방향 선택
                Quaternion spawnRotation = Quaternion.Euler(new Vector3(0, Random.Range(-45, 45), 0));
                //Quaternion spawnRotation = Quaternion.Euler(new Vector3(0, 0, 0));
                Instantiate(hazard, spawnPosition, spawnRotation);

                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);

            if (gameOver == true)
            {
                restartText.text = "Press 'R' for Restart";
                restart = true;
                break;
            }
        }
    }

    void Update()
    {

        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }


}