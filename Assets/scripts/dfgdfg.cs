using UnityEngine;
using UnityEngine.SceneManagement;

public class dfgdfg : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
            SceneManager.LoadScene("BabyBaddenRoom");
    }
}
