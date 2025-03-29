using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    [System.Obsolete]
    void FixedUpdate()
    {
        rb.velocity = new Vector3(0, rb.velocity.y, speed);
    }
}
