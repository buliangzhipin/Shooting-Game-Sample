using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemContent : Content
{
    // public Sprite 
    public ItemSource source;
    public void SetSource(ItemSource owner)
    {

    }
    public virtual void OnEquip()
    { }
    public virtual void OffEquip() { }
}
