using UnityEngine;
using UnityEngine.SceneManagement;

public class GovnoScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
            SceneManager.LoadScene("Vzrosliy");
    }
}
