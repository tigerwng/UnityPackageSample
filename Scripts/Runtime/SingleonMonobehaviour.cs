using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleonMonobehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] bool dontDestroyOnLoad = false;

    private static SingleonMonobehaviour<T> _instance;

    protected virtual void Awake()
    {
        _instance = this;

        if (dontDestroyOnLoad)
            DontDestroyOnLoad(gameObject);
    }
}
