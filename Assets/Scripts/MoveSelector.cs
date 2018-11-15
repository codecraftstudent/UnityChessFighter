using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSelector : MonoBehaviour
{
    public GameObject moveLocationPrefab;
    public GameObject tileHighlightPrefab;
    public GameObject attackLocationPrefab;

    private GameObject
        tileHighlight;
    private GameObject
       movingPiece;

        
    // Use this for initialization
    void Start ()
    {
        this.enabled = false;
        tileHighlight = Instantiate(tileHighlightPrefab,
        Geometry.PointFromGrid(new Vector2Int(0, 0)),
         Quaternion.identity, gameObject.transform);
        tileHighlight.SetActive(false);
	}

	public void EnterState(GameObject piece)
    {

        movingPiece = piece;
        this.enabled = true;

    }
	// Update is called once per frame
	void Update ()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            Vector3 point = hit.point;
            Vector2Int gridPoint = Geometry.GridFromPoint(point);

            tileHighlight.SetActive(true);
            tileHighlight.transform.position = Geometry.PointFromGrid(gridPoint);
            if (Input.GetMouseButtonDown(0))
            {
                if (GameManager.instance.PieceAtGrid(gridPoint) == null)
                {
                    GameManager.instance.Move(movingPiece, gridPoint);
                    
                }
                ExitState();
            }

        }
        else
        {
            tileHighlight.SetActive(false);

        }
    }
    private void ExitState()
    {
        this.enabled = false;
        tileHighlight.SetActive(false);
        GameManager.instance.DeselectPiece(movingPiece);
        movingPiece = null;
        TileSelector selector = GetComponent<TileSelector>();
        selector.EnterState();
    }
}
