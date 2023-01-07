using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Reiniciar : MonoBehaviour
{
    public void EscenaReiniciar()
    {
        SceneManager.LoadScene("Nivel_01");

    }

}