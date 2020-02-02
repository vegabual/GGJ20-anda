﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerBehaviour : MonoBehaviour
{

    public string NivelNombre;
    public void CargarJuego(){
        SceneManager.LoadScene(NivelNombre);

    }

    public void Salir(){
        Application.Quit();
    }
}
