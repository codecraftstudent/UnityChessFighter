/* 
 * This software was modified by Codecraft Works in 2018. A copy of the original code can be found here: https://www.raywenderlich.com/5441-how-to-make-a-chess-game-with-unity
 * Credit to Brian Broom and Razenware LLC for the original code. Said original code was modified and added to under the terms of the copyright listed in the original code.
 */

using UnityEngine;

public class Geometry
{
    static public Vector3 PointFromGrid(Vector2Int gridPoint)
    {
        float x = -3.5f + 1.0f * gridPoint.x;
        float z = -3.5f + 1.0f * gridPoint.y;
        return new Vector3(x, 0, z);
    }

    static public Vector2Int GridPoint(int col, int row)
    {
        return new Vector2Int(col, row);
    }

    static public Vector2Int GridFromPoint(Vector3 point)
    {
        int col = Mathf.FloorToInt(4.0f + point.x);
        int row = Mathf.FloorToInt(4.0f + point.z);
        return new Vector2Int(col, row);
    }
}
