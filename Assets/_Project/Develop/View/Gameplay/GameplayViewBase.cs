using UnityEngine;

public abstract class GameplayViewBase 
{
    protected bool _isToggled;

    public abstract void ToggleCursor();
    public virtual void ShowObject(GameObject uiObject)
    {
        if (uiObject == null)
        {
            return;
        }

        uiObject.SetActive(true);
    }

    public virtual void HideObject(GameObject uiObject)
    {
        if (uiObject == null)
        {
            return;
        }

        uiObject.SetActive(false);
    }

}
