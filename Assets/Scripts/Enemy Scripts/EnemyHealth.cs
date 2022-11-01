using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyHealth : MonoBehaviour
{
    public float health = 100f;
    public GameObject deadFx;
    public float healAmount = 10f;



    public void TakeDamage(float damageAmount) {
        health -= damageAmount;
        print ("Enemy Health " + health );

        
        if (health <= 0) {
            Instantiate (deadFx, transform.position, Quaternion.identity);
            EnemyCounter.Enemy += 1;
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>().HealPlayer(healAmount);
            Destroy (gameObject);
            
        }
    }

}

