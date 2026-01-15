using UnityEngine;

public class SimpleFourTrees : MonoBehaviour
{
    void Update()
    {
        float camX = Camera.main.transform.position.x;

        // Wrap left
        if (transform.position.x < camX - 10f)
            transform.position += Vector3.right * 20f;

        // Wrap right
        if (transform.position.x > camX + 10f)
            transform.position += Vector3.left * 20f;
    }
}
