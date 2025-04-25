using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CursorSprite : MonoBehaviour
{
    public Texture2D textureCursor;
 
    public CursorMode cursormode = CursorMode.Auto;
     public Vector2 offset = Vector2.zero;

    private void Awake()
    {
        
        Cursor.SetCursor(textureCursor, offset, cursormode);
    }
    
  
}
