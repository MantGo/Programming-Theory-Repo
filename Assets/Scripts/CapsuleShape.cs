using UnityEngine;

public class CapsuleShape : Shape
{
    private void Reset() { ShapeName = "Capsule"; }
    private void Start() { if (string.IsNullOrEmpty(ShapeName)) ShapeName = "Capsule"; }

    public override void DisplayInfo()
    {
        MessageHolder.Instance.uiText.text = "This is a Capsule!";
        GetComponent<Renderer>().material.color = Color.blue; 

    }
}
