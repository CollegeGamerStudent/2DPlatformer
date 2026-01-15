using UnityEngine;

public class UltraSimpleCloud : MonoBehaviour
{
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime;

        if (transform.position.x < -20f)
            transform.position = new Vector3(20f, transform.position.y, 0f);
    }
}
