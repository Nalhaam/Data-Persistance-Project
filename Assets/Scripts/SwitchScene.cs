using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public void PlayScene()
    {

        SceneManager.LoadScene(1);
    }

    public void MenuScene()
    {
        SceneManager.LoadScene(0);
    }
}
