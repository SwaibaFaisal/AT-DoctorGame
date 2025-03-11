using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{
    SpriteRenderer m_spriteRenderer;
    bool m_selected = false;

    // Start is called before the first frame update
    void Awake()
    {
        m_spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void OnClicked()
    {
        m_selected = !m_selected; 

        if(m_selected)
        {
            m_spriteRenderer.color = Color.red;
        }
        else
        {
            m_spriteRenderer.color = Color.white;
        }

       
    }

    public void HoverStart()
    {
       
     
    }

    public void HoverEnd()
    {
      
    }

    public bool Selected { get { return m_selected; } set { m_selected = value; } }
}
