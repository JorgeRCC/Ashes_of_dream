using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour
{
   public void EscenaReiniciar()
    {
        SceneManager.LoadScene("Nivel_01");

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
