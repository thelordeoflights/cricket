using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorSwitch : MonoBehaviour
{
    public Texture2D cursor_Normal;
    public Vector2 normalCursorHotspot;
    public Texture2D cursor_OnButton;
    public Vector2 onButtonCursorHotspot;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Alpha1))
        // {
        //     Cursor.SetCursor(cursor_Normal, normalCursorHotspot, CursorMode.Auto);
        // }
        // if (Input.GetKeyDown(KeyCode.Alpha2))
        // {
        //     Cursor.SetCursor(cursor_OnButton, onButtonCursorHotspot, CursorMode.Auto);
        // }
    }
    public void OnCursorEnter()
    {
        Cursor.SetCursor(cursor_OnButton, onButtonCursorHotspot, CursorMode.Auto);
    }
    public void OnCursorExit()
    {
        Cursor.SetCursor(cursor_Normal, normalCursorHotspot, CursorMode.Auto);
    }
}
