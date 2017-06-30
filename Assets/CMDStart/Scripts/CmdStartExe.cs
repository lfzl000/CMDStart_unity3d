using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CmdStartExe : MonoBehaviour
{
    public Text text;

    private void Awake()
    {
        CmdStart(TestCmd);
    }


    public void CmdStart(UnityAction<string> _callback)
    {
        string CommandLine = Environment.CommandLine;
        if (CommandLine.IndexOf('#') != -1)
        {
            string cmd = CommandLine.Remove(0, CommandLine.IndexOf('#') + 1);
            Debug.LogError("Cmd传入参数：" + cmd);
            _callback("Cmd传入参数：" + cmd);
        }
        else
        {
            Debug.Log("正常启动");
            _callback("正常启动");
        }
    }

    private void TestCmd(string s)
    {
        text.text = s;
    }
}