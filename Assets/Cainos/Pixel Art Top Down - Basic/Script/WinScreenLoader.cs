using UnityEngine;
using UnityEngine.UI;

public class WinScreenManager : MonoBehaviour
{
    // Reference to the CanvasGroup of the win screen
    public CanvasGroup winScreen;

    // Method to show the win screen
    public void ShowWinScreen()
    {
        // Set the alpha of the CanvasGroup to 1 to make it visible
        winScreen.alpha = 1;
        // Optionally, you can also enable the Canvas if it was disabled
        winScreen.gameObject.SetActive(true);
    }

    // Example method to check for win conditions
    public void CheckWinConditions()
    {
        // Example condition: Player reaches a score of 100
        int playerScore = 4; // Replace with actual score logic
        if (playerScore >= 4)
        {
            ShowWinScreen();
        }
    }
}