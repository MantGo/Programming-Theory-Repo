using UnityEngine;

public class CubeShape : Shape
{
    private void Reset() { ShapeName = "Cube"; }
    private void Start() { if (string.IsNullOrEmpty(ShapeName)) ShapeName = "Cube"; }

    public override void DisplayInfo()
    {
        Debug.Log("This is a Cube!");
    }
}
