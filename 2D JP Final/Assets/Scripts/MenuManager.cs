using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Button NewGameButton;
    public Button ExitGameButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NewGameButton = GameObject.Find("New Game Button").GetComponent<Button>();
        NewGameButton.onClick.AddListener(NewGame);
        ExitGameButton = GameObject.Find("Exit Game Button").GetComponent<Button>();
        ExitGameButton.onClick.AddListener(ExitGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void NewGame()
    {
        SceneManager.LoadScene("StartArea");
    }

    private void ExitGame()
    {
        EditorApplication.isPlaying = false;
        Application.Quit();
    }


}
