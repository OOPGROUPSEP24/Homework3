using UnityEngine;

public class InstructionButtonController : MonoBehaviour
{
    public GameObject instructionsPanel; // Assign the InstructionsPanel GameObject in the Inspector

    // Function to toggle the Instructions panel visibility
    public void ToggleInstructionsPanel()
    {
        if (instructionsPanel != null)
        {
            bool isActive = instructionsPanel.activeSelf;
            instructionsPanel.SetActive(!isActive); // Toggle the panel's active state
        }
        else
        {
            Debug.LogWarning("InstructionsPanel is not assigned.");
        }
    }
}
