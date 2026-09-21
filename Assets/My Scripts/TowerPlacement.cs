using UnityEngine;

public class TowerPlacement : MonoBehaviour
{
    public GameObject towerPrefab;
    public GridManager gm;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlaceTower();
        }
    }

    void PlaceTower()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Plane ground = new Plane(Vector3.up, Vector3.zero);

        if (ground.Raycast(ray, out float distance))
        {
            Vector3 mousePosition = ray.GetPoint(distance);

            Vector2Int gridPosition = gm.GetGridCoordinate(mousePosition);

            gm.InstantiateObjectOnGrid(gridPosition,towerPrefab);
        }
    }
}
