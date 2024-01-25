using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class IngameMenu : MonoBehaviour
{
    public GameObject SettingsMenu;
    public bool PopupAan;

    public void SettingsPopUp(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (!PopupAan)
            {
                PopupMenuOn();
            }
            else
            {
                PopupMenuOff();

            }
            PopupAan = !PopupAan;
        }
    }

    public void PopupMenuOn()
    {
        SettingsMenu.SetActive(true);
    }

    public void PopupMenuOff()
    {
        SettingsMenu.SetActive(false);
    }

}
