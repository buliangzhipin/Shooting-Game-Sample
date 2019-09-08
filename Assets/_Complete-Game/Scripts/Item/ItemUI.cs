using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemUI : MonoBehaviour, IPointerClickHandler
{
    private Image itemImage;

    void Start()
    {
        itemImage = GetComponent<Image>();
    }
    private ItemContent item;
    public void SetItem(ItemContent item)
    {
        this.item = item;
        itemImage.sprite = item.image;
    }

    public void DeleteItem()
    {
        item = null;
        itemImage.sprite = DataManager.Ins.emptyItem;
    }
    public void ShowItem()
    {

    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        EquipmentManager.Ins.SelectItem(this);
    }
}
