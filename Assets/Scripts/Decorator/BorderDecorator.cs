using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderDecorator : BorderComponent
{
    protected BorderComponent _component;
    public BorderDecorator(BorderComponent component)
    {
        _component = component;
    }
    public override float GetBorder()
    {
        return _component.GetBorder();
    }
}
