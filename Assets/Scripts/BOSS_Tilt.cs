using UnityEngine;
using System.Collections;

public class BOSS_Tilt : MonoBehaviour
{
    public Done_Boundary boundary;
    public float tilt;
    public float dodge;
    public float smoothing;
    public Vector2 startWait;
    public Vector2 maneuverTime;
    public Vector2 maneuverWait;
    int SPEED = 1;
    private float currentSpeed;
    private float targetManeuver;
    GameObject GameController;
    void Start()
    {
        GameController = GameObject.Find("GameController_Proto");
        currentSpeed = GetComponent<Rigidbody>().velocity.z;
        StartCoroutine(Evade());
    }

    IEnumerator Evade()
    {
        yield return new WaitForSeconds(Random.Range(startWait.x, startWait.y));
        while (true)
        {
            targetManeuver = Random.Range(1, dodge) * -Mathf.Sign(transform.position.x);
            yield return new WaitForSeconds(Random.Range(maneuverTime.x, maneuverTime.y));
            targetManeuver = 0;
            yield return new WaitForSeconds(Random.Range(maneuverWait.x, maneuverWait.y));
        }
    }

    void FixedUpdate()
    {
        float newManeuver = Mathf.MoveTowards(GetComponent<Rigidbody>().velocity.x, targetManeuver, smoothing * Time.deltaTime);
        GetComponent<Rigidbody>().velocity = new Vector3(newManeuver, 0.0f, currentSpeed) * SPEED;
        GetComponent<Rigidbody>().position = new Vector3
        (
            Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
        );

        GetComponent<Rigidbody>().rotation = Quaternion.Euler(0, 0, GetComponent<Rigidbody>().velocity.x * -tilt);

        

        switch(GameController.GetComponent<GameController_Proto>().Life)
        {
            case 30:
                SPEED = 3;
                dodge = 100;
                //smoothing = -5;
                break;
            case 20:
                SPEED = 5;
                tilt = 10;
                dodge = 1000;
                //smoothing = -10;
                break;
            case 10:
                SPEED = 10;
                //smoothing = -100;
                break;

        }

    }
}
