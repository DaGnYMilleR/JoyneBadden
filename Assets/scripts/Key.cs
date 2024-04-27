using UnityEngine;

public class Key : MonoBehaviour
{
    private static bool isInteractable = false; 
    
    private void Start()
    {
        if (!isInteractable)
            gameObject.SetActive(false);
    }

    public void ShowKey()
    {
        isInteractable = true;
        gameObject.SetActive(true);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && Input.GetKey(KeyCode.E) && isInteractable)
        {
            other.GetComponent<player>().hasKey = true;
            Destroy(gameObject);
        }
    }
}
