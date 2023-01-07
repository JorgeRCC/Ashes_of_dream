using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boton_Play : MonoBehaviour
{
    public void EscenaPlay()
    {
        SceneManager.LoadScene("Nivel_01");

    }

}
