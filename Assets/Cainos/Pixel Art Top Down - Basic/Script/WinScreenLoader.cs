using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreenTrigger : MonoBehaviour
{
    public int totalItems = 10; // Total number of items to collect
    private int collectedItems = 0; // Number of items collected

    void Update()
    {
        // Check if the player has collected everything
        if (collectedItems >= totalItems)
        {
            // Load the win screen scene
            SceneManager.LoadScene("WinScreen");
        }
    }

    // Example method to increment collected items
    public void OnItemCollected()
    {
        collectedItems++;
    }
}