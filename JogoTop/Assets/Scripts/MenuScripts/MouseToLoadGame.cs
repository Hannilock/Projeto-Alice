using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseToLoadGame : MonoBehaviour
{

    public GameObject DescLoadGame;

    void Start() {

        DescLoadGame.SetActive(false);
    }
    void OnMouseOver() {

        DescLoadGame.SetActive(true);
    }

    void OnMouseExit() {

        DescLoadGame.SetActive(false);
    }

    void OnMouseDown() {

        SceneManager.LoadScene("Load");
        
        
    }
}
