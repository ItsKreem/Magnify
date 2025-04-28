using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CircuitBreakerScript : CircuitChecker
{
    public GameObject Panel;
    public GameObject FirstImage;
    public GameObject LastImage;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Button4;
    public GameObject Button5;
    public GameObject Button6;
    public GameObject Button7;
    public GameObject DialogueText;
    public GameObject DialoguePanel;
    IEnumerator SolvedPuzzle(float delay)
    {
        FirstImage.SetActive(false);
        LastImage.SetActive(true);
        yield return new WaitForSecondsRealtime(delay);
        Panel.SetActive(false);
        DialoguePanel.SetActive(true);
        DialogueText.SetActive(true);
        yield return new WaitForSecondsRealtime(delay);
        DialoguePanel.SetActive(false);
        DialogueText.SetActive(false);
        ButtonOn();
        puzzlesolved = true;
    }

    public void OnPush()
    {
        StartCoroutine(SolvedPuzzle(1));
    }

    public void ButtonOn() //method to on all the buttons
    {
        Button1.SetActive(true);
        Button2.SetActive(true);
        Button3.SetActive(true);
        Button4.SetActive(true);
        Button5.SetActive(true);
        Button6.SetActive(true);
        Button7.SetActive(true);
    }
}
