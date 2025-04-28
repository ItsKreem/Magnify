using System.Collections;
using TMPro;
using UnityEngine;

public class ButtonScript : EvidenceFolderScript
{
    public TMP_InputField inputTextField;
    public GameObject ComputerPanel;
    public GameObject ComputerText;
    public GameObject PasswordPanel;
    public TextMeshProUGUI FeedbackText;
    public string password = "password";

    IEnumerator DisplayFeedback(string message, Color color, float delay)
    {
        FeedbackText.text = message;
        FeedbackText.color = color;
        yield return new WaitForSecondsRealtime(delay);
        FeedbackText.text = "Please enter your password.";
        FeedbackText.color = Color.white;
    }

    public void OnValidate()
    {
        if (password == inputTextField.text)
        {
            StartCoroutine(DisplayFeedback("Welcome!", Color.green, 3f));
            StartCoroutine(DeactivatePasswordPanel(1.5f));
            AddEvidenceNo(1);
        }
        else if (string.IsNullOrEmpty(inputTextField.text))
        {
            FeedbackText.text = "Please enter your password.";
            FeedbackText.color = Color.white;
        }
        else
        {
            StartCoroutine(DisplayFeedback("Incorrect password.", Color.red, 1.5f));
        }
    }

    IEnumerator DeactivatePasswordPanel(float delay)
    {
        yield return new WaitForSecondsRealtime(delay);
        PasswordPanel.SetActive(false);
        ComputerPanel.SetActive(true);
        ComputerText.SetActive(true);
    }
}
