using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{
    public ButtonController ButtonController;
    public WindowController WindowController;

    private void Start()
    {
        ButtonController._borderComponent = new DefaultBorderComponent(ButtonController._startThickness);
    }

    public void CreatePanel(int i, Player player)
    {
        GameObject panel = Instantiate(ButtonController.panels[i], player.Canvas.transform.position, player.Canvas.transform.rotation);
        panel.transform.SetParent(player.Canvas.transform);
        WindowController.Attach(panel.gameObject.GetComponent<window>());
        WindowController.Notify(i, player);
    }
}
