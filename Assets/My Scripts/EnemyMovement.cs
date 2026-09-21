using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 0.25f;

    public Rigidbody rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector3(-speed, 0, 0);
    }
}
