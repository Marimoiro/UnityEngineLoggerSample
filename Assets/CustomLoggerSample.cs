using System;
using UnityEngine;
using System.Collections;
using Object = UnityEngine.Object;

public class CustomLoggerSample : MonoBehaviour
{

    ILogger logger;
    void Awake()
    {
        Debug.logger.logEnabled = false;
        logger = new Logger(new FaceLogHandler());
    }

    public void OnClick()
    {
        logger.Log("顔文字ロガー！");
    }

    public void OnError()
    {
        logger.LogException(new Exception("エラー起こしちゃった"));
    }
}

public class FaceLogHandler : ILogHandler
{
    public void LogFormat(LogType logType, Object context, string format, params object[] args)
    {
        Debug.logger.LogFormat(logType, "(・∀・)" + context, format, args);
    }

    public void LogException(Exception exception, Object context)
    {
        Debug.logger.LogException(new Exception("(´・ω・｀)", exception), context);
    }
}
