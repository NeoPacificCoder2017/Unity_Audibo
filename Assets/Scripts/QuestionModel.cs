using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestionModel {

    public string text;
    public List<AnswerModel> selections;
    public AnswerModel solution;

    public QuestionModel(string aText, string aSolution, bool aBool, int aTag)
    {
        text = aText;
        solution = new AnswerModel(aSolution, aBool, aTag);
        selections = new List<AnswerModel>();
    }

}
