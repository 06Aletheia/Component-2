using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TMP_Text scoretext;
    private int score;

public void AddScore()
{
    score++;
    scoretext.SetText("Score:" + score);
}
// Function that adds and sets the Score.
}
// Taken from https://www.youtube.com/watch?v=AL2csPfx7YY&t=39s