using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public abstract class ButtonAbstract
{
    public abstract void Button_click(int i, Player player);
}

public class Btn_LoadScene : ButtonAbstract
{
    public override void Button_click(int i, Player player)
    {
        Global.numScene = i;
        SceneManager.LoadScene("Loading");
    }
}
public class Btn_OpenPanel : ButtonAbstract
{
    public override void Button_click(int i, Player player)
    {
        if (player.buttons[i].GetComponent<ButtonChecker>().isClicked == false)
        {
            Debug.Log(i);
            player.panelController.CreatePanel(i);
            player.buttons[i].GetComponent<ButtonChecker>().isClicked = true;
            Global.numLastOpenedWindow = Global.numNowOpenWindow;
            Global.numNowOpenWindow = i;
        }
        else
        {
            Global.numLastOpenedWindow = Global.numNowOpenWindow;
            Global.numNowOpenWindow = i;
            player.windowController.Notify(i);
        }
    }
}

public class Btn_Back : ButtonAbstract
{
    public override void Button_click(int i, Player player)
    {
        player.windowController.Notify(Global.numLastOpenedWindow);
    }
}

public class Player : MonoBehaviour
{
    public WindowController windowController;
    public PanelController panelController;
    public List<Button> buttons;

    Btn_LoadScene Btn_LoadScene = new Btn_LoadScene();
    Btn_OpenPanel Btn_OpenPanel = new Btn_OpenPanel();
    Btn_Back Btn_Back = new Btn_Back();

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
