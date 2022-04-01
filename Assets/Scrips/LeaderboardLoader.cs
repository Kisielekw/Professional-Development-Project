using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LeaderboardLoader : MonoBehaviour
{
    public GameObject LeaderboardDisplay;
    // Start is called before the first frame update
    void Start()
    {
        int position = 0;
        //For the mean time we will just print out the players file saved in the StreamAssets folder
        //WWW www = new WWW(Application.streamingAssetsPath + "Players");
        //while (!www.isDone) { }
        //Debug.Log(www.text);
        //string[] players = www.text.Split('\n');
        for (int i = 0; i < 10; i++)
        {
            //if (players[i] != null)
            //{
            GameObject Person = GameObject.Instantiate(LeaderboardDisplay, transform);
            Person.GetComponent<RectTransform>().position = new Vector2(Person.GetComponent<RectTransform>().position.x, Person.GetComponent<RectTransform>().position.y - position);
            Person.GetComponent<TextMeshProUGUI>().text = i.ToString();
            position += 110;
            //}
            //else
            //{
            //    break;
            //}
        }
    }
}
