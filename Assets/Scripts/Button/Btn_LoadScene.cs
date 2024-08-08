using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Btn_LoadScene : ButtonAbstract
{
    public override void Button_click(int i, Player player)
    {
        Global.numScene = i;
        SceneManager.LoadScene("Loading");
    }
}
