using UnityEngine;

// INHERITANCE: SphereShape derives from Shape
public class SphereShape : Shape
{
    private void Reset() { ShapeName = "Sphere"; } // runs in editor when script is added
    private void Start() { if (string.IsNullOrEmpty(ShapeName)) ShapeName = "Sphere"; }

    // POLYMORPHISM: override to give sphere-specific output
    public override void DisplayInfo()
    {
        Debug.Log("This is a round Sphere!");
    }
}
