using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5.0f;
    public float xPos = 0.0f;
    void Start()
    {
    }

    void Update()
    {
        xPos = transform.position.x;
    }

    public void Launch(Vector3 movement, float speed)
    {
        rb.linearVelocity = new Vector3(0, 0, 0);
        rb.AddForce(movement * speed, ForceMode.Impulse);
    }

    public void Reset()
    {
        transform.position = new Vector3(0, 0, 0);
    }
}
