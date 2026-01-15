using UnityEngine;

public class InfiniteGround : MonoBehaviour
{
    public float groundWidth;
    public Transform cameraTransform;

    void Start()
    {
        if (groundWidth == 0)
            groundWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        float camX = cameraTransform.position.x;

        // ground too far left → move right
        if (transform.position.x < camX - groundWidth)
        {
            transform.position += Vector3.right * groundWidth * 2f;
        }

        // ground too far right → move left
        if (transform.position.x > camX + groundWidth)
        {
            transform.position += Vector3.left * groundWidth * 2f;
        }
    }
}
