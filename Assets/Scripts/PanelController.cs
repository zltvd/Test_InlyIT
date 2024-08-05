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

    public void CreatePanel(int i)
    {
        GameObject panel = Instantiate(ButtonController.panels[i], GameObject.Find("Canvas").transform.position, GameObject.Find("Canvas").transform.rotation);
        panel.transform.SetParent(GameObject.Find("Canvas").transform);
        WindowController.Attach(panel.gameObject.GetComponent<IObserver>());
        WindowController.Notify(i);
    }
}
