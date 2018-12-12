/* 
 * This software was modified by Codecraft Works in 2018. A copy of the original code can be found here: https://www.raywenderlich.com/5441-how-to-make-a-chess-game-with-unity
 * Credit to Brian Broom and Razenware LLC for the original code. Said original code was modified and added to under the terms of the copyright listed in the original code.
 */

using System.Collections.Generic;
using UnityEngine;

public class Knight : Piece
{
    public override List<Vector2Int> MoveLocations(Vector2Int gridPoint)
    {
        List<Vector2Int> locations = new List<Vector2Int>();

        locations.Add(new Vector2Int(gridPoint.x - 1, gridPoint.y + 2));
        locations.Add(new Vector2Int(gridPoint.x + 1, gridPoint.y + 2));

        locations.Add(new Vector2Int(gridPoint.x + 2, gridPoint.y + 1));
        locations.Add(new Vector2Int(gridPoint.x - 2, gridPoint.y + 1));

        locations.Add(new Vector2Int(gridPoint.x + 2, gridPoint.y - 1));
        locations.Add(new Vector2Int(gridPoint.x - 2, gridPoint.y - 1));

        locations.Add(new Vector2Int(gridPoint.x + 1, gridPoint.y - 2));
        locations.Add(new Vector2Int(gridPoint.x - 1, gridPoint.y - 2));

        return locations;
    }
}
