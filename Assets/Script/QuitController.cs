using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitController : MonoBehaviour
{
    public GameObject quitButton;
    // Start is called before the first frame update
    void Start()
    {
        quitButton = GameObject.FindWithTag("quitButton");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void quitGame() {
        Application.Quit();
    }
}
