using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitChecker : MonoBehaviour
{
    public bool puzzlesolved = false;
    public GameObject MovementButtonOld;
    public GameObject MovementButtonNew;

    void Update()
    {
        if (puzzlesolved)
        {
            MovementButtonOld.SetActive(false);
            MovementButtonNew.SetActive(true);
            DontDestroyOnLoad(MovementButtonNew);
        }
    }
}
