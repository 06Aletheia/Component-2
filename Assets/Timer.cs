using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
// Used for loading a scene.

public class Timer : MonoBehaviour
{
    [SerializeField] TMP_Text timertext;
    public float time;
    void Update()
    {
        if (time > 0)
        {
        time -= Time.deltaTime;    
        }
        else
        {
            time = 0;
            SceneManager.LoadScene("SampleScene");
        }
        // If the time is above 0, deduct it by deltatime.
        // Otherwise load a scene if the timer reaches 0.

        timertext.text = Mathf.Floor(time).ToString();
        // Rounds the floating number into a integer that is displayed.
    }
}