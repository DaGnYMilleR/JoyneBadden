using UnityEngine;

namespace Camera
{
    public class CameraFollow2D : MonoBehaviour
    {

        [SerializeField] private Transform target;
        [SerializeField] private float cameraSpeed;
    
        void Update()
        {
            var newPos = Vector3.Lerp(transform.position, target.position, cameraSpeed * Time.deltaTime);
            newPos.z = -10;
            transform.position = newPos;
        }
    }
}