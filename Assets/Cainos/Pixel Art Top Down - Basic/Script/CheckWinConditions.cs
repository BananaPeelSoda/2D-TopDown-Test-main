using System;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerController : MonoBehaviour
{
    private AudioSource audioSource;
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

