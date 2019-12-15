using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeButtonSpecs350z : MonoBehaviour
{
    public static GameObject btnClose;
    public GameObject imageSpecs350z;
    // Start is called before the first frame update
    void Start()
    {
        btnClose = GameObject.FindWithTag("closeButton");
        imageSpecs350z = GameObject.FindWithTag("nissan350zspecs");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void closingSpecs() {
        imageSpecs350z.SetActive(false);
    }
}
