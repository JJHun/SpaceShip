using UnityEngine;
using System.Collections;

public class BOSS_WeaponController : MonoBehaviour
{
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    public float delay;
    float spawnWait = 0.2f;

    void Start()
    {
        InvokeRepeating("Fire", delay, fireRate);
    }

    void Fire()
    {
        //while (true)
        {
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            GetComponent<AudioSource>().Play();
            //yield return new WaitForSeconds(spawnWait);
                }
    }
    
}
