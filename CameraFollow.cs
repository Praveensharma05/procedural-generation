using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // Assign Player in the Inspector
    public Vector3 offset = new Vector3(0, 5, -10);
    public float smoothSpeed = 5f;

    void LateUpdate()  // Use LateUpdate instead of Update
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.LookAt(target);
    }
}
