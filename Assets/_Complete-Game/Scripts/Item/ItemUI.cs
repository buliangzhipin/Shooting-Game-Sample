using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
    private Image itemImage;

    void Start()
    {
        itemImage = GetComponent<Image>();
    }
    private ItemContent item;
    public void SetItem(ItemContent item)
    {

    }

    public void DeleteItem()
    {
        item = null;
    }
    public void
}
