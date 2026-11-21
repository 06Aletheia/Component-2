using UnityEngine;
using Unity.VisualScripting;

public class DummyScript : MonoBehaviour
{
    private ScoreManager scoremanager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoremanager = Object.FindFirstObjectByType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetButtonDown("Jump"))
        {
            scoremanager.AddScore();
        }
        // Adds a point to the score whenever the Jump key is pressed down. (Calls the AddScore function in the manager)
    }
}
// Basic Script used for testing Score Functionality. It can be replaced.