using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMenu : MonoBehaviour
{
    public GameObject[] characters;
    public GameObject[] icons;
    public GameObject charPosition;

    public GameObject charSelectPanel, createCharacterPanel;


    public InputField inputName;
    public Text charName;

    private int knight_Index = 0;
    private int king_Index = 1;
    private int catGirl_Index = 2;


    void Start()
    {
     characters [knight_Index].SetActive(true);   
     icons [knight_Index].SetActive(true);   
     characters [knight_Index].transform.position = charPosition.transform.position;   
    }

    public void SelectCharacter() 
    {
        int index = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

        TurnOffCharacters();

        characters [index].SetActive(true);   
        icons [index].SetActive(true);   
        characters [index].transform.position = charPosition.transform.position;  

        GameManager.instance.selectedCharacter = index;
    }

    void TurnOffCharacters()
    {
        for(int i = 0; i < characters.Length; i++) {
            characters [i].SetActive(false);
        }

        for(int n = 0; n < icons.Length; n++) {
            icons [n].SetActive(false);
        }
    }

    public void SetName() {
        if (inputName.text == ""){
            Debug.Log("Error");
        }  else {

            charName.text += " " + inputName.text;
            charSelectPanel.SetActive(true);
            createCharacterPanel.SetActive(false);
        }
    }

    public void Remove() {
        charName.text = "Name ";
        TurnOffCharacters();
        characters [knight_Index].SetActive(true);   
        icons [knight_Index].SetActive(true);  
    }

}



