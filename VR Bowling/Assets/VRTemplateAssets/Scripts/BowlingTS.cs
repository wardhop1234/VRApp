using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class BowlingTS : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public float timestamp;
    
    public void SeekToTimestamp()
    {
        if (videoPlayer.canSetTime)
        {
            // Convert the timestamp to the video player's time scale
            double targetTime = timestamp * videoPlayer.playbackSpeed;

            // Seek the video player to the target time
            videoPlayer.time = targetTime;
        }
    }
}
