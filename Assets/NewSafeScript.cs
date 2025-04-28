using UnityEngine;
using UnityEngine.UI;
using TMPro; // Import TextMeshPro namespace

public class KeypadController : MonoBehaviour
{
    public TMP_Text displayText; // Reference to TMP Text UI
    private string enteredNumber = "";

    public void NumberButtonPressed(string number)
    {
        Debug.Log("Button Pressed: " + number); // Debug to check button clicks

        if (enteredNumber.Length < 9) // Limit input length
        {
            enteredNumber += number;
            UpdateDisplay();
        }
    }

    public void ClearButtonPressed()
    {
        enteredNumber = "";
        UpdateDisplay();
    }

    public void EnterButtonPressed()
    {
        Debug.Log("Entered Number: " + enteredNumber); // Show in Console
    }

    private void UpdateDisplay()
    {
        displayText.text = enteredNumber; // Update TMP text
        displayText.ForceMeshUpdate(); // Force UI refresh
    }
}
