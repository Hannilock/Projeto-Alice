using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseToConfigurations : MonoBehaviour
{

    public GameObject DescSettings;

    void Start()
    {
        DescSettings.SetActive(false);
    }
    void OnMouseOver()
    {
        DescSettings.SetActive(true);
    }

    void OnMouseExit()
    {
        DescSettings.SetActive(false);
    }

    void OnMouseDown()
    {
        SceneManager.LoadScene("SettingsScreen");
    }
}
