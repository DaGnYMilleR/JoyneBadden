using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && Input.GetKey(KeyCode.E))
        {
            other.GetComponent<player>().hasKey = true;
            Destroy(gameObject);
        }
    }
}
