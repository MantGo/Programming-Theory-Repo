using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Shape : MonoBehaviour
{
    [SerializeField] private string shapeName = "Shape";
    public string ShapeName { get { return shapeName; } protected set { shapeName = value; } }

    // ABSTRACTION: updates text in one simple call
    public virtual void DisplayInfo()
    {
        MessageHolder.Instance.uiText.text = "This is a " + ShapeName;
    }

    private void OnMouseDown()
    {
        DisplayInfo(); // called automatically on click
    }
}
