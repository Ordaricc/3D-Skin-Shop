using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 1;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Vector3 direction = Vector3.zero;
        if (Input.GetKey(KeyCode.D))
            direction.x = 1;
        else if (Input.GetKey(KeyCode.A))
            direction.x = -1;
        rb.velocity = new Vector3(direction.x * speed, rb.velocity.y, rb.velocity.z);
    }
}