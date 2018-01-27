﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour {

    public GameManager GM;
    private bool _Use;

    #region Funciones Unity

    private void Start()
    {
        _Use = false;
    }

    #endregion

    #region Getters y Setters

    public bool GetUse()
    {
        return _Use;
    }

    public void SetUse(bool use)
    {
        _Use = use;
    }

    #endregion

    public bool CallFromPlayer()
    {
        Debug.Log("Me has dado, soy " + this.name);

        // Si la celda es Receptora...
        if(this.tag == "Cell_R")
        {
            if (GM.SetFirstCell(this))
            {
                _Use = true;
                return true;
            }
        }
        // Si no, la celda es Destino...
        else
        {
            if (GM.SetSecondCell(this))
            {
                _Use = true;
                return true;
            }
        }

        return false;
    }
}