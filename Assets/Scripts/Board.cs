/* 
 * This software was modified by Codecraft Works in 2018. A copy of the original code can be found here: https://www.raywenderlich.com/5441-how-to-make-a-chess-game-with-unity
 * Credit to Brian Broom and Razenware LLC for the original code. Said original code was modified and added to under the terms of the copyright listed in the original code.
 * Testing the push function. Soccer
 */

using UnityEngine;

public class Board : MonoBehaviour
{
    public Material defaultMaterial;
    public Material selectedMaterial;

    public GameObject AddPiece(GameObject piece, int col, int row)
    {
        Vector2Int gridPoint = Geometry.GridPoint(col, row);
        GameObject newPiece = Instantiate(piece, Geometry.PointFromGrid(gridPoint), Quaternion.identity, gameObject.transform);
        return newPiece;
    }

    public void RemovePiece(GameObject piece)
    {
        Destroy(piece);
    }

    public void MovePiece(GameObject piece, Vector2Int gridPoint)
    {
        piece.transform.position = Geometry.PointFromGrid(gridPoint);
    }

    public void SelectPiece(GameObject piece)
    {
        MeshRenderer renderers = piece.GetComponentInChildren<MeshRenderer>();
        renderers.material = selectedMaterial;
    }

    public void DeselectPiece(GameObject piece)
    {
        MeshRenderer renderers = piece.GetComponentInChildren<MeshRenderer>();
        renderers.material = defaultMaterial;
    }
    public void Test()
    {
        System.Console.WriteLine("Testing the push function");
		System.Constole.WriteLine("Computer1 push")
    }
}
