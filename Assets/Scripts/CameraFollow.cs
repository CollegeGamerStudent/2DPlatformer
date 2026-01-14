using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 5f;

    private Vector3 offset;

    void Start()
    {
        // Calculate offset once, based on starting positions
        offset = transform.position - player.position;
    }

    void LateUpdate()
    {
        Vector3 targetPosition = new Vector3(
            player.position.x + offset.x,
            transform.position.y,
            transform.position.z
        );

        transform.position = Vector3.Lerp(
            transform.position,
            targetPosition,
            smoothSpeed * Time.deltaTime
        );
    }
}
