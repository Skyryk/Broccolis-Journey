﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //This allows us to load scenes

#pragma warning disable 0618

public class Main : MonoBehaviour
{
    public static Main S;

    public GameObject shopMenu;

    // Start is called before the first frame update
    void Start()
    {
        S = this;
    }

    //Loads the scene when the player loads the game. Called from CharacterController.cs
    public void PlatformerFailed()
    {
        Debug.Log("Game Over");
        SceneManager.LoadScene("Spooky Platformer");
    }

    public void LoadNewGame()
    {
        SceneManager.LoadScene("Hub");
    }
}
