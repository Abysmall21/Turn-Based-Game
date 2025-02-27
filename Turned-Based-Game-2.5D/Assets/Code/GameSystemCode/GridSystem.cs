using CodeMonkey.Utils;
using System.Collections;
using System.Collections.Generic;
using CodeMonkey.Utils;
using UnityEngine;

public class GridSystem
{
    private int gridX;
    private int gridY;
    private float cellSize;
    private int[,] gridArray;
    private TextMesh[,] debugTextArray;

    public GridSystem(int gridX, int gridY, float cellSize)
    {
        this.gridX = gridX;
        this.gridY = gridY;
        this.cellSize = cellSize;

        gridArray = new int[gridX, gridY];
        debugTextArray = new TextMesh[gridX, gridY];

        for (int x = 0; x < gridArray.GetLength(0); x++)
        {
            for(int y = 0;y < gridArray.GetLength(1); y++)
            {
                debugTextArray[x,y] = UtilsClass.CreateWorldText(gridArray[x,y].ToString(), null, GetWorldPosition(x,y) + new Vector3(cellSize,cellSize) * .5f, 30, Color.white, TextAnchor.MiddleCenter);
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x, y + 1), Color.white, 100f);
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x + 1, y), Color.white, 100f);
                
            }
            Debug.DrawLine(GetWorldPosition(0, gridY), GetWorldPosition(gridX, gridY), Color.white, 100f);
            Debug.DrawLine(GetWorldPosition(gridX, 0), GetWorldPosition(gridX, gridY), Color.white, 100f);
        }

        SetValue(2, 1, 56);
    }
    private Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x,y) * cellSize;
    }
    private void GetXY(Vector3 worldPosition, out int x, out int y)
    {
        x = Mathf.FloorToInt(worldPosition.x / cellSize);
        y = Mathf.FloorToInt(worldPosition.y / cellSize);
    }
    public void SetValue(int x, int y, int value)
    {
        if(x >= 0 &&  y >= 0 && x < gridX && y < gridY)
        gridArray[x,y] = value;
        debugTextArray[x,y].text = gridArray[x,y].ToString();
    }

    public void SetValue(Vector3 worldPosition, int value)
    {
        int x, y;
        GetXY(worldPosition, out x, out y);
        SetValue(x, y, value);
    }
}
