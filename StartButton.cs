using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[DisallowMultipleComponent]
public class StartButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadFirstLevel()
    {
        SceneManager.LoadScene(1);
    }
}
