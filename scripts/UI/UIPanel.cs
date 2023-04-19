using UnityEngine;

namespace Styles.Common
{
public class UIPanel : MonoBehaviour, IUIPanel
{
    public virtual void Open()
    {
        OnOpen();
    }

    public virtual  void Close()
    {
        
        OnClose();
    }

    public virtual void Toggle()
    {
        var open = !gameObject.activeSelf;
        
        if(open)
            OnOpen();
        else
            OnClose();
    }

    protected virtual void OnOpen()
    {
        gameObject.SetActive(true);
    }

    protected virtual void OnClose()
    {
        gameObject.SetActive(false);
    }
}
}