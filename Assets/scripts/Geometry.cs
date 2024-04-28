using UnityEngine;

public class Geometry : MonoBehaviour
{
    [SerializeField] private AudioClip geometry;
    public AudioSource _as;
    
    void Start()
    {
        _as.clip = geometry;
        _as.Play();
    }
}
