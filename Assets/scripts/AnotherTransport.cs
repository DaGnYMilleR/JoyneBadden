using UnityEngine;
using UnityEngine.SceneManagement;

public class AnotherTransport : MonoBehaviour
{
    public void ChangeScene2()
    {
        SceneManager.LoadScene("FinalScene");
    }
}
