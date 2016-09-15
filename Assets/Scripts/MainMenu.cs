using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private EventSystem system;
    [SerializeField]
    private GameObject LastSelected;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (system.currentSelectedGameObject == null)
            {
                system.SetSelectedGameObject(LastSelected);
            }
            else
            {
                LastSelected = system.currentSelectedGameObject;
            }
        }
       
    }
}
