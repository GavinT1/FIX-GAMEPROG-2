using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIPassThrough : Image
{
    
    public override bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
    {
        
        
        return true; 
    }
}