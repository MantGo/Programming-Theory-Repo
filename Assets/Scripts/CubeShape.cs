using UnityEngine;

public class CubeShape : Shape
{
    private void Reset() { ShapeName = "Cube"; }
    private void Start() { if (string.IsNullOrEmpty(ShapeName)) ShapeName = "Cube"; }

    public override void DisplayInfo()
    {
        MessageHolder.Instance.uiText.text = "This is a Cube!";
        GetComponent<Renderer>().material.color = Color.red; 

    }
}
