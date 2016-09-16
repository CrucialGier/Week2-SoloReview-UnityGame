using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public BoardManager boardScript;
    public int PlayerFoddPoints = 100;

    [HideInInspector]
    public bool PlayerTurn = true;

    private int level = 3;
	// Use this for initialization
	void Awake ()
    {
        if (instance == null)
        {
            instance = this;
        } else if (instance != this )
        {
            Destroy(this);
        }
        DontDestroyOnLoad(gameObject);
        boardScript = GetComponent<BoardManager>();
        InitGame();
	}

    void InitGame()
    {
        boardScript.SetupScene(level);
    }

    public void GameOver()
    {
        enabled = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
