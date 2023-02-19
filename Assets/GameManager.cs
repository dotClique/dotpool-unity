using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // Singleton instance of the GameManager

    public TextMeshPro scoreText; // The UI Text element that displays the player's score

    private int score = 0; // The player's current score

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        score = 0;
        UpdateScoreText();
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}