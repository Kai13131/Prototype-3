using UnityEngine;

public class TowerHealth : MonoBehaviour
{
    public int towerHealth = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            towerHealth--;
            if (towerHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
