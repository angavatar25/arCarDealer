using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableSpecs : MonoBehaviour
{
    public static GameObject imageSpecs86;
    // Start is called before the first frame update
    void Start()
    {
        imageSpecs86 = GameObject.FindWithTag("toyota86specs");
        imageSpecs86.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void showSpecs(){
        imageSpecs86.SetActive(true);
    }

    public static void closeSpecs() {
        imageSpecs86.SetActive(false);
    }
}
