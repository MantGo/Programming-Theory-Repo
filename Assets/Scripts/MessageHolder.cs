using UnityEngine;
using TMPro;

public class MessageHolder : MonoBehaviour
{
    public static MessageHolder Instance; 
    public TextMeshProUGUI uiText;       

    private void Awake()
    {
        Instance = this; 
    }
}
