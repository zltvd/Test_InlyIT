using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public WindowController windowController;
    public PanelController panelController;
    public List<Button> buttons;

    Btn_LoadScene Btn_LoadScene = new Btn_LoadScene();
    Btn_OpenPanel Btn_OpenPanel = new Btn_OpenPanel();
    Btn_Back Btn_Back = new Btn_Back();

    public GameObject Canvas;

    public void Button_LoadScene(int i)
    {
        Btn_LoadScene.Button_click(i, this);
    }

    public void Button_OpenPanel(int i)
    {
        Btn_OpenPanel.Button_click(i, this);
    }
    public void Button_Back(int i)
    {
        Btn_Back.Button_click(i, this);
    }
}
