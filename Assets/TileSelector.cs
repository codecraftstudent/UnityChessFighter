using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSelector : MonoBehaviour {
    public GameObject tileHighlightPrefab;
    private GameObject tileHighlight;


    // Use this for initialization
    void Start () {
        Vector2Int gridpoint = Geometry.GridPoint(0, 0);
        Vector3 point = Geometry.PointFromGrid(gridpoint);
        tileHighlight = Instantiate(tileHighlightPrefab, point, Quaternion.identity, gameObject.transform);
        tileHighlight.SetActive(false);
	}

    public void EnterState()
    {
        enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Vector3 point = hit.point;
            Vector2Int gridpoint = Geometry.GridFromPoint(point);

            tileHighlight.SetActive(true);
            tileHighlight.transform.position = Geometry.PointFromGrid(gridpoint);
        }
        else
        {
            tileHighlight.SetActive(false);
        }
	}
}