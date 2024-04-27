using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

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
        //if (other.CompareTag("Player") && Input.GetKey(KeyCode.E))
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            helpMessage.text = string.Empty;
    }
}
