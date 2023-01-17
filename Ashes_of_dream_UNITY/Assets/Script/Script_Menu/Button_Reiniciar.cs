using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Reiniciar : MonoBehaviour
{
    public void EscenaReiniciar()
    {
        SceneManager.LoadScene("Nive_02_prueba");

    }

}