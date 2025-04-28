using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EvidenceFolderScript : MonoBehaviour
{
    public int evidence;

    public void AddEvidenceNo(int number)
    {
        evidence = evidence + number;
        Debug.Log("Evidence: " +  evidence);
    }
}
