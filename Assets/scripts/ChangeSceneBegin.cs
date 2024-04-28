using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneBegin : MonoBehaviour
{
    public void changeScene()
    {
        SceneManager.LoadScene("AfterBegin");
    }
}
