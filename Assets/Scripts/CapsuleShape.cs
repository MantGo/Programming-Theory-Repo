using UnityEngine;

public class CapsuleShape : Shape
{
    private void Reset() { ShapeName = "Capsule"; }
    private void Start() { if (string.IsNullOrEmpty(ShapeName)) ShapeName = "Capsule"; }

    public override void DisplayInfo()
    {
        Debug.Log("This is a Capsule!");
    }
}
