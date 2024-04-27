using TMPro;
using UnityEngine;

public class ClosedDoor : MonoBehaviour
{
    [SerializeField] private TMP_Text helpMessage;
    [SerializeField] private GameObject openedDoor;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            var player = other.GetComponent<player>();
            helpMessage.text = player.hasKey ? "E - открыть дверь" : "Найдите ключ";
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && other.GetComponent<player>().hasKey && Input.GetKey(KeyCode.E))
        {
            Instantiate(openedDoor, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            helpMessage.text = string.Empty;
    }
}
