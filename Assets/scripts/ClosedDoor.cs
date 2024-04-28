using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    [SerializeField] private Text helpMessage;
    [SerializeField] private GameObject csb;
    public AudioSource _as;
    public AudioClip audio;

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
            _as.clip = audio;
            _as.Play();
            csb.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            helpMessage.text = string.Empty;
    }
}
