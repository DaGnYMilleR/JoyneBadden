using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Worm : MonoBehaviour
{
    [SerializeField] private Text text;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            text.text = "E - взаимодействовать";
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && Input.GetKey(KeyCode.E))
            SceneManager.LoadScene("ShellGame");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            text.text = string.Empty;
    }
}
