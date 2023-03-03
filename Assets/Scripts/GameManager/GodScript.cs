using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class GodScript : MonoBehaviour
{
    [SerializeField]
    AltarScript Altar1;
    [SerializeField]
    AltarScript Altar2;
    [SerializeField]
    AltarScript Altar3;
    [SerializeField]
    AltarScript Altar4;
    
    private int AlCount;
    private bool Win;

    //public PostProcessVolume ourVolume;
    

    void Start()
    {
        AlCount = 1;
        bool Win = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Win == true)
        {
            

        }
    }
    public void altars(int whatNumberOfThisAltar, AltarScript _thisAltarObject)
    {
        if (AlCount == whatNumberOfThisAltar)
        {
            _thisAltarObject.NewLight();
            AlCount += 1;
        }
        else if (AlCount > whatNumberOfThisAltar)
        { }
        else
        {
            Altar1.DisActivate();
            Altar2.DisActivate();
            Altar3.DisActivate();
            Altar4.DisActivate();
            AlCount = 1;
            Debug.Log("хах");
        }

        if (AlCount == 5)
        {
            Win = true;
            Debug.Log("Победа");
        }
    }

}
