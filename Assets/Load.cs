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
        int position = 0;

        List<Target> targetList = new List<Target>();

        WWW www = new WWW(Application.streamingAssetsPath + "/Targets.tag");
        string[] TargetIDs = www.text.Split('\n');
        foreach(string s in TargetIDs)
        {
            targetList.Add(new Target(uint.Parse(s), TargetType.Art));
        }
        foreach(Target t in targetList)
        {
            GameObject newObject = Instantiate(thing, GetComponent<Transform>());
            newObject.name = t.Name;
            newObject.GetComponent<RectTransform>().position = new Vector2(newObject.GetComponent<RectTransform>().position.x, newObject.GetComponent<RectTransform>().position.y - position);
            TextMeshProUGUI textMesh = newObject.GetComponentInChildren<TextMeshProUGUI>();
            textMesh.text = t.ToString();
            position += 470;
        }
    }
}
