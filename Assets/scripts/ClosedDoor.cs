using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    [SerializeField] private Text helpMessage;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            var player = other.GetComponent<player>();
            helpMessage.text = player.hasKey ? "E - покинуть воспоминание" : "Найдите ключ";
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && other.GetComponent<player>().hasKey && Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene("Final");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            helpMessage.text = string.Empty;
    }
}
