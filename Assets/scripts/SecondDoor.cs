using System;
using UnityEngine;
using UnityEngine.UI;

public class SecondDoor : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private GameObject csb;
    
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