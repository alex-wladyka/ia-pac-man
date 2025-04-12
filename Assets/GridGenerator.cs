using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public string gridString =
        "111111" +
        "100001" +
        "100001" +
        "100001" +
        "111111";

    public GameObject wallPrefab; // Prefab da parede
    public GameObject pathPrefab; // Prefab do caminho
    public int col;
    public int lin;
    public float gridSize = 1f;
    private int index = 0;
    private Pathfinding pathfinding;

    private void Start()
    {
        pathfinding = new Pathfinding(col, lin, gridSize);
        GenerateGrid();
    }

    void GenerateGrid()
    {
        

        Vector3 startPosition = new Vector3(0.5f, lin-0.5f, 0);

        for (int row = 0; row < lin; row++)
        {
            for (int cols = 0; cols < col; cols++)
            {
                char cellChar = gridString[index];

                Vector3 position = startPosition + new Vector3(cols * gridSize, -row * gridSize, 0);

                if (cellChar == '0')
                {
                    //Instantiate(pathPrefab, position, Quaternion.identity);
                }
                else if (cellChar == '1')
                {
                    //Instantiate(wallPrefab, position, Quaternion.identity);
                    pathfinding.GetGrid().GetXY(position, out int x, out int y);
                    pathfinding.GetNode(x, y).SetIsWalkable(!pathfinding.GetNode(x, y).isWalkable);
                }
                index += 1;
            }
        }
    }
}
