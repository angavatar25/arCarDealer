using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableSpecs350z : MonoBehaviour
{
    public static GameObject imageSpecs350z;
    // Start is called before the first frame update
    void Start()
    {
        imageSpecs350z = GameObject.FindWithTag("nissan350zspecs");
        imageSpecs350z.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void activate() {
        imageSpecs350z.SetActive(true);
    }
}
