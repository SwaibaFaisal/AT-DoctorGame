using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ClickableButton : Clickable
{

    [SerializeField] UnityEvent m_event;
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
        m_event.Invoke();

    }
}
