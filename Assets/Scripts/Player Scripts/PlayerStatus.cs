using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour
{

    public GameObject[] playerSwords;

    private GameObject menuPanel;
    private GameObject itemsPanel;
    private GameObject skillPanel;
    private GameObject questsPanel;

    public static bool GameIsPaused = false;


    void Start()
    {
        GameObject[] btns = GameObject.FindGameObjectsWithTag ("Sword");
        foreach (GameObject btn in btns)
        {
            btn.GetComponent<Button>().onClick.AddListener (ChangeSword);
        }

        menuPanel = GameObject.Find ("Menu Panel");
        menuPanel.SetActive(false);

        itemsPanel = GameObject.Find ("Items Panel");
        itemsPanel.SetActive(false);

        skillPanel = GameObject.Find ("Skill Panel");
        skillPanel.SetActive(false);

        questsPanel = GameObject.Find ("Quests Panel");
        questsPanel.SetActive(false);

        GameObject.Find ("Menu").GetComponent<Button>().onClick.AddListener(ActivateMenuPanel);
        GameObject.Find ("Item").GetComponent<Button>().onClick.AddListener(ActivateItemsPanel);
        GameObject.Find ("Skill").GetComponent<Button>().onClick.AddListener(ActivateSkillPanel);
        GameObject.Find ("Quests").GetComponent<Button>().onClick.AddListener(ActivateQuestsPanel);
    }

    public void ActivateMenuPanel()
    {
        if(menuPanel.activeInHierarchy) {
            menuPanel.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false; 
        } else {
            menuPanel.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true; 
        }
    }

    public void ActivateItemsPanel()
    {
        if(itemsPanel.activeInHierarchy) {
            itemsPanel.SetActive(false);
        } else {
            itemsPanel.SetActive(true);
        }
    }

    public void ActivateSkillPanel()
    {
        if(skillPanel.activeInHierarchy) {
            skillPanel.SetActive(false);
        } else {
            skillPanel.SetActive(true);
        }
    }

    public void ActivateQuestsPanel()
    {
        if(questsPanel.activeInHierarchy) {
            questsPanel.SetActive(false);
        } else {
            questsPanel.SetActive(true);
        }
    }


    public void ChangeSword() {
        int swordIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

        for(int i = 0; i < playerSwords.Length; i++) {
            playerSwords [i].SetActive(false);
        }

        playerSwords [swordIndex].SetActive(true);
    }
}
