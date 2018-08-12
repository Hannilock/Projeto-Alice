using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportIt : MonoBehaviour
{

    [SerializeField] private string newLevel;
    public Vector3 position; 

    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(newLevel);
            transform.position = position;
        }
    }
}
