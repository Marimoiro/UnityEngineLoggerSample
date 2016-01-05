using System;
using UnityEngine;
using System.Collections;
using Object = UnityEngine.Object;

public class DefaultLoggerSample : MonoBehaviour
{

    ILogger logger;
    void Awake()
    {
        logger = new Logger(Debug.logger);
    }

    public void OnClick()
    {
        logger.Log("Default Loggerに流してみる");   
    }
}
