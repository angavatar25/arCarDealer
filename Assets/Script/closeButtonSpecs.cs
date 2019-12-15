using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeButtonSpecs : MonoBehaviour
{
    public static GameObject btnClose;
    public GameObject imageSpecs86;
    // Start is called before the first frame update
    void Start()
    {
        btnClose = GameObject.FindWithTag("closeButton");
        imageSpecs86 = GameObject.FindWithTag("toyota86specs");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void closingSpecs() {
        imageSpecs86.SetActive(false);
    }
}
