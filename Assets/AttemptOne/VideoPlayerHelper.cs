using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerHelper : MonoBehaviour
{
    [SerializeField] string videoNameWithExtension;
    // Start is called before the first frame update
    void Awake()
    {
        GetComponent<VideoPlayer>().url = System.IO.Path.Combine(Application.streamingAssetsPath, videoNameWithExtension);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            GetComponent<VideoPlayer>().Play();
        }
    }
}
