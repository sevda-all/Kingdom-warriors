using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100f;

    public GameObject deadFx;
    public GameObject gameOver;

    private Image health_Img;


    void Awake(){
        health_Img = GameObject.Find("Health Foreground").GetComponent<Image>();
        gameOver = GameObject.Find("GameOver Panel");

    }
    
    
    public void TakeDamage(float damageAmount) {
        health -= damageAmount;

        health_Img.fillAmount = health / 100f;

        print ("Player Health " + health );
        
        if (health <= 0) {
            Instantiate (deadFx, transform.position, Quaternion.identity);
            gameOver.SetActive(true);
            // Destroy (gameObject);
            Time.timeScale = 0f;

        }
    }

    public void HealPlayer(float healAmount){
        health += healAmount;

        if(health > 100f)
            health = 100f;

        health_Img.fillAmount = health / 100f;
    }

    
}
