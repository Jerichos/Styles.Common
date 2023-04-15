using System;
using UnityEngine;

namespace Styles.Common
{
public abstract class Singleton<T> : MonoBehaviour where T : Behaviour
{
    [SerializeField] private bool _dontDestroyOnLoad;
    
    private T _instance;

    public T Instance
    {
        get
        {
            if (_instance)
                return _instance;
            
            Debug.LogError("singleton instance does not exists!");
            return null;
        }
    }

    private void Awake()
    {
        if (_instance != null)
        {
            Destroy(_instance.gameObject);
            return;
        }

        _instance = GetComponent<T>();
        
        if(_dontDestroyOnLoad)
            DontDestroyOnLoad(gameObject);
    }
    
    
}
}