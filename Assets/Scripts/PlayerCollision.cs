using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public GatheringMetalls gathering_script;
    public GameObject pickingUp;
    public Animator animatorText;

   

    private void OnCollisionEnter2D(Collision2D collision)
    {

       
        if (collision.collider.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
        if (collision.collider.tag == "Metall_Iron")
        {
            Destroy(collision.gameObject);
            StartCoroutine("AnimTextPanel");
            animatorText.SetBool("Start", false);
            pickingUp.SetActive(false);
        }
    }
    IEnumerator AnimTextPanel()
    {
        
        int randCount = Random.Range(1, 4);
        pickingUp.SetActive(true);
        pickingUp.GetComponentInChildren<Text>().text = "+" + randCount.ToString();
        animatorText.SetBool("Start", true);
        gathering_script.IronCount += randCount;
        yield return new WaitForSeconds(0.5f);

    }
}
