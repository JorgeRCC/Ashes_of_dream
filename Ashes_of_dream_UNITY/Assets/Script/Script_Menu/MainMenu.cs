using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public Animator animatorMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        LevelLoader.LoadLevel("Nivel_01");
    }
    public void Creditos()
    {
        LevelLoader.LoadLevel("Creditos");
    }
    public void Exit()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }

    public void ShowSettings() 
    {
        animatorMenu.SetBool("showSettings", true);
    }

    public void HideSettings()
    {
        animatorMenu.SetBool("showSettings", false);

    }
}
