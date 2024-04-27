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

    public void Move(Vector3 target) => 
        transform.position = Vector3.Lerp(transform.position, target, _damping * Time.deltaTime);

    public void MoveParabolic(Vector3 target) =>
        transform.position = Vector3.Lerp(transform.position, target, _damping * Time.deltaTime);
}