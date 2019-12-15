using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayController : MonoBehaviour
{
    public GameObject playButton;
    // Start is called before the first frame update
    void Start()
    {
        playButton = GameObject.FindWithTag("playButton");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene() {
        SceneManager.LoadScene("main");
    }
}
