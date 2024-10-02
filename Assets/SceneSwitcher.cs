using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{

    public void swithscene(string sceneName)
    {

        SceneManager.LoadScene(sceneName);
    }
}
