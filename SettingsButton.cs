using UnityEngine;

public class SettingsButton : MonoBehaviour
{
    public GameObject settingsPanel; // Assign the SettingsPanel GameObject in the Inspector

    // Function to toggle the Settings panel visibility
    public void ToggleSettingsPanel()
    {
        if (settingsPanel != null)
        {
            bool isActive = settingsPanel.activeSelf;
            settingsPanel.SetActive(!isActive); // Toggle the panel's active state
        }
        else
        {
            Debug.LogWarning("SettingsPanel is not assigned.");
        }
    }
}
