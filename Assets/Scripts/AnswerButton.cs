using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour
{

    public Text answerText;
    public RawImage answerImg;
    private AnswerData answerData;
    private GameController gameController;

    // Use this for initialization
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }

    public void Setup(AnswerData data)
    {
        answerData = data;
        answerText.text = answerData.answerText;
        answerImg.texture = Resources.Load(string.Concat("Images/", answerData.answerText)) as Texture;
    }


    public void HandleClick()
    {
        gameController.AnswerButtonClicked(answerData.isCorrect);
    }
}