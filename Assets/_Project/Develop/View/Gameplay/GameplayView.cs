using UnityEngine;

public class GameplayView : GameplayViewBase
{
    public override void ToggleCursor()
    {
        if (_isToggled)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            _isToggled = false;
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            _isToggled = true;
        }
    }

    
}
