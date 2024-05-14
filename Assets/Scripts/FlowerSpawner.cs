using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerSpawner : MonoBehaviour
{
    [Header("Spawn Settings")]
    public GameObject[] flowerPrefabs;
    public float spawnChance;
    public float offset = 3f;

    [Header("Raycast Settings")]
    public float distanceBetweenCheck;
    public float heightOfCheck = 70f, rangeOfCheck = 30f;
    public LayerMask layerMask;
    public Vector2 posPosition, negPosition;

    void SpawnFlowers()
    {
        for (float x = negPosition.x; x < posPosition.x; x += distanceBetweenCheck)
        {
            for (float z = negPosition.y; z < posPosition.y; z += distanceBetweenCheck)
            {
                RaycastHit hit;
                if (Physics.Raycast(new Vector3(x, heightOfCheck, z), Vector3.down, out hit, rangeOfCheck, layerMask))
                {
                    if (spawnChance > Random.Range(0, 101))
                    {
                        // Randomly select a flower prefab from the array
                        GameObject flowerPrefab = flowerPrefabs[Random.Range(0, flowerPrefabs.Length)];
                        GameObject flower = Instantiate(flowerPrefab, hit.point + Vector3.up * offset, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), transform);
                        Debug.Log("Flower spawned");
                        // Scale the instantiated flower prefab
                        flower.transform.localScale = Vector3.one * 30f;
                    }
                }
            }
        }
    }

    private void Start()
    {
        SpawnFlowers();
    }
}
