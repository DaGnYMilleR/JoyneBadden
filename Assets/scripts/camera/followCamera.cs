using UnityEngine;

namespace Camera
{
    public class CameraFollow2D : MonoBehaviour
    {

        [SerializeField] private Transform target;
        [SerializeField] private float cameraSpeed;
    
        void Update()
        {
            transform.position = Vector2.Lerp(transform.position, target.position, cameraSpeed * Time.deltaTime);
        }
    }
}