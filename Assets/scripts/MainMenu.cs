using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
            SceneManager.LoadScene("BaddensSpeaking");
        if (Input.GetKey(KeyCode.Escape))
            Application.Quit();
    }
}
