using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PanelNavigation : MonoBehaviour
{
    public GameObject actionPanel, weaponPanel, spellPanel;
    public GameObject attackFirstButton, swordFirstButton, gunFirstButton, thundraFirstButton;
    public Button weaponButton, spellButton;
    // Start is called before the first frame update
    void Start()
    {

    }

    void activateWeaponPanel()
    {
         // when the weapon button is pressed, activate the weapon panel
         
    }

    void setActivePanelAndButton()
    {
        if (weaponPanel.activeInHierarchy)
        {
            actionPanel.SetActive(false);
            spellPanel.SetActive(false);
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(gunFirstButton);
        }
        else if (actionPanel.activeInHierarchy)
        {
            weaponPanel.SetActive(false);
            spellPanel.SetActive(false);
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(attackFirstButton);
        }
        else if (spellPanel.activeInHierarchy)
        {
            weaponPanel.SetActive(false);
            actionPanel.SetActive(false);
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(thundraFirstButton);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
