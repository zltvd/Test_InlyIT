using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowController : MonoBehaviour
{
    public event Action<int, Player> OpenWindow;
    public void Attach(window window)
    {
        OpenWindow += window.OpenWindow;
    }
    public void Notify(int i, Player player)
    {
        if (OpenWindow != null)
        {
            OpenWindow(i, player);
        }
    }
}
