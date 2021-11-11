using System;
using System.Collections;
using System.Collections.Generic;
using Assets.HeroEditor4D.Common.CharacterScripts;
using UnityEngine;

public class ModifyController : MonoBehaviour
{
    public GameObject StartCanvas;
    public GameObject ModifyCanvas;
    public Character4D character;

    private void Start()
    {
        StartCanvas.SetActive(true);
        ModifyCanvas.SetActive(false);
        if (!character)
        {
            character = FindObjectOfType<Character4D>();
        }
    }

    public void OnModifyClick()
    {
        StartCanvas.SetActive(false);
        ModifyCanvas.SetActive(true);
    }

    public void OnCloseModifyCanvasClick()
    {
        ModifyCanvas.SetActive(false);
        StartCanvas.SetActive(true);
    }

    public void Refresh()
    {
        character.LoadFromJson();
    }
}
