using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show350zspecs : MonoBehaviour
{
    public GameObject btnSpecsNissan350z;
    public GameObject specsNissan350z;
    // Start is called before the first frame update
    void Start()
    {
        btnSpecsNissan350z = GameObject.FindWithTag("showButton350z");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showNissan350zspecs() {
        DisableSpecs350z.activate();
    }
}
