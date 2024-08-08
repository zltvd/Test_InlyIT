using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultBorderComponent : BorderComponent
{
    protected float _border;
    public DefaultBorderComponent(float border)
    {
        _border = border;
    }
    public override float GetBorder()
    {
        return _border;
    }
}
