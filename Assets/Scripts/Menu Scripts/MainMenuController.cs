using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public GameObject buttonPanel, charSelectPanel, createCharacterPanel, optionsPanel, storePanel;

    private MainMenuCamera mainMenuCamera;

    void Awake()
    {
        mainMenuCamera = Camera.main.GetComponent<MainMenuCamera>();
    }

    public void PlayGame()
    {
        mainMenuCamera.ChangePosition (1);
        buttonPanel.SetActive(false);
        charSelectPanel.SetActive(true);
    }

    public void BackToMainMenu(){
        mainMenuCamera.ChangePosition (0);
        buttonPanel.SetActive(true);
        charSelectPanel.SetActive(false);
    }

    public void StartGame() {
        SceneLoader.instance.LoadLevel("Village");
    }

    public void CreateCharacter() {
        charSelectPanel.SetActive(false);
        createCharacterPanel.SetActive(true);
    }

    public void Accept(){
        // charSelectPanel.SetActive(true);
        // createCharacterPanel.SetActive(false);
    }
    
    public void Cancel(){
        charSelectPanel.SetActive(true);
        createCharacterPanel.SetActive(false);
    }

    public void OptionsPanel() {
        optionsPanel.SetActive(true);
        buttonPanel.SetActive(false);
    }

    public void CancelOptionsPanel() {
        optionsPanel.SetActive(false);
        buttonPanel.SetActive(true);
    }

    public void StorePanel() {
        storePanel.SetActive(true);
        buttonPanel.SetActive(false);
    }

    public void CancelStorePanel() {
        storePanel.SetActive(false);
        buttonPanel.SetActive(true);
    }

    public void SetQualityLevel() {
        ChangeQuality();
    }

    public void SetResolution(){
        ChangeResolution();
    }

    void ChangeQuality() {
        string quality = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        switch (quality) {

            case "Low":
                QualitySettings.SetQualityLevel(0);
                break;

            case "Normal":
                QualitySettings.SetQualityLevel(1);
                break;

            case "High":
                QualitySettings.SetQualityLevel(2);
                break;

            case "Ultra":
                QualitySettings.SetQualityLevel(3);
                break;

            case "No Shadows":
                if (QualitySettings.shadows == ShadowQuality.All) {
                    QualitySettings.shadows = ShadowQuality.Disable;
                } else {
                    QualitySettings.shadows = ShadowQuality.All;
                }
                break;
        }

    }

    void ChangeResolution() {
        string index = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        switch (index) {
            case "0":
                Screen.SetResolution(1152, 648, true);
                break;

            case "1":
                Screen.SetResolution(1280, 720, true);
                break;

            case "2":
                Screen.SetResolution(1360, 768, true);
                break;

            case "3":
                Screen.SetResolution(1920, 1080, true);
                break;
        }
    }

    public void Quit(){
        Application.Quit();
    }

}
