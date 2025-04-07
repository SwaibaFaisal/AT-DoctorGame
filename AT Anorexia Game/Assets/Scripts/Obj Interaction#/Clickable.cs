using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : SceneObject
{
    protected SpriteRenderer m_spriteRenderer;
    protected bool m_selected = false;
    Color m_initialColor;
    [SerializeField] protected Sprite m_selectedSprite;
    protected Sprite m_unSelectedSprite;

    // Start is called before the first frame update
    public override void Awake()
    {
       m_spriteRenderer = this.GetComponent<SpriteRenderer>();
       m_unSelectedSprite = m_spriteRenderer.sprite;
       base.Awake();
    }

    // Update is called once per frame
    public virtual void Update()
    {
        if (m_selected)
        {
            m_spriteRenderer.sprite = m_selectedSprite;
        }
        else
        {
            m_spriteRenderer.sprite = m_unSelectedSprite;
        }
    }

    public virtual void OnClicked()
    {
        m_selected = !m_selected; 
    }

    public void HoverStart()
    {
       
     
    }

    public void HoverEnd()
    {
      
    }

    public bool Selected { get { return m_selected; } set { m_selected = value; } }
}
