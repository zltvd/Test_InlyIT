using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn_OpenPanel : ButtonAbstract
{
    public override void Button_click(int i, Player player)
    {
        if (player.buttons[i].GetComponent<ButtonChecker>().isClicked == false)
        {
            player.panelController.CreatePanel(i, player);
            player.buttons[i].GetComponent<ButtonChecker>().isClicked = true;
            Global.numLastOpenedWindow = Global.numNowOpenWindow;
            Global.numNowOpenWindow = i;
        }
        else
        {
            Global.numLastOpenedWindow = Global.numNowOpenWindow;
            Global.numNowOpenWindow = i;
            player.windowController.Notify(i, player);
        }
    }
}
