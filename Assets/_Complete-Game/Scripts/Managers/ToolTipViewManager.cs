using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolTipViewManager : SingletonMonoBehaviour<ToolTipViewManager>
{
    protected override void UnityAwake()
    {
        HideTooltip();
    }
    public bool IsActive
    {
        get
        {
            return gameObject.activeSelf;
        }
    }
    public Text tooltipText;
    public void ShowTooltip(string text, Vector3 pos)
    {
        if (tooltipText.text != text)
            tooltipText.text = text;

        transform.position = pos;

        gameObject.SetActive(true);
    }

    public void HideTooltip()
    {
        gameObject.SetActive(false);
    }
}