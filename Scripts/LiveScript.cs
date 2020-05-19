using UnityEngine;
using UnityEngine.SceneManagement;

[DisallowMultipleComponent]
public class LiveScript : MonoBehaviour
{
    public GameObject rocket1, rocket2, rocket3;
    public static int health = 3;

    void Start()
    {
        rocket1.gameObject.SetActive(true);
        rocket2.gameObject.SetActive(true);
        rocket3.gameObject.SetActive(true);
    }
    void Update()
    {
        DisplayCurrentLives();
    }
    private void DisplayCurrentLives()
    {
        switch (health)
        {
            case 3:
                rocket1.gameObject.SetActive(true);
                rocket2.gameObject.SetActive(true);
                rocket3.gameObject.SetActive(true);
                break;
            case 2:
                rocket1.gameObject.SetActive(true);
                rocket2.gameObject.SetActive(true);
                rocket3.gameObject.SetActive(false);
                break;
            case 1:
                rocket1.gameObject.SetActive(true);
                rocket2.gameObject.SetActive(false);
                rocket3.gameObject.SetActive(false);
                break;
            case 0:
                rocket1.gameObject.SetActive(false);
                rocket2.gameObject.SetActive(false);
                rocket3.gameObject.SetActive(false);
                // Invoke("LoadEndScene", 2f);
                break;
            default:
                print("illegal number of lifes");
                break;

        }
    }
    void LoadEndScene()
    {
        health = 3;
        SceneManager.LoadScene(5);
    }
}
