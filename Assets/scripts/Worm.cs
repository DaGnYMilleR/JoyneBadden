using UnityEngine;
using UnityEngine.SceneManagement;

public class Worm : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && Input.GetKey(KeyCode.E))
            SceneManager.LoadScene("ShellGame");
    }
}
