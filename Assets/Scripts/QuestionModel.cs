using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestionModel {

    public string text;
    public List<string> selections;
    public string solution;

    public QuestionModel(string aText, string aSelection1, string aSelection2, string aSolution)
    {
        text = aText;
        solution = aSolution;
        selections = new List<string>() { aSelection1, aSelection2 };
    }

}
