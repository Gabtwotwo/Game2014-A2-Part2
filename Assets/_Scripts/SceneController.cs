﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{


    public void OnButtonPressed()
    {
        SceneManager.LoadScene("Platformer");
    }
    public void OnInstructionButtonPressed()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void OnBackButtonPressed()
    {
        SceneManager.LoadScene("Start");
    }
}
