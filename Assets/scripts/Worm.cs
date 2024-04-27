using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Worm : MonoBehaviour
{
    private Key key;
    
    private void Start()
    {
        key = FindObjectOfType<Key>(true);
    }

    [SerializeField] private Text text;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            text.text = "E - взаимодействовать";
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene("shall");
            key.ShowKey();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            text.text = string.Empty;
    }
}
