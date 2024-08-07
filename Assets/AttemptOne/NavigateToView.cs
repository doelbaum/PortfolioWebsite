using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NavigateToView : MonoBehaviour
{
    [SerializeField] ViewNavigationManager navigationManager;

    [SerializeField] GameObject scrollView;

    public void Navigate()
    {
        navigationManager.NavigateToView(scrollView);
    }
}
