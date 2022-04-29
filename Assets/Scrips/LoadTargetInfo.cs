using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadTargetInfo : MonoBehaviour
{
    private GameObject InfoBox = Resources.Load<GameObject>("Target Info");

    void OnClick()
    {
        Debug.Log("I am being pressed");
        GameObject.Find("Targets").active = false;
        GameObject targetInfo = GameObject.Instantiate(InfoBox, GameObject.Find("UI").transform);
    }
}
