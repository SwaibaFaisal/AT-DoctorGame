using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public enum E_Scenes
{
    MENU,

    GAME,

    END
}
public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchScene(int _scene)
    {
        SceneManager.LoadScene(_scene);
    }

}
