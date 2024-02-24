using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pruevmonedas : MonoBehaviour
{
    public int puntos;
    public Text textoPuntos;

    private void Update()
    {
        textoPuntos.text = puntos.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Moneda"))
        {
            Destroy(other.gameObject);
            puntos++;

        }
    }
}
