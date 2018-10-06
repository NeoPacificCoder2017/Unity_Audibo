using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizzController : MonoBehaviour {
    private readonly int questionsCount = 10;
    //private readonly int answersCount = 2;
    //private int score;
    //private bool isQuizzActive;
    private int indexRound;
    private List<QuestionModel> quizzQuestions;
    private string[] allQuestions = new string[20]
    {
        "Question 1,1-a,21-u,1-a,", "Question 2,1-tristesse,15-toilettes 1,1-tristesse", "Question 3,2-b,16-p,2-b", "Question 4,2-svp,9-coiffeur,2-svp", "Question 5,3-c,10-j,3-c",
        "Question 6,3-merci,20-six,3-merci", "Question 7,4-aide,18-tu,4-aide", "Question 8,4-d,26-z,4-d", "Question 9,5-amour,12-ca_va,5-amour", "Question 10,5-e,25-y,5-e",
        "Question 11,6-f,7-g,6-f", "Question 12,6-pardon,17-prendre 1,6-pardon", "Question 13,7-g,9-i,7-g", "Question 14,7-père,2-svp,7-père", "Question 15,8-h,2-b,8-h",
        "Question 16,8-mère,16-que faire,8-mère", "Question 17,9-coiffeur,19-maison 1,9-coiffeur", "Question 18,9-i,17-q,9-i", "Question 19,10-faire,3-merci,10-faire",
        "Question 20,10-j,12-l,10-j"
    };
    //private List<int> indexQuestion;
    //private string[] allImg = new string[45]
    //{
    //    "1-a", "1-tristesse", "2-b", "2-svp", "3-c", "3-merci", " 4-aide", "4-d", "5-amour", "5-e", " 6-f", "7-g", "7-père", "8-h", "8-mère", "9-coiffeur", "9-i", "10-faire", "10-j",
    //    "11-bonjour", "11-k", "12-ca_va", "12-l", "13-m", "13-non", "14+oui", "14-n", "15-o", "15-toilettes 1", "16-p", "16-que faire", "17-prendre 1", "17-q", "18-r", "18-tu", "19-maison 1",
    //    "19-s", "20-six", "20-t", "21-u", "22-v", "23-w", "24-x", "25-y", "26-z"
    //};

    // Components
    private Text questionText;
    private RawImage answerImg1;
    private RawImage answerImg2;

    public string Solution;

    // Use this for initialization
    void Start () {
        //score = 0;
        indexRound = 0;
        //isQuizzActive = true;
        questionText = GameObject.Find("QuestionText").GetComponent<Text>();
        answerImg1 = GameObject.Find("AnswerImg1").GetComponent<RawImage>();
        answerImg2 = GameObject.Find("AnswerImg2").GetComponent<RawImage>();
        InitQuizzQuestions();
        StartQuizz();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void InitQuizzQuestions()
    {
        string[] str;
        //InitIndexQuestion();
        quizzQuestions = new List<QuestionModel>();

        for(int i = 0; i < questionsCount; i++)
        {
            str = allQuestions[i].Split(',');
            quizzQuestions.Add(new QuestionModel(str[0], str[1], str[2], str[3]));
        }

        //InitSelections();
    }

    //private void InitIndexQuestion()
    //{
    //    int randomIndex;
    //    indexQuestion = new List<int>();

    //    while (indexQuestion.Count < questionsCount)
    //    {
    //        randomIndex = Random.Range(0, allQuestions.Length);

    //        if (!indexQuestion.Contains(randomIndex))
    //        {
    //            indexQuestion.Add(randomIndex);
    //        }
    //    }
    //}

    //public void InitSelections()
    //{
    //    bool aBool;
    //    List<int> tagsIndexes = new List<int>();

    //    foreach (QuestionModel q in quizzQuestions)
    //    {
    //        tagsIndexes.Clear();
    //        tagsIndexes = new List<int>(SetRandomIndex(q.solution.tag));
    //        q.selections = new List<AnswerModel>();

    //        foreach (int i in tagsIndexes)
    //        {
    //            aBool = (i.Equals(q.solution.tag)) ? true : false;
    //            q.selections.Add(new AnswerModel(allImg[i], aBool, i));
    //        }
    //    }
    //}

    //private List<int> SetRandomIndex(int aDefaultTag)
    //{
    //    int randomIndex;
    //    List<int> randomIndexes = new List<int>();
    //    randomIndexes.Clear();

    //    while (randomIndexes.Count < (answersCount - 1))
    //    {
    //        randomIndex = Random.Range(0, (answersCount - 1));

    //        if (!randomIndexes.Contains(randomIndex) && (randomIndex != aDefaultTag))
    //        {
    //            randomIndexes.Add(randomIndex);
    //        }
    //    }
        
    //    randomIndex = Random.Range(0, (answersCount));
    //    randomIndexes.Insert(randomIndex, aDefaultTag);

    //    return randomIndexes;
    //}

    private void StartQuizz()
    {
        DisplayQuestion();
    }

    private void DisplayQuestion()
    {
        questionText.text = quizzQuestions[indexRound].text;
        answerImg1.texture = Resources.Load(string.Concat("Images/", quizzQuestions[indexRound].selections[0])) as Texture;
        answerImg2.texture = Resources.Load(string.Concat("Images/", quizzQuestions[indexRound].selections[1])) as Texture;
        Solution = quizzQuestions[indexRound].solution;
    }

    public void OnBtnAnswerClick(int index)
    {
        if (Resources.Load(string.Concat("Images/", Solution)) as Texture == transform.GetChild(index).GetChild(0).GetComponent<RawImage>().texture)
        {
            Debug.Log("Gagné !!");
        }
        else
        {
            Debug.Log("Perdu !!");
        }

        indexRound++;
        DisplayQuestion();
    }
}
