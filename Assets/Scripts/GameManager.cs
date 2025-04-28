using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : EvidenceFolderScript
{
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
        if (evidence == 0)
        {
            SceneManager.LoadScene("Outcome1");
        }
        else if (evidence == 1)
        {
            SceneManager.LoadScene("Outcome2");
        }
        else if (evidence == 2)
        {
            SceneManager.LoadScene("Outcome3");
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
