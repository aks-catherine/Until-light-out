using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class Vagnettescript : MonoBehaviour
{
    
    public Slider bloomSld;
    public Volume volume;
    private Bloom thisBloom;

    public void BloomCtrl()
    {
        VolumeProfile proflile = volume.sharedProfile;


        volume.profile.TryGet(out thisBloom);
        thisBloom.intensity.value = bloomSld.value;

        if (bloomSld.value == 0)
            thisBloom.active = false;
        else
            thisBloom.active = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            BloomCtrl();
        }
    }

}
