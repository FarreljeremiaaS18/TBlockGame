using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int width = 9;
    public int height = 9;
    public GameObject tilePrefab;
    public Vector2 spacing = new Vector2(1.1f, 1.1f);

    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Vector2 spawnPos = new Vector2(x * spacing.x, y * spacing.y);
                Instantiate(tilePrefab, spawnPos, Quaternion.identity, transform);
            }
        }
    }
}
