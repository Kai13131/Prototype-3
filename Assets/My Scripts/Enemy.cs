using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemyObject;

    public float timeScale = 0f;

    float x = 13.75f;
    float z = -3.75f;


    // Update is called once per frame
    void Update()
    {
        timeScale -= Time.deltaTime;
        if (timeScale <= 0)
        {
            for (int i = 0; i < 4; i++)
            {
                Instantiate(enemyObject, new Vector3(x, 0.5f, z + i * 2.5f), Quaternion.identity);
            }

            timeScale = 5f;
        }
    }
}
