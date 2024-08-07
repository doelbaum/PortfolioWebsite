using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewNavigationManager : MonoBehaviour
{
    [SerializeField] GameObject startView;

    [SerializeField] GameObject currentView;

    [SerializeField] GameObject scrollViewParent;

    [SerializeField] LeanTweenType tweenType;

    [SerializeField] float tweenSeconds;

    private void Start()
    {
        currentView = startView;
    }
    public void NavigateToView(GameObject newView)
    {
        float dist = currentView.transform.position.x - newView.transform.position.x;
        Vector3 newPos = scrollViewParent.transform.position + new Vector3(dist, 0, 0);
        LeanTween.move(scrollViewParent, newPos, tweenSeconds).setEase(tweenType);
        currentView = newView;
    }
}
