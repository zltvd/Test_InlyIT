using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn_Back : ButtonAbstract
{
    public override void Button_click(int i, Player player)
    {
        player.windowController.Notify(Global.numLastOpenedWindow, player);
    }
}
