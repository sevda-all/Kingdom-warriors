using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCounter : MonoBehaviour
{
    public  static int Enemy;
    Text enemyText;

    void Start()
    {
        enemyText = GetComponent<Text>();   
    }

    void Update()
    {
        enemyText.text =  Enemy.ToString();
    }
}
