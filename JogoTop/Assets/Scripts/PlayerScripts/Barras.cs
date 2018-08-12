using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barras : MonoBehaviour {

    public string nome;
    public int qtd;
    public GameObject barra;

    void OnMouseEnter() {

        Debug.Log(nome + " " + qtd);
        barra.SetActive(true);
    }

    void OnMouseExit() {

        barra.SetActive(false);

    }
}