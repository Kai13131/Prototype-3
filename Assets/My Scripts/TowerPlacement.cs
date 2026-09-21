using UnityEngine;

public class TowerPlacement : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject towerPrefab;
    public GridManager GridManager;

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
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            Vector3 gridPosition = GridManager.SnapToGrid(hit.point);

            Instantiate(towerPrefab,gridPosition,Quaternion.identity);
        }
 
    }
}
