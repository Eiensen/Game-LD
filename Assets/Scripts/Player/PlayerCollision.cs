using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public GatheringMetalls gathering_script;
    public GameObject pickingUp;
    public Animator animatorText;
    public Timer timer;
   

    private void OnCollisionEnter2D(Collision2D collision)
    {

       
        if (collision.collider.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
        if (collision.collider.tag == "Metall_Coper")
        {
            int randCount = Random.Range(1, 3);
           
            pickingUp.GetComponentInChildren<Text>().text = "+" + randCount.ToString();
            pickingUp.SetActive(true);
            StopAllCoroutines();
            StartCoroutine(PickUpAnim());
           
            gathering_script.IronCount += randCount;
            Destroy(collision.gameObject);            
        }
        if(collision.collider.tag == "Metall_Iron")
        {
            Destroy(collision.gameObject);
            timer.IsTimeOut = true;
        }
    }
    IEnumerator PickUpAnim()
    {
        animatorText.SetBool("Start", true);
        yield return new WaitForSeconds(0.5f);
        animatorText.SetBool("Start", false);
        pickingUp.SetActive(false);
    }
}
