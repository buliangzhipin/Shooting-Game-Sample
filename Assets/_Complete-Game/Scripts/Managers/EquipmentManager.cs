using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EquipmentManager : SingletonMonoBehaviour<EquipmentManager>
{
    [NonSerialized] public GameObject SelectedItem;
    public GameObject ItemPanel;
    private bool itemIsShowed => ItemPanel.activeSelf;
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

}
