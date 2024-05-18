using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorSwitch : MonoBehaviour
{
    public Texture2D cursor_Normal;
    public Vector2 normalCursorHotspot;
    public Texture2D cursor_OnButton;
    public Vector2 onButtonCursorHotspot;

    public void OnCursorEnter()
    {
        Cursor.SetCursor(cursor_OnButton, onButtonCursorHotspot, CursorMode.Auto);
    }
    public void OnCursorExit()
    {
        Cursor.SetCursor(cursor_Normal, normalCursorHotspot, CursorMode.Auto);
    }
}
