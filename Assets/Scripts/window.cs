using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class window : MonoBehaviour, IObserver
{
    public int id;
    public float borderThickness;
    public WindowController windowController;
    public ButtonController buttonController;
    public bool isOpened = false;
    public bool isCreated = false;
    private void Start()
    {
        windowController.Attach(this);
    }
    public void OpenWindow(int i)
    {
        if (i == id)
        {
            if (!isOpened)
            {
                this.gameObject.SetActive(true);
                isOpened = true;
                buttonController.AddThickness(GameObject.Find("Player").GetComponent<Player>().buttons[i].GetComponent<Outline>(), borderThickness);
            } else
            {
                this.gameObject.SetActive(false);
                isOpened = false;
                buttonController.DeleteThickness(GameObject.Find("Player").GetComponent<Player>().buttons[i].GetComponent<Outline>());
            }
        }
        else
        {
            this.gameObject.SetActive(false);
            isOpened = false;
            for (int j = 0; j < GameObject.Find("Player").GetComponent<Player>().buttons.Count; j++)
            {
                if (j != i) 
                {
                    buttonController.DeleteThickness(GameObject.Find("Player").GetComponent<Player>().buttons[j].GetComponent<Outline>());
                }
            }
        }
    }
}
