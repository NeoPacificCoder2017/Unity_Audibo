using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AnswerModel {

    public string text;
    public bool isCorrect;
    public int tag;

    public AnswerModel(string aText, bool aBool, int aTag)
    {
        text = aText;
        isCorrect = aBool;
        tag = aTag;
    }
    
}
