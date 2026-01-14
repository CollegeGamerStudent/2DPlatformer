using UnityEngine;

public class InfiniteGround : MonoBehaviour
{
    public float groundWidth;
    public Transform cameraTransform;

    void Start()
    {
        // Auto-detect ground width if not set
        if (groundWidth == 0)
        {
            groundWidth = GetComponent<SpriteRenderer>().bounds.size.x;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        RepositionGround(); Debug.Log("repositioning ground");
    }
    void RepositionGround()
    {
        Vector3 newPosition = transform.position;
        newPosition.x += groundWidth * 2; // number of tiles in scene
        transform.position = newPosition;
    }
}
