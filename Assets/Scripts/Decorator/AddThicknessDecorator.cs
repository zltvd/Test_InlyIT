using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddThicknessDecorator : BorderDecorator
{
    protected float _addThickness;
    public AddThicknessDecorator(BorderComponent component, float addborder) : base(component)
    {
        _addThickness = addborder;
    }
    public override float GetBorder()
    {
        return _addThickness + _component.GetBorder();
    }
}
