using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : EvidenceFolderScript
{
    private int evidence;
    public static GameManager Instance
    {
        get
        {
            if (m_Instance == null)
            {
                m_Instance = (GameManager)FindObjectOfType(typeof(GameManager));

                if (m_Instance == null)
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

    public void EndCase()
    {
        if (evidence >= 0 && evidence <= 2)
        {
            SceneManager.LoadScene($"Outcome{evidence + 1}");
        }
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

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
