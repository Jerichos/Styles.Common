using System;
using UnityEngine;
using UnityEngine.UI;

namespace Styles.Common
{
public class UIPanel : MonoBehaviour, IUIPanel
{
    [SerializeField] private Button _buttonExit;
    
    public virtual void Open()
    {
        OnOpen();
    }

    public virtual  void Close()
    {
        Debug.Log("close");
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

    protected virtual void OnEnable()
    {
        Debug.Log("OnEnable");
        if(_buttonExit)
            _buttonExit.onClick.AddListener(Close);
    }

    protected virtual void OnDisable()
    {
        if(_buttonExit)
            _buttonExit.onClick.RemoveAllListeners();
    }
}
}