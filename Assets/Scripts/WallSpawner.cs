using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public GameObject wallPrefab;    
    public float spawnInterval = 3f;
    public Transform spawnPoint;    

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnWall();
            timer = 0;
        }
    }

    void SpawnWall()
    {
        Vector3 pos = spawnPoint.position;
        pos.y += Random.Range(-1.5f, 1.5f); 
        Instantiate(wallPrefab, pos, Quaternion.identity);
    }
}
