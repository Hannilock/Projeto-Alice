using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseToExtra : MonoBehaviour
{

    public GameObject DescBonus;

    void Start()
    {
        DescBonus.SetActive(false);
    }
    void OnMouseOver()
    {
        DescBonus.SetActive(true);
    }

    void OnMouseExit()
    {
        DescBonus.SetActive(false);
    }

    void OnMouseDown()
    {
        SceneManager.LoadScene("BonusGallery");
    }
}
