using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public abstract class ItemSource : ScriptableObject, Source
{
    public int id;
    public string desc;
    public Image image;
    public abstract ItemContent GenerateItem();
}

public class ItemSource<T> : ItemSource
where T : ItemContent, new()
{
    [SerializeField] public T origin;
    public override ItemContent GenerateItem()
    {
        return this.GenerateContent<ItemSource, T>(origin);
    }
}
