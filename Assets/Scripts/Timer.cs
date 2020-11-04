using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float timeStart;
    public Text timerText;
    private bool isStarting = false;
    public bool IsTimeOut { get; set; } = false;
   
    public UIManager _UIManager;

    private void Start()
    {       
        timerText.text = timeStart.ToString();        
    }
    public void StartTimer()
    {
        isStarting = true;        
    }
    public void SetTimerTime(float value)
    {
        if (value >= 0 && value <= 999)
            timeStart = value;
    }
    
    void Update()
    {
        if (isStarting)
        {
            StartCoroutine(RunTimer());
        }
        if (IsTimeOut)
        {
            _UIManager.joystick.OnPointerUp(null);
            _UIManager.MainUIPanelSetInactive();
            _UIManager.ResultPanelSetActive();
            gameObject.SetActive(false);
        }

    }   
    public bool GetIsTimeOut()
    {
        return IsTimeOut;
    }
    IEnumerator RunTimer()
    {
       if(timeStart > 0)
        {
            timeStart -= Time.deltaTime;
            timerText.text = Mathf.Round(timeStart).ToString();
            yield return new WaitForSeconds(1);
        }
        else
        {
            IsTimeOut = true;
        }
            
    }
}
