using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 3;
    private Rigidbody rb;
    private Vector3 direction;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        direction = Vector3.zero;
        if (Input.GetKey(KeyCode.D))
            direction = transform.right;
        else if (Input.GetKey(KeyCode.A))
            direction = -transform.right;
        if (Input.GetKey(KeyCode.W))
            direction += transform.forward;
        else if (Input.GetKey(KeyCode.S))
            direction += -transform.forward;

        direction.y = 0;
        direction.Normalize();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(direction.x * speed, rb.velocity.y, direction.z * speed);
    }
}