using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Comparers;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.UI;

public class Global
{
    public static int numScene = 0;
    public static int numLastOpenedWindow;
    public static int numNowOpenWindow;
}


public abstract class BorderComponent
{
    public abstract float GetBorder();
}

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

public class ButtonController : MonoBehaviour
{
    public float _startThickness;
    public BorderComponent _borderComponent;
    public List<Outline> btn;
    [SerializeField] public List<Button> buttons;
    public List<GameObject> panels;
    
    public float GetBorderValue()
    {
        return _borderComponent.GetBorder();
    }
    public void AddThickness(Outline btn, float border)
    {
        _borderComponent = new DefaultBorderComponent(_startThickness);
        _borderComponent = new AddThicknessDecorator(_borderComponent, border);
        float _border = _borderComponent.GetBorder();
        btn.effectDistance = new Vector2(_border, _border);
        _borderComponent = new DefaultBorderComponent(_startThickness);
    }
    public void DeleteThickness(Outline btn)
    {
        btn.effectDistance = new Vector2(_startThickness, _startThickness);
        _borderComponent = new DefaultBorderComponent(_startThickness);
    }

}
