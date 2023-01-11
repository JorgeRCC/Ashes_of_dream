using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mov_character_001 : MonoBehaviour
{
    public float velocidadMovimiento;
    private Rigidbody2D fisica;
    public float fuerzaSalto = 4.5f;

    int trampasLayer;
    // Start is called before the first frame update
    void Start()
    {
        fisica = GetComponent<Rigidbody2D>();

        trampasLayer = LayerMask.NameToLayer("Trampas");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == trampasLayer)
        {
            //Matar al jugador
            SceneManager.LoadScene("GameOver");
            Debug.Log("Muerto");
        }
    }



    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * velocidadMovimiento;
        if (!Mathf.Approximately(0, movement))
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        if (Input.GetButtonDown("Jump") && Mathf.Abs(fisica.velocity.y) < 0.001f) //1 salto
        {
            fisica.AddForce(new Vector2(0, fuerzaSalto), ForceMode2D.Impulse);
        }
    }
}
