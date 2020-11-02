using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeStart = 20;
    public Text timerText;
    private bool isStarting = false;
    
    public void StartTimer()
    {
        timerText.text = timeStart.ToString();
        isStarting = true;
    }

    
    void Update()
    {
        if (isStarting)
        {
            timeStart -= Time.deltaTime;
            timerText.text = Mathf.Round(timeStart).ToString();
        }        
    }
    public bool EndTimer()
    {
        if(timeStart == 0)
        {
            isStarting = false;
        }
        return isStarting;
    }
}
