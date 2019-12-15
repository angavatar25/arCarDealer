using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show86specs : MonoBehaviour
{
    public GameObject btnSpecsToyota86;
    public GameObject specsToyota86;
    // Start is called before the first frame update
    void Start()
    {
        btnSpecsToyota86 = GameObject.FindWithTag("showButton86");
        // specsToyota86.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void showToyota86specs() {
        DisableSpecs.showSpecs();
    }
}
