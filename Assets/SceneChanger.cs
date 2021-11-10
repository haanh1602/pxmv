using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public static SceneChanger Instance;

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
    }

    public void LoadScene(string sceneName)
    {
        if (sceneName!=null)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
