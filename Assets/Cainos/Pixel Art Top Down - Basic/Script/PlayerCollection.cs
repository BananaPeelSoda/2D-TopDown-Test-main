using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;

    public int score;
    public int maxScore = 4;

    public GameObject winScreen;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void IncrementScore(int amount)
    {
        score += amount;
        if (score >= maxScore)
        {
            winScreen.SetActive(true);
        }
    }
}