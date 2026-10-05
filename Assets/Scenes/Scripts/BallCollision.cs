using UnityEngine;

public class BallCollision : MonoBehaviour
{
    private Renderer objectRenderer;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    void OnCollisionEnter(Collision collision)
    {
        objectRenderer.material.color = Color.blue;
    }
}
