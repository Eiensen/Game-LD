using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLeftCabin : MonoBehaviour
{
    public Transform[] spawnTransforms;
    public GameObject timerObject;
    private Timer timer;
    public GameObject[] metallPfefabs;    

    public GameObject resultMission;
    

   
    private float timeRespawn;
 
    void Start()
    {

        timer = timerObject.GetComponent<Timer>();
        if (!timerObject.activeInHierarchy)
        {
            timerObject.SetActive(true);
        }
        timer.SetTimerTime(120);
        timer.StartTimer();
        StartCoroutine(SpawnIron());
    }


    void FixedUpdate()
    {
        if (timer.GetIsTimeOut())
        {
            gameObject.SetActive(false);
        }

    }
    void Repeat()
    {
        StartCoroutine(SpawnIron());
    }

    IEnumerator SpawnIron()
    {
       
        timeRespawn = Random.Range(0.2f, 2f);        
        yield return new WaitForSeconds(timeRespawn);        
        Instantiate(metallPfefabs[Random.Range(0, metallPfefabs.Length)], spawnTransforms[Random.Range(0, 5)].position, Quaternion.identity);
        

        Repeat();
    }
   
}
