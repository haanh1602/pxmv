using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCharacterController : MonoBehaviour
{

    [SerializeField] private GameObject ChooseCharacterPanel;
    [SerializeField] private GameObject CreateCharacter;
    
    public void OnNewClick()
    {
        CreateCharacter.SetActive(true);
    }

    public void OnCloseCreaeCharacterClick()
    {
        CreateCharacter.SetActive(false);
    }

    public void OnLoadClick()
    {
        ChooseCharacterPanel.SetActive(true);
    }

    public void OnCloseChooseCharacterPanelClick()
    {
        ChooseCharacterPanel.SetActive(false);
    }
    
    
}
