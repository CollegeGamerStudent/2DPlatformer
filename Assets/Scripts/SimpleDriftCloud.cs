using UnityEngine;

public class SimpleDriftCloud : MonoBehaviour
{
    void Update()
    {
        // Drift left
        transform.position += Vector3.left * Time.deltaTime;

        // Get camera X
        float camX = Camera.main.transform.position.x;

        // Wrap left
        if (transform.position.x < camX - 20f)
            transform.position += Vector3.right * 40f;

        // Wrap right
        if (transform.position.x > camX + 20f)
            transform.position += Vector3.left * 40f;
    }
}
