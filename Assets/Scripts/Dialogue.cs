using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using TMPro; // Uncomment if you're using TextMeshPro

public class DialogueManager : MonoBehaviour
{
    public GameObject dialoguePanel;
    public Text dialogueText;

    private string[] currentDialogue;
    private int currentLine;

    private void Start()
    {
        if (dialoguePanel != null)
            dialoguePanel.SetActive(false);
    }

    public void ShowButton1Dialogue()
    {
        currentDialogue = new string[]
        {
            "Hello from Button 1!",
            "This is the second line.",
            "Goodbye!"
        };
        StartDialogue();
    }

    public void ShowButton2Dialogue()
    {
        currentDialogue = new string[]
        {
            "Hey! I'm Button 2.",
            "Different content here."
        };
        StartDialogue();
    }

    private void StartDialogue()
    {
        currentLine = 0;

        if (dialoguePanel != null)
            dialoguePanel.SetActive(true);

        UpdateDialogue();
    }

    public void NextLine()
    {
        currentLine++;
        if (currentDialogue != null && currentLine < currentDialogue.Length)
        {
            UpdateDialogue();
        }
        else
        {
            EndDialogue();
        }
    }

    private void UpdateDialogue()
    {
        if (currentDialogue == null || dialogueText == null) return;

        if (currentLine >= 0 && currentLine < currentDialogue.Length)
        {
            dialogueText.text = currentDialogue[currentLine];
        }
        else
        {
            Debug.LogWarning("Invalid line index: " + currentLine);
        }
    }
    private void EndDialogue()
    {
        if (dialoguePanel != null)
            dialoguePanel.SetActive(false);

        currentDialogue = null;
    }
}