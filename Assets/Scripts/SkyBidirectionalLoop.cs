using UnityEngine;

public class SkyBidirectionalLoop : MonoBehaviour
{
    Camera cam;
    const float width = 14.63f;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        float camX = cam.transform.position.x;

        // too far left → move to the right
        if (transform.position.x < camX - width)
        {
            transform.position += Vector3.right * width * 2f;
        }

        // too far right → move to the left
        if (transform.position.x > camX + width)
        {
            transform.position += Vector3.left * width * 2f;
        }
    }
}
