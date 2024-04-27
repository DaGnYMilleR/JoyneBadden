using UnityEngine;
using UnityEngine.SceneManagement;

public class Worm : MonoBehaviour
{
    private Key key;
    
    private void Start()
    {
        key = FindObjectOfType<Key>(true);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene("ShellGame");
            key.ShowKey();
        }
    }
}
