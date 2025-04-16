using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager1 : MonoBehaviour
{
    public GameObject WinPanel;
    public int totalToCollect = 2; // Set this to the number required to win

    private int collectedCount = 0;

    public void CollectItem()
    {
        collectedCount++;

        if (collectedCount >= totalToCollect)
        {
            ToggleWinPanel();
        }
    }

    public void ToggleWinPanel()
    {
        if (WinPanel != null)
        {
            WinPanel.SetActive(true);
        }
    }
}


