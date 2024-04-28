using UnityEngine;

public class BucketScript : MonoBehaviour
{
    private float _damping = 1;
    void Start()
    {
    }

    void Update()
    {
    }

    public bool Move(Vector3 target)
    {
        transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime);

        if (transform.position == target)
            return true;

        return false;
        
        var i = 0f;
        while (i < 1.0) {
            i += Time.deltaTime * _damping;
            transform.position = Vector3.Lerp(transform.position, target, i);
        }
    }

    public void MoveParabolic(Vector3 target)
    {
        //transform.position = Vector3.Slerp(transform.position, target, Time.deltaTime);
        var i = 0f;
        while (i < 1.0) {
            i += Time.deltaTime * _damping;
            transform.position = Vector3.Slerp(transform.position, target, i);
        }
    }
}