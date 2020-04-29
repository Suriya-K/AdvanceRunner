using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool hasEnd = false;
    public static bool isStart = false;
    public float restartDelay = 0.01f;
    public GameObject completedLevelUI;
    public void Start()
    {
        if (SceneManager.GetActiveScene().name == "lv03")
        {
            completedLevelUI = null;
        }
        Time.timeScale = 1.0f;
    }
    public void Update()
    {
        pressStart();
        inputDebug();


    }
    /*
    private void OnGUI()
    {
        if (Event.current.isKey && Event.current.type == EventType.KeyDown)
        {
            //Debug.Log(Event.current.keyCode);
            key = Event.current.keyCode;
        }
    }
    */
    public void completeLevel()
    {
        completedLevelUI.SetActive(true);
        Debug.Log("Completed");
        Invoke("nextLevel", restartDelay);
    }
    public void EndGame()
    {
        if (!hasEnd)
        {
            hasEnd = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    public void Restart()
    {
        PlayerCollision.isPlayerHit = false;
        GameManager.isStart = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void nextLevel()
    {
        if (SceneManager.GetActiveScene().name == "lv02")
        {
            SceneManager.LoadScene("Menu");
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void pressStart()
    {
        if (!isStart)
        {
            FindObjectOfType<Movement>().enabled = false;
            if (Input.GetKeyDown("space"))
            {
                GameObject.Find("spaceText").GetComponent<Text>().enabled = false;
                isStart = true;
                FindObjectOfType<Movement>().enabled = true;
            }
        }
    }
    public void inputDebug()
    {
        // to Reset
        if (Input.GetKeyDown("f1"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        // to Menu
        if (Input.GetKeyDown("f2"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}

