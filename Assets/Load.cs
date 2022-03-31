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

        WWW www = new WWW(Application.streamingAssetsPath + "/Targets/Targets.tag");
        string[] TargetIDs = www.text.Split('\n');
        foreach(string s in TargetIDs)
        {
            targetList.Add(new Target(uint.Parse(s), TargetType.Art));
        }
        foreach(Target t in targetList)
        {
            GameObject newObject = Instantiate(thing, GetComponent<Transform>());
            newObject.name = t.Name;
            newObject.GetComponent<RectTransform>().position = new Vector2(newObject.GetComponent<RectTransform>().position.x + position, newObject.GetComponent<RectTransform>().position.y);
            TextMeshProUGUI textMesh = newObject.GetComponentInChildren<TextMeshProUGUI>();
            textMesh.text = t.Name;
            RawImage image = newObject.GetComponentInChildren<RawImage>();
            www = new WWW(Application.streamingAssetsPath + "/Targets/" + t.ID + "/picture.jpg");
            while (!www.isDone) { }
            Texture2D picture = www.texture;
            image.texture = picture;
            position += 915;
        }
    }
}
