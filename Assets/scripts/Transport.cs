using UnityEngine;
using UnityEngine.SceneManagement;

public class Transport : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
            SceneManager.LoadScene("BabyBaddenRoom");
    }
}
