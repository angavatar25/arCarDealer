using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ShowSpecsController : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject toyota86specs;
    public GameObject virtualButtonObject86;
    // Start is called before the first frame update
    void Start()
    {
        toyota86specs = GameObject.FindWithTag("toyota86specs");
        toyota86specs.SetActive(false);
        virtualButtonObject86.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        toyota86specs.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) {
        toyota86specs.SetActive(false);
    }
}
