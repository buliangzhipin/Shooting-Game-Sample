using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EquipmentManager : SingletonMonoBehaviour<EquipmentManager>
{
    [NonSerialized] public GameObject SelectedItem;
    public GameObject ItemPanel;
    private bool itemIsShowed => ItemPanel.activeSelf;
    public ItemContent[] currentEquipment = new ItemContent[3];
    public ItemContent[] backpackEquipment = new ItemContent[5];
    protected override void UnityAwake() { }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (itemIsShowed)
            {
                HideItemPanel();
            }
            else
            {
                ShowItemPanel();
            }
        }
    }
    public void ShowItemPanel()
    {
        PauseManager.Ins.Pause();
        ItemPanel.SetActive(true);
    }

    public void HideItemPanel()
    {
        PauseManager.Ins.Restart();
        ItemPanel.SetActive(false);
    }

    public void GetItem(ItemContent item)
    {
    }
    public void EquipItem(ItemContent item)
    {
        item.OnEquip();
    }
}
