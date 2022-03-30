using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

public enum TargetType
{
    Art, Architecture
}

public class Target : MonoBehaviour
{
    private TargetType type;
    private string targetName;
    private uint targetID;
    private string targetDiscription;

    public string Name
    {
        get
        {
            return targetName;
        }
    }
    public string Description
    {
        get
        {
            return targetDiscription;
        }
    }
    public uint ID
    {
        get
        {
            return targetID;
        }
    }

    public Target(uint pID, TargetType pType)
    {
        targetID = pID;
        type = pType;
        WWW www = new WWW(Application.streamingAssetsPath + "/Targets/" + ID.ToString() + ".tag");
        while (!www.isDone)
        {

        }
        string[] targetFile = www.text.Split('\n');
        targetName = targetFile[0];
        targetDiscription = targetFile[1];
    }

    public override string ToString()
    {
        return Name + ":\n" + Description;
    }
}
