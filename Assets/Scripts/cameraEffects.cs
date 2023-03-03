
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class cameraEffects : MonoBehaviour
{
    public Image image;
    public float speed;
    //private Color dark;
    private bool Black;
    private float alpha;

    void Start()
    {
        Black = false;
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        

    }

    // Update is called once per frame
    void Update()
    {
        alpha += 0.1f + Time.deltaTime * 0.01f;


        if (Input.GetKeyDown("space"))
        {
            if (Black == true)
            {
                image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
                Black = false;
            }
            else
            {
                


                image.color += new Color(image.color.r, image.color.g, image.color.b, 0.1f);
                Black = true;

            }

        }

    }

}
