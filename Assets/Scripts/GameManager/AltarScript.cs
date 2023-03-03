using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarScript : MonoBehaviour
{
    [SerializeField]
    private int numberOfAltar;
    [SerializeField]
    private GodScript godScript;
    [SerializeField]
    private Material WinLightMaterial;
    [SerializeField]
    private Material originalMaterial;
    [SerializeField]
    private GameObject AltMaterial;
    private Renderer renderer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void activate()
    {
        godScript.altars(numberOfAltar, this);
        Debug.Log("¬«¿»ÃŒƒ≈…—“¬»≈");
    }

    public void NewLight()
    {
        renderer = AltMaterial.GetComponent<Renderer>();
        renderer.material = WinLightMaterial;
    }
    public void DisActivate()
    {
        renderer = AltMaterial.GetComponent<Renderer>();
        renderer.material = originalMaterial;
    }
}
