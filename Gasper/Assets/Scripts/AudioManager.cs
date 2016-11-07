using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

    float masterVolumePercent = .2f;
    float sfxVolumePercent = 1;
    float musicVolumePercent = 1f;

    AudioSource[] musicSources;
    int activeMusicSourceIndex;

    

    public void PlaySound(AudioClip clip, Vector3 pos)
    {
        if (clip != null)
        {
            AudioSource.PlayClipAtPoint(clip, pos, sfxVolumePercent * masterVolumePercent);
        }
    }

    
}
