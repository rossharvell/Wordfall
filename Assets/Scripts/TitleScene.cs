using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{
    public string newFilmScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartFilm()
    {
        SceneManager.LoadScene(newFilmScene);
    }

    public void QuitFilm()
    {
        Application.Quit();
    }
}