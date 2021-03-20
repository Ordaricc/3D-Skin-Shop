using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
            transform.position += Vector3.right * speed;
        else if (Input.GetKeyDown(KeyCode.A))
            transform.position += Vector3.left * speed;
    }
}