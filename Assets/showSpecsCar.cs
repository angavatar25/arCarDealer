using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showSpecsCar : MonoBehaviour
{
    public GameObject btnShowToyota;
    public GameObject toyotaSpecs;
    // Start is called before the first frame update
    void Start()
    {
        btnShowToyota = GameObject.FindWithTag("showButton86");
        toyotaSpecs = GameObject.FindWithTag("toyota86specs");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showSpecs() {
        toyotaSpecs.SetActive(true);
    }
}
