using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. UI;

public class cubo : MonoBehaviour
{
    public int puntos;
    public Text textoPuntos;

    // Start is called before the first frame update
    void Start()
    {
        puntos=0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider c){
        Debug.Log("Colision tipo trigger");
        puntos++;
        textoPuntos.text=puntos.ToString();
    }
}
