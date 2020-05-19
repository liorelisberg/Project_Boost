using UnityEngine;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class Score : MonoBehaviour
{
    static public int score = 1;
    static public Text scoreText;

    void Start()
    {
        scoreText = gameObject.GetComponent<Text>();
        score = PlayerPrefs.GetInt("score", 1);
        SetStringToText();
    }
    static private void SetStringToText()
    {
        if (!scoreText)
            Debug.Log("something is wrong");
        else
            scoreText.text = score.ToString();
    }
    static public void IncScoreText()
    {
        ++score;
        SetStringToText();

        SaveCurrentScore();
    }
    static public void ResetScoreText()
    {
        score = 1;
        SetStringToText();
        SaveCurrentScore();
    }
    static public void OnDestroy()
    {
        SaveCurrentScore();
    }
    static public void SaveCurrentScore()
    {
        PlayerPrefs.SetInt("score", score);
    }
}

