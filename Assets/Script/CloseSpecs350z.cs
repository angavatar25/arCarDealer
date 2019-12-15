using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseSpecs350z : MonoBehaviour
{
    public GameObject closeButton350z;
    public GameObject nissan350zspecs;
    // Start is called before the first frame update
    void Start()
    {
        closeButton350z = GameObject.FindWithTag("showButton350z");
        GameObject nissan350zspecs = GameObject.FindWithTag("nissan350zspecs");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void closeSpecs350z() {
        nissan350zspecs.SetActive(false);
    }
}
