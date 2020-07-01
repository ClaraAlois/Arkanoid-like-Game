using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour
{
    private Text text;
    public int marks;

    void Start()
    {
        text = GameObject.Find("points").GetComponent<Text>();
        marks = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updatePoints()
    {
        marks++;
        text.text = marks.ToString();
    }
}
