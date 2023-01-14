using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notas : MonoBehaviour
{
    public GameObject informacion;
    public GameObject mostrarInformacion;

    public bool informacionHabilitada;
    public bool mostrarInformacionHabilitada;

    public LayerMask personaje;

    // Start is called before the first frame update
    void Start()
    {
        informacion.gameObject.SetActive(false);
        mostrarInformacion.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        informacionHabilitada = Physics2D.OverlapCircle(this.transform.position, 1f, personaje);

        if (informacionHabilitada== true)
        {
            informacion.gameObject.SetActive(true);
        }
        if (informacionHabilitada == false)
        {
            informacion.gameObject.SetActive(false);
        }

        mostrarInformacionHabilitada = Physics2D.OverlapCircle(this.transform.position, 2.5f, personaje);
        if( mostrarInformacionHabilitada == true && Input.GetKeyDown(KeyCode.E))
        {
            mostrarInformacion.gameObject.SetActive(true);
        }
        if (mostrarInformacionHabilitada == false)
        {
            mostrarInformacion.gameObject.SetActive(false);
        }
    }
}
