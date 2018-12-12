/* 
 * This software was modified by Codecraft Works in 2018. A copy of the original code can be found here: https://www.raywenderlich.com/5441-how-to-make-a-chess-game-with-unity
 * Credit to Brian Broom and Razenware LLC for the original code. Said original code was modified and added to under the terms of the copyright listed in the original code.
 */

using System.Collections.Generic;
using UnityEngine;

public class Queen : Piece
{
    public override List<Vector2Int> MoveLocations(Vector2Int gridPoint)
    {
        List<Vector2Int> locations = new List<Vector2Int>();
        List<Vector2Int> directions = new List<Vector2Int>(BishopDirections);
        directions.AddRange(RookDirections);

        foreach (Vector2Int dir in directions)
        {
            for (int i = 1; i < 8; i++)
            {
                Vector2Int nextGridPoint = new Vector2Int(gridPoint.x + i * dir.x, gridPoint.y + i * dir.y);
                locations.Add(nextGridPoint);
                if (GameManager.instance.PieceAtGrid(nextGridPoint))
                {
                    break;
                }
            }
        }

        return locations;
    }
}
