using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> Enemies;

    private float SpawnTimer = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateSpawnTimer();
    }

    private void UpdateSpawnTimer()
    {
        if (SpawnTimer <= 0)
        {
            SpawnEnemy();
            SpawnTimer = 4.0f;
            return;
        }
        SpawnTimer -= Time.deltaTime;
    }

    public void SpawnEnemy() {
        float width = Camera.main.orthographicSize * Camera.main.aspect;
        float xPosition = Random.Range(-width, width);
        Vector3 factoryPosition = transform.position;
        Vector3 SpawnPosition = factoryPosition + (Vector3.right * xPosition);
        Instantiate(Enemies[Random.Range(0, Enemies.Count)], SpawnPosition, Quaternion.identity);
    }
}
