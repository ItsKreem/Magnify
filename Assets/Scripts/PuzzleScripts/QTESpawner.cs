using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QTESpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject objectTwoSpawn;
    public float minX = -5f; // Minimum X coordinate for spawning
    public float maxX = 5f; // Maximum X coordinate for spawning
    public float minY = -3f; // Minimum Y coordinate for spawning
    public float maxY = 3f; // Maximum Y coordinate for spawning

    public void SpawnObject()
    {
        // 1. Generate a random position within the specified range
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Vector2 onespawnPosition = new Vector2(randomX, randomY);

        float randomA = Random.Range(minX, maxX);
        float randomB = Random.Range(minY, maxY);
        Vector2 twospawnPosition = new Vector2(randomA, randomB);

        // 2. Instantiate the object at the random position
        Instantiate(objectToSpawn, onespawnPosition, Quaternion.identity);
        Instantiate(objectTwoSpawn, twospawnPosition, Quaternion.identity);
    }
}
