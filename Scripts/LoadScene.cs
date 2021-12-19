using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    //if you pressed button, scene changed
    void SceneChange (string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    //success exit from old scene
    void Exit()
    {
        Application.Quit();
    }
}
