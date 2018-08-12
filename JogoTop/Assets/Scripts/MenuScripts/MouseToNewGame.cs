using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseToNewGame : MonoBehaviour {

    public GameObject DescNewGame;

    void Start() {
       DescNewGame.SetActive(false);
    }
    void OnMouseOver() {
       DescNewGame.SetActive(true);
    }

    void OnMouseExit() {
        DescNewGame.SetActive(false);
    }

    void OnMouseDown() {
        SceneManager.LoadScene("Prologue");
    }
}
