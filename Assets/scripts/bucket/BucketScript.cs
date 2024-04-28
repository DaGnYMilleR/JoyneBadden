using UnityEngine;

public class BucketScript : MonoBehaviour
{
    private float _damping = 10;
    void Start()
    {
    }

    void Update()
    {
    }

    public void Move(Vector3 target)
    {
        var i = 0f;
        while (i < 1.0) {
            i += Time.deltaTime * _damping;
            transform.position = Vector3.Lerp(transform.position, target, i);
        }
    }

    public void MoveParabolic(Vector3 target)
    {
        var i = 0f;
        while (i < 1.0) {
            i += Time.deltaTime * _damping;
            transform.position = Vector3.Slerp(transform.position, target, i);
        }
    }
}