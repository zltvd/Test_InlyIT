using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class window : MonoBehaviour
{
    public string id;
    public float borderThickness;
    public WindowController windowController;
    public ButtonController buttonController;
    public bool isOpened = false;
    public bool isCreated = false;
    private void Start()
    {
        windowController.OpenWindow += this.OpenWindow;
    }
    public void OpenWindow(int i, Player player)
    {
        if (i.ToString() == id)
        {
            if (!isOpened)
            {
                this.gameObject.SetActive(true);
                isOpened = true;
                buttonController.AddThickness(player.buttons[i].GetComponent<Outline>(), borderThickness);
            } else
            {
                this.gameObject.SetActive(false);
                isOpened = false;
                buttonController.DeleteThickness(player.buttons[i].GetComponent<Outline>());
            }
        }
        else
        {
            this.gameObject.SetActive(false);
            isOpened = false;
            for (int j = 0; j < player.buttons.Count; j++)
            {
                if (j != i) 
                {
                    buttonController.DeleteThickness(player.buttons[j].GetComponent<Outline>());
                }
            }
        }
    }
}
