using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentSizeHelper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var rect = GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(rect.sizeDelta.x, Screen.height + 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
