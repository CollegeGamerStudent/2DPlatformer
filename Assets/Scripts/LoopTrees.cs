using UnityEngine;

public class LoopTrees : MonoBehaviour
{
    public Transform player;   // assign the player or camera
    public float spacing = 4f; // distance between trees
    public float buffer = 10f; // how far before a tree wraps

    void Update()
    {
        float camX = player.position.x;

        foreach (Transform t in transform)
        {
            // move tree to right if it goes offscreen to the left
            if (t.position.x + spacing / 2 < camX - buffer)
            {
                float rightMost = float.MinValue;
                foreach (Transform tree in transform)
                    if (tree.position.x > rightMost) rightMost = tree.position.x;

                t.position = new Vector3(rightMost + spacing, t.position.y, t.position.z);
            }

            // move tree to left if it goes offscreen to the right
            if (t.position.x - spacing / 2 > camX + buffer)
            {
                float leftMost = float.MaxValue;
                foreach (Transform tree in transform)
                    if (tree.position.x < leftMost) leftMost = tree.position.x;

                t.position = new Vector3(leftMost - spacing, t.position.y, t.position.z);
            }
        }
    }
}
