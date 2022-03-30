using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {
    public void ChangeStartScene()
    {
        SceneManager.LoadScene("Start");
    }
    public void ChangeMainScene()
    {
        SceneManager.LoadScene("Main");
    }
    public void ChangeHardScene()
    {
        SceneManager.LoadScene("Hard");
    }
    public void ChangeEndingScene()
    {
        SceneManager.LoadScene("Ending");
    }
    public void ChangeEnding2Scene()
    {
        SceneManager.LoadScene("Ending2");
    }
}
