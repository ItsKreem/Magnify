using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class SafeScript : EvidenceFolderScript
{
    public TMP_Text codeText;
    public TMP_Text FeedbackText;
    public GameObject SafePanel;
    public string codeTextValue = "....";
    public string feedbackTextValue = "";
    public Button buttonOne;
    public Button buttonTwo;
    public Button buttonThree;
    public Button buttonFour;
    public Button buttonFive;
    public Button buttonSix;
    public Button buttonSeven;
    public Button buttonEight;
    public Button buttonNine;
    public Button buttonZero;
    public GameObject Panel;
    public GameObject SolvedText;
    public bool solved = false;

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }

    public void OffButtons()
    {
        buttonOne.enabled = false;
        buttonTwo.enabled = false;
        buttonThree.enabled = false;
        buttonFour.enabled = false;
        buttonFive.enabled = false;
        buttonSix.enabled = false;
        buttonSeven.enabled = false;
        buttonEight.enabled = false;
        buttonNine.enabled = false;
        buttonZero.enabled = false;
    }

    public void OnButtons()
    {
        buttonOne.enabled = true;
        buttonTwo.enabled = true;
        buttonThree.enabled = true;
        buttonFour.enabled = true;
        buttonFive.enabled = true;
        buttonSix.enabled = true;
        buttonSeven.enabled = true;
        buttonEight.enabled = true;
        buttonNine.enabled = true;
        buttonZero.enabled = true;
    }

    void Update()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == "3762")
        {
            StartCoroutine(AttemptFeedback(Color.green, 1));
            StartCoroutine(DisplayFeedback("CORRECT!", Color.green, 2));
            StartCoroutine(DeactivateSafePanel(3));
        }

        if (codeTextValue.Length == 4 && codeTextValue != "3762")
        {
            OffButtons();
            StartCoroutine(AttemptFeedback(Color.red, 1));
            StartCoroutine(DisplayFeedback("WRONG!", Color.red, 3));
        }
    }

    IEnumerator DeactivateSafePanel(float delay)
    {
        yield return new WaitForSecondsRealtime(delay);
        SafePanel.SetActive(false);
        Panel.SetActive(false);
        SolvedText.SetActive(true);
        solved = true;
    }

    IEnumerator DisplayFeedback(string message, Color color, float delay)
    {
        FeedbackText.text = message;
        FeedbackText.color = color;
        yield return new WaitForSecondsRealtime(delay);
        FeedbackText.text = "";
        OnButtons();
    }

    IEnumerator AttemptFeedback(Color color, float delay)
    {

        for (int i = 0; i < 3; i++)
        {
            codeText.color = color;
            yield return new WaitForSecondsRealtime(delay);
            codeText.color = Color.white;
        }

        codeText.text = "";
        codeTextValue = "";

    }
}
