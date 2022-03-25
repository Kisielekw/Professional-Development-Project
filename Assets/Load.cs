using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Load : MonoBehaviour
{
    public GameObject thing;

    // Start is called before the first frame update
    void Start()
    {
        List<Target> targetList = new List<Target>();

        string[] TargetIDs = File.ReadAllLines("Targets.tag");
        foreach(string s in TargetIDs)
        {
            targetList.Add(new Target(uint.Parse(s), TargetType.Art));
        }
        foreach(Target t in targetList)
        {
            GameObject newObject = Instantiate(thing, GetComponent<Transform>());
            newObject.name = t.Name;
            TextMeshProUGUI textMesh = newObject.GetComponentInChildren<TextMeshProUGUI>();
            textMesh.text = t.ToString();
        }
    }
}
