using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDestoryOnLoad : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
