using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance
    {
        get
        {
            if(m_Instance == null)
            {
                m_Instance = (GameManager) FindObjectOfType(typeof(GameManager));

                if(m_Instance == null )
                {
                    GameObject go = new GameObject();
                    go.name = "GAMEMANAGER";
                    m_Instance = go.AddComponent<GameManager>();
                }

                DontDestroyOnLoad(m_Instance.gameObject);
            }
            return m_Instance;
        }
    }

    private static GameManager m_Instance = null;

    public void StartGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void Death()
    {
        SceneManager.LoadScene("Death");
    }
    public void LivingRoom()
    {
        SceneManager.LoadScene("LivingRoom");
    }

    public void Kitchen()
    {
        SceneManager.LoadScene("Kitchen");
    }

    public void HiddenRoom()
    {
        SceneManager.LoadScene("HiddenRoom");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
