using UnityEngine;
public class GroundRepeater : MonoBehaviour 
{ 
    public float speed = 5f;
    private float width;
    void Start() 
    {
        width = GetComponent<SpriteRenderer>().bounds.size.x;
    }
    void Update()
    { 
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < -width)
        { 
            transform.position += Vector3.right * width * 2;
        }
    }
}