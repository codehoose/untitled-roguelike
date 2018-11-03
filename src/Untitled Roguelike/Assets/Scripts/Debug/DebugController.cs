using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class DebugController : SingletonBehaviour<DebugController>
{
    public GameObject canvas;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.BackQuote))
        {
            if (canvas.activeInHierarchy)
            {
                canvas.SetActive(false);
            }
            else
            {
                canvas.SetActive(true);
            }
        }
    }
}
