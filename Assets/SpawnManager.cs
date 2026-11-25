
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // 적기 프리팹 배열
    public GameObject[] enemyPrefabs;

    // 적기 생성 위치 배열
    public Transform[] spawnPoints;

    // 적기 생성 주기
    public float spawnInterval = 2.0f;

    // 최초 생성까지 걸리는 시간
    public float startDelay = 1.0f;

    void Start()
    {
        InvokeRepeating(
            nameof(SpawnEnemy),
            startDelay,
            spawnInterval
        );
    }

    void SpawnEnemy()
    {
        int randomValue = Random.Range(0, 100);
        int enemyIndex;

        if (randomValue < 45)
        {
            enemyIndex = 0;
        }
        else if (randomValue < 75)
        {
            enemyIndex = 1;
        }
        else if (randomValue < 95)
        {
            enemyIndex = 2;
        }
        else
        {
            enemyIndex = 3;
        }

        int spawnIndex = Random.Range(0, spawnPoints.Length);

        Instantiate(
            enemyPrefabs[enemyIndex],
            spawnPoints[spawnIndex].position,
            Quaternion.identity
        );
    }
}
