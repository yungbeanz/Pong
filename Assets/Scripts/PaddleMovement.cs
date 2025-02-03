using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]
    private string vertInputAxis = "VerticalP1";
    private Vector3 movement;
    private float speed = 5.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        movement = transform.position;
    }


    void Update()
    {
        movement = movement + new Vector3 (0, Input.GetAxisRaw(vertInputAxis) * speed * Time.deltaTime, 0);
        movement.y = Mathf.Clamp(movement.y, -4f, 4f);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(movement);
    }
}
