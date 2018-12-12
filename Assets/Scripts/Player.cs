/* 
 * This software was modified by Codecraft Works in 2018. A copy of the original code can be found here: https://www.raywenderlich.com/5441-how-to-make-a-chess-game-with-unity
 * Credit to Brian Broom and Razenware LLC for the original code. Said original code was modified and added to under the terms of the copyright listed in the original code.
 */

using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public List<GameObject> pieces;
    public List<GameObject> capturedPieces;

    public string name;
    public int forward;

    public Player(string name, bool positiveZMovement)
    {
        this.name = name;
        pieces = new List<GameObject>();
        capturedPieces = new List<GameObject>();

        if (positiveZMovement == true)
        {
            this.forward = 1;
        }
        else
        {
            this.forward = -1;
        }
    }
}
