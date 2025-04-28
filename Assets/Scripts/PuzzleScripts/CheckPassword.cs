using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
[Serializable]
public class CheckPassword : MonoBehaviour
{
    public TMP_InputField inputTextField;
    public GameObject PasswordPanelText;
    public GameObject PasswordPanel;
    public TextMeshProUGUI FeedbackText;
    public string password = "password";

    IEnumerator MyCoroutine(float sec)
    {
        yield return new WaitForSecondsRealtime(sec);
    }

    public void OnValidate()
    {
        if (password == inputTextField.text)
        {
            FeedbackText.text = "Welcome!";
            FeedbackText.color = Color.green;
            StartCoroutine(MyCoroutine(1.5f));
            PasswordPanel.SetActive(false);
            PasswordPanelText.SetActive(true);
        }
        else if (inputTextField.text == "")
        {
            FeedbackText.text = "Please enter your password.";
            FeedbackText.color = Color.white;

        }
        else if (inputTextField.text != password && inputTextField.text != "")
        {
            FeedbackText.text = "Incorrect password.";
            FeedbackText.color = Color.red;
            StartCoroutine(MyCoroutine(1.5f));
            FeedbackText.text = "Please enter your password.";
            FeedbackText.color = Color.white;
        }
    }
}
