using UnityEngine;
using UnityEngine.UI; // Needed for UI Text

public class PermanentTextPopup : MonoBehaviour
{
    [Header("UI Settings")]
    public GameObject textPopupUI; // Assign your UI Text GameObject in Inspector

    [Header("Trigger Settings")]
    public string playerTag = "Player"; // Tag of the player object

    private bool hasTriggered = false; // Ensures it only triggers once

    private void Start()
    {
        // Hide the text at the start
        if (textPopupUI != null)
            textPopupUI.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider belongs to the player and hasn't triggered before
        if (!hasTriggered && other.CompareTag(playerTag))
        {
            ShowText();
            hasTriggered = true; // Prevents retriggering
        }
    }

    private void ShowText()
    {
        if (textPopupUI != null)
        {
            textPopupUI.SetActive(true); // Show the text permanently
        }
        else
        {
            Debug.LogWarning("Text Popup UI is not assigned in the Inspector.");
        }
    }
}
