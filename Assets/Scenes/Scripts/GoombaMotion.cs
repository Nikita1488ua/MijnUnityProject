using UnityEngine;

public class GoombaMotion : MonoBehaviour
{
    public float speed = 3f;
    public float distance = 3.0f;
    private Vector3 startPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Mathf.PingPong(Time.time * speed, distance);
        transform.position = startPosition + new Vector3(offset, 0, 0);
    }
}
