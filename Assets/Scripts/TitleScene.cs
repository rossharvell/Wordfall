// Copyright 2021, Ross Harvell, All rights reserved

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScene : MonoBehaviour
{
    public string newFilmScene;
    // Start is called before the first frame update

    public Button StartFilmButton;
    
    void Start()
    {
        StartFilmButton.onClick.AddListener(StartFilm);
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
