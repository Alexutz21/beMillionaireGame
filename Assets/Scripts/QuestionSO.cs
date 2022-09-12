using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(3, 7)] //we use for width and hight of text field
    [SerializeField] string question = "Enter new question text here";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;

    public string GetQuestion()
    {
        return question;
    }
    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }
    public string GetAnswer(int index)
    {
        return answers[index];
    }
}


// ==== For Testing Purpose ====
// public class Test
// {
//     QuestionSO questionSO; //reference to this script object
//     void TestA(){
//        string questionText = questionSO.GetQuestion();
//     }
// }