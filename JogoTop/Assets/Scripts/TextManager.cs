using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager : MonoBehaviour {

    public GameObject Object;
    public GameObject Interface;

    private void FixedUpdate() {
        if (Input.GetKey(KeyCode.X)) {
            Object.SetActive(true);
            Interface.SetActive(true);
            Debug.Log("Este é o armário.");
            
        }

    }
}
