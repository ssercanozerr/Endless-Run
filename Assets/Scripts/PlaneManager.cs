using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneManager : MonoBehaviour
{
    public GameObject planePrefab;
    public GameObject obstaclePrefab;
    private int numberOfObstacles;
    public void SpawnNextPlane(Vector3 planeSpawnPosition)
    {
        Instantiate(planePrefab, planeSpawnPosition, Quaternion.identity);
    }

    public void SpawnObstacles(Vector3 planeSpawnPosition, Transform parent) 
    {
        numberOfObstacles = Random.Range(2, 11);
        for (int i = 0; i < numberOfObstacles; i++)
        {
            GameObject obstacle = Instantiate(obstaclePrefab,
                planeSpawnPosition +
                Vector3.back * Random.Range(0, 100) +
                new Vector3(Random.Range(-1, 2), 0, 0) * Random.Range(0, 15),
                Quaternion.identity);
            obstacle.transform.localScale =
                Vector3.forward * Random.Range(3, 6) +
                Vector3.right * Random.Range(3, 6) +
                Vector3.up * Random.Range(3, 6);
        }
    }
}
