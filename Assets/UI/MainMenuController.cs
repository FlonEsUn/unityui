using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class YourClassName : MonoBehaviour 
{
    public VisualElement ui;

    public Button playButton;
    public Button quitButton;

    private void Awake()
    {
        ui = GetComponent<UIDocument>().rootVisualElement; 
    }

    private void OnEnable()
    {
        playButton = ui.Q<Button>("PlayButton");
        playButton.clicked += OnPlayButtonCLicked;


        quitButton = ui.Q<Button>("QuitButton");
        quitButton.clicked += OnQuitButtonClicked;
    }

 
    private void OnPlayButtonCLicked()
    {
        gameObject.SetActive(false);
    }



    private void OnQuitButtonClicked()
    {
        Application.Quit();
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
    }
}
