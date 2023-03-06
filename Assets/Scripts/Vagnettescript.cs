using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class Vagnettescript : MonoBehaviour
{

    public Volume volume;
    private Bloom thisBloom;
    private Vignette thisVignette;


    private void Start()
    {
        VolumeProfile proflile = volume.sharedProfile;
        volume.profile.TryGet(out thisBloom);
        volume.profile.TryGet(out thisVignette);
    }
    private void Update()
    {
        //thisVignette.intensity.value = Mathf.Sin(Time.realtimeSinceStartup) * 10f;
        
    }

}
