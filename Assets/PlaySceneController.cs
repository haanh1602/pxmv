using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySceneController : MonoBehaviour
{
    public GameObject NewButton;
    public GameObject PlayButton;

    private void Start()
    {
        Refresh();
    }

    public void Refresh()
    {
        var path = Application.persistentDataPath + "/avatar.dat";
        if (System.IO.File.Exists(path))
        {   
            Debug.Log(path + " exist");
            NewButton.SetActive(false);
            PlayButton.SetActive(true);
        }
        else
        {
            Debug.Log(path + " not exist");
            NewButton.SetActive(true);
            PlayButton.SetActive(false);
        }
    }
}
