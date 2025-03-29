using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Patient Object", menuName = "Patient Object")]

public class PatientObject : ScriptableObject
{
    [Header("Basic Info")]


    [Header("Dialogue Variables")]
    [SerializeField][TextArea] List<string> m_questionText;
    [SerializeField][TextArea] List<string> m_answerText;




    public List<string> QuestionText { get { return m_questionText; } }
    public List<string> AnswerText { get { return m_answerText; } }
}
