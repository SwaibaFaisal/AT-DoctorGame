using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBox : Clickable
{
    [SerializeField] bool m_correctAnswer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnClicked()
    {
        base.OnClicked();   
    }

    public bool CorrectAnswer {  get { return m_correctAnswer; } }
}
