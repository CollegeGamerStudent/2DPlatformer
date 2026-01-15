using UnityEngine;

public class SkyFollowLoop : MonoBehaviour
{
    Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        // move sky slightly for effect (optional)
        transform.position += Vector3.left * Time.deltaTime;

        // if sky is behind the camera
        if (transform.position.x < cam.transform.position.x - 14.63f)
        {
            transform.position += Vector3.right * 29.26f; // 14.63 × 2
        }
    }
}
