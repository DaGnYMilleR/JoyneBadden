using System;
using UnityEngine;
using UnityEngine.UI;

public class SecondDoor : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private GameObject csb;
    public AudioClip audio;
    public AudioSource _as;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            text.text = player.WordlySolved ? "E - вспомнить" : "Узнайте слово";
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && player.WordlySolved && Input.GetKey(KeyCode.E))
        {
            _as.clip = audio;
            _as.Play();
            csb.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            text.text = string.Empty;
        }
    }
}
