using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Comparers;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.UI;

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
