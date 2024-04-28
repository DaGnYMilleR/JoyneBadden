using UnityEngine;

public class BucketPicker : MonoBehaviour
{
    private UnityEngine.Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<UnityEngine.Camera>();
    }

    // Update is called once per frame

    private void HandleClick(Vector3 screenClickPosition)
    {
        var ray = camera.ScreenPointToRay(screenClickPosition);
        if(Physics.Raycast(ray.origin, ray.direction, out var rayHit)){
            if(rayHit.collider.transform.CompareTag("")){
                gameObject.SetActive(false);
                // reset ray and rayHit for the next click
                ray = new Ray();
                rayHit = new RaycastHit();
            }
        }
    }
}
