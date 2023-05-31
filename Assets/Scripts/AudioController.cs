using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

    public AK.Wwise.Bank mainBank = null;

    public AK.Wwise.Event enemy = null;

    public AK.Wwise.Event envAmbience = null;

    public AK.Wwise.Event playerDeath = null;
    public AK.Wwise.Event playerFootsteps = null;
    public AK.Wwise.Event playerScanner = null;

    private bool footstepsIsPlaying = false;

    public void Awake()
    {
        mainBank.Load();
    }

    public void triggerFootsteps() {
        if (!footstepsIsPlaying) {
            footstepsIsPlaying = true;
            playerFootsteps.Post(gameObject, (uint)AkCallbackType.AK_EndOfEvent, endFootseps);
        }
    }

    private void endFootseps(object in_cookie, AkCallbackType in_type, object in_info) {
        footstepsIsPlaying = false;
    }

    public void setTerrainSwitch(string switchValue) {
        AkSoundEngine.SetSwitch("Environment", switchValue, gameObject);
    }
}
