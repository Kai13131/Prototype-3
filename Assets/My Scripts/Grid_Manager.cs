using UnityEngine;

public class Grid_Manager : MonoBehaviour
{
    public float gridSize = 1f;

    public Vector3 SnapToGrid(Vector3 position)
    {
        float x = Mathf.Round(position.x / gridSize) * gridSize;
        float z = Mathf.Round(position.z / gridSize) * gridSize;

        return new Vector3(x, 0.5f, z);
    }
}
