using UnityEngine;
using UnityEngine.UI;

#pragma warning disable 0649
[DisallowMultipleComponent]
public class Record : MonoBehaviour
{
    public Text record;
    void Start()
    {
        record = gameObject.GetComponent<Text>();

        record.text = "RECORD : " + PlayerPrefs.GetInt("score");

        Score.ResetScoreText();
        LiveScript.health = 3;
    }
}
