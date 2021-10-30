using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    public AudioSource AudioSceneChange;

    public string SceneName;

    // Start is called before the first frame update
    void Start()
    {
        AudioSceneChange.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!AudioSceneChange.isPlaying)
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
