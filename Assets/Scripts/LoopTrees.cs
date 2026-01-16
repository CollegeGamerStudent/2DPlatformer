using UnityEngine;

public class LoopTrees : MonoBehaviour
{
    public Transform player;
    public float spacing = 4f;
    public float buffer = 10f;

    void Update()
    {
        float camX = player.position.x;
        float rightMost = float.MinValue;

        foreach (Transform t in transform)
            if (t.position.x > rightMost)
                rightMost = t.position.x;

        foreach (Transform tree in transform)
            if (tree.position.x < camX - buffer)
                tree.position = new Vector3(
                    rightMost + spacing,
                    tree.position.y,
                    tree.position.z
                );
    }
}
