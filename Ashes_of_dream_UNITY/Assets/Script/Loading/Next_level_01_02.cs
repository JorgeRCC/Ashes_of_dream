using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_level_01_02 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        LevelLoader.LoadLevel("Nivel_02");
    }
}
