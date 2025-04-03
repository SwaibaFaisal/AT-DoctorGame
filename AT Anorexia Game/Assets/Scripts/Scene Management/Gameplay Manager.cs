using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : SceneObject
{

    [SerializeField] DialogueBox m_dialogueBoxScript;
    [SerializeField] PatientObject m_currentPatientData;
    // Start is called before the first frame update
    void Start()
    {
        SendDataToManagers();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SendDataToManagers()
    {
        m_dialogueBoxScript.SetLists(m_currentPatientData.QuestionText, m_currentPatientData.AnswerText);
        m_dialogueBoxScript.StartSequence();
    }

}
