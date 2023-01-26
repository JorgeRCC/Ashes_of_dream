using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour
{

   public void Reiniciar()
   {
    SceneManager.LoadScene(1);
   }

   public void MenuInicial(string nombre)
   {
    SceneManager.LoadScene(nombre);
   }
   
    public void Salir()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
