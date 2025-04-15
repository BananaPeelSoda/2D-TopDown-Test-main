using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public WinScreenManager winScreenManager;

    void Update()
    {
        // Example: Check for win conditions every frame
        winScreenManager.CheckWinConditions();
    }
}

public class WinScreenManager
{
    internal void CheckWinConditions()
    {
        throw new NotImplementedException();
    }
}