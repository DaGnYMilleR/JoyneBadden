using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenedDoor : MonoBehaviour
{
    [SerializeField] private TMP_Text helpMessage;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            helpMessage.text = "E - покинуть воспоминание";
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
            SceneManager.LoadScene("ShellGame");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            helpMessage.text = string.Empty;
    }
}
