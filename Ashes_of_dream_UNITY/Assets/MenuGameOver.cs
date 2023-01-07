using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour
{
    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    public void EscenaMenu()
    {
        SceneManager.LoadScene("Menu_01");
    }

    public void Salir()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}

