using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubo : MonoBehaviour
{
    public int puntos;
    public Text textoPuntos;

    private bool colisionDetectada = false; // Para evitar la detección múltiple de colisiones

    // Start is called before the first frame update
    void Start()
    {
        puntos = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (!colisionDetectada && other.CompareTag("Player"))
        {
            Debug.Log("Colision tipo trigger con moneda");
            puntos++;
            textoPuntos.text = puntos.ToString();
            Destroy(gameObject);
            colisionDetectada = true;
        }
    }
}