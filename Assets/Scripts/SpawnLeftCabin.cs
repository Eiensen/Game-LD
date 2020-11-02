using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLeftCabin : MonoBehaviour
{
    public Transform[] spawnTransforms;
    private Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = FindObjectOfType<Timer>();
        timer.timeStart = 180;
        timer.StartTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (!timer.EndTimer())
        {

        }
    }
}
