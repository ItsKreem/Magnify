using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QTEPointer : MonoBehaviour
{
    public RectTransform pointer;
    public Transform pointA; // Reference to the starting point
    public Transform pointB; // Reference to the ending point
    public RectTransform safeZone; // Reference to the safe zone RectTransform
    public float pointermoveSpeed = 100f; // Speed of the pointer movement
    public float safezoneSpeed = 10f; // Speed of the safe zone movement

    public float pointerdirection = 1f; // 1 for moving towards B, -1 for moving towards A
    private RectTransform pointerTransform;
    private Vector3 targetPosition;
    public float minX = -600; // Minimum X coordinate for spawning
    public float maxX = 600; // Maximum X coordinate for spawning

    void Start()
    {
        // 1. Generate a random position wit
        float randomX = Random.Range(minX, maxX);
        float randomY = 0;
        pointer.anchoredPosition = new Vector2(randomX, randomY);

        pointerTransform = GetComponent<RectTransform>();
        targetPosition = pointB.position;
    }

    void Update()
    {
        // Move the pointer towards the target position
        pointerTransform.position = Vector3.MoveTowards(pointerTransform.position, targetPosition, pointermoveSpeed * Time.deltaTime);

        // Change direction if the pointer reaches one of the points
        if (Vector3.Distance(pointerTransform.position, pointA.position) < 0.1f)
        {
            targetPosition = pointB.position;
            pointerdirection = 1f;
        }
        else if (Vector3.Distance(pointerTransform.position, pointB.position) < 0.1f)
        {
            targetPosition = pointA.position;
            pointerdirection = -1f;
        }

        // Check for input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CheckSuccess();
        }
    }

    void CheckSuccess()
    {
        // Check if the pointer is within the safe zone
        if (RectTransformUtility.RectangleContainsScreenPoint(safeZone, pointerTransform.position, null))
        {
            Debug.Log("Success!");
        }
        else
        {
            Debug.Log("Fail!");
        }
    }
}
