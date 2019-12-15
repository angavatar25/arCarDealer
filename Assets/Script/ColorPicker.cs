using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    public Material[] BodyColorMaterial;
    Material CurrentMaterial;
    Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = this.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BlueColor() {
        renderer.material = BodyColorMaterial[0];
        CurrentMaterial = renderer.material;
    }

    public void BlackColor() {
        renderer.material = BodyColorMaterial[1];
        CurrentMaterial = renderer.material;
    }

    public void GreyColor() {
        renderer.material = BodyColorMaterial[2];
        CurrentMaterial = renderer.material;
    }

    public void YellowColor() {
        renderer.material = BodyColorMaterial[3];
        CurrentMaterial = renderer.material;
    }

}
