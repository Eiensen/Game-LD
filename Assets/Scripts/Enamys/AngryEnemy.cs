using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryEnemy : MonoBehaviour
{
    public GameObject enemy;
    EnemyMovement enemyMovement_scrt;

    private void Start()
    {
        enemyMovement_scrt = enemy.GetComponent<EnemyMovement>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("gooooooo");
        if(collision.gameObject.tag == "Player")
        {
            enemyMovement_scrt.SetIsMoving(true);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("ggggggg");
        if (collision.gameObject.tag == "Player")
        {
            enemyMovement_scrt.SetIsMoving(false);
        }
    }
}
