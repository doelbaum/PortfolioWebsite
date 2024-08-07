using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnapTo : MonoBehaviour
{
    [SerializeField] ScrollRect scrollRect;
    [SerializeField] RectTransform contentPanel;

    public void SnapToTarget(RectTransform target)
    {
        Canvas.ForceUpdateCanvases();

        contentPanel.anchoredPosition =
                (Vector2)scrollRect.transform.InverseTransformPoint(contentPanel.position)
                - (Vector2)scrollRect.transform.InverseTransformPoint(target.position);
    }
}
