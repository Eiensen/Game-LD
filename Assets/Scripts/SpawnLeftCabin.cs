using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLeftCabin : MonoBehaviour
{
    public Transform[] spawnTransforms;
    public GameObject timerObject;
    private Timer timer;
    public GameObject ironPfefab;    

    public GameObject resultMission;
    

   
    private float timeRespawn;
 
    void Start()
    {

        timer = timerObject.GetComponent<Timer>();
        if (!timerObject.activeInHierarchy)
        {
            timerObject.SetActive(true);
        }
        timer.SetTimerTime(20);
        timer.StartTimer();
        StartCoroutine(SpawnIron());
    }


    void FixedUpdate()
    {
        if (timer.IsTimeOut())
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
        Instantiate(ironPfefab, spawnTransforms[Random.Range(0, 5)].position, Quaternion.identity);
        

        Repeat();
    }
   
}
