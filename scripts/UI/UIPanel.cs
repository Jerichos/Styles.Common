using UnityEngine;

namespace Styles.Common
{
public class UIPanel : MonoBehaviour, IUIPanel
{
    public virtual void Open()
    {
        gameObject.SetActive(true);
        OnOpen();
    }

    public virtual  void Close()
    {
        gameObject.SetActive(false);
        OnClose();
    }

    public virtual void Toggle()
    {
        gameObject.SetActive(!gameObject.activeSelf);
        
        if(gameObject.activeSelf)
            OnOpen();
        else
            OnClose();
    }

    protected virtual void OnOpen()
    {
        
    }

    protected virtual void OnClose()
    {
        
    }
}
}