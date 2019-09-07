using System;
using UnityEngine;

/// <summary>
/// Singleton
/// </summary>
public abstract class Singleton<T>
where T : Singleton<T>, new()
{
    private static T ins;
    public static T Ins
    {
        get
        {
            if (ins == null)
            {
                ins = new T();
            }
            return ins;
        }
    }
    public virtual void Destroy() => Reset();
    public static void Reset() => ins = null;
}

/// <summary>
/// Monobehaviour's singleton
/// </summary>
public abstract class SingletonMonoBehaviour<T> : MonoBehaviour
     where T : SingletonMonoBehaviour<T>
{
    public static T Ins { get; protected set; }

    protected abstract void UnityAwake();

    private void Awake()
    {
        if (enabled == false)
        {
            return;
        }
        if (Ins == null)
        {
            //ゲーム開始時にGameManagerをinstanceに指定ß
            Ins = this as T;
            UnityAwake();
        }
        else if (Ins != this)
        {
            GameObject.Destroy(this.gameObject);
        }
        else
        {
            // Do Nothing
        }
    }

    protected virtual void OnDestroy()
    {
        if (this == Ins) Ins = null;
    }
}