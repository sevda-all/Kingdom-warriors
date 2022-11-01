using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHealAndMana : MonoBehaviour
{
    
    public float healAmount = 10f;
    public float manaAmount = 20f;

    
    public void Heal() {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>().HealPlayer(healAmount);
    }
    
    public void Mana() {
        GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMovement>().ManaPlayer(manaAmount);
    }
}
