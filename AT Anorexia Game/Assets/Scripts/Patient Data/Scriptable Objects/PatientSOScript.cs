using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Patient Object", menuName = "Patient Object")]

public class PatientObject : ScriptableObject
{
    [Header("Dialogue Variables")]
    [SerializeField][TextArea] List<string> m_questionText;
    [SerializeField][TextArea] List<string> m_answerText;


    [Header("Food Diary Variables")]
    [SerializeField] float m_Test;

}
