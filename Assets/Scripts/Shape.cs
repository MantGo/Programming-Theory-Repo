using UnityEngine;

// Base class: encapsulation + abstraction
[RequireComponent(typeof(Collider))] // ensures a collider exists when you add this script
public class Shape : MonoBehaviour
{
    [SerializeField] private string shapeName = "Shape"; // ENCAPSULATION

    public string ShapeName
    {
        get { return shapeName; }
        protected set { shapeName = value; }
    }

    // ABSTRACTION: high-level method that derived classes can override
    public virtual void DisplayInfo()
    {
        Debug.Log("This is a " + ShapeName);
    }

 
    private void OnMouseDown()
    {
        // Quick debug line you can temporarily use to ensure OnMouseDown runs:
        // Debug.Log("OnMouseDown fired on " + gameObject.name);

        DisplayInfo(); // POLYMORPHISM: calls override in derived classes if present
    }
}
