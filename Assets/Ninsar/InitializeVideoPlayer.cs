using UnityEngine;
using UnityEngine.Video;

[RequireComponent(typeof(VideoPlayer))]
public class InitializeVideoPlayer : MonoBehaviour
{
    public string Video;

    private void Awake()
    {
        VideoPlayer videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, Video);
        videoPlayer.Play();
    }
}
