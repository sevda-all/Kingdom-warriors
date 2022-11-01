using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
    [SerializeField]
    private GameObject[] characters;

    [HideInInspector]
    public int selectedCharacter;

     void OnTriggerEnter (Collider target) {
        if(target.tag == "Player") {
            print ("teleport");
             
            Vector3 pos = GameObject.FindGameObjectWithTag ("Teleport").transform.position;
            Instantiate (characters[selectedCharacter], pos,  Quaternion.identity);
        }
    }
}
