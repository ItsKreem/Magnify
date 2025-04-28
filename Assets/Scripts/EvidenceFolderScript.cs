using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EvidenceFolderScript : MonoBehaviour
{
    public int evidence = 0;
    public string evidence1 = null;
    public string evidence2 = null;

    public void AddEvidenceNo(int number)
    {
        evidence = evidence + number;
        Debug.Log("Evidence: " +  evidence);
    }

    public void AddEvidenceName()
    {
        evidence1 = "Collected manuscripts and confession through suspect's computer.";
        evidence2 = "Collected the murder weapon.";
    }

    public void EndCase()
    {
        //if (evidence == 0)
        //{
        //    SceneManager.LoadScene(Outcome1);
        //}
        //else if (evidence == 1) 
        //{
        //    SceneManager.LoadScene(Outcome2);
        //}
        //else if (evidence == 2)
        //{
        //    SceneManager.LoadScene(Outcome2)
        //}

    }
}
