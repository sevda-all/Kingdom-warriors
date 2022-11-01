using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayController : MonoBehaviour
{
    public GameObject zombie;

    void Start()
    {
        
    }

    public void LoadOtherWorlds(){
        string name = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        SceneLoader.instance.LoadLevel (name);
    }

    public void LoadZombieWorld(){
        zombie.SetActive(true);
    }
}
