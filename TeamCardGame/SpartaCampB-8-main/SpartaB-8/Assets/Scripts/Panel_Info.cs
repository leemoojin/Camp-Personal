using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Panel_Info : MonoBehaviour
{
    public Text TxtHighScore;
    public GameObject InfoPanel;
    private int _score;

    private string _sceneName;

    private void Awake()
    {
        InfoPanel.SetActive(false);
    }


    public void Show(string name)
    {
        _sceneName = name;

        if (!PlayerPrefs.HasKey(name))
        {
            _score = PlayerPrefs.GetInt(name);
            Debug.Log($"이름 : {name}, 점수 : {_score}");
            TxtHighScore.text = "BEST\n" + _score;
        }
        else
        {
            _score = PlayerPrefs.GetInt(name);
            TxtHighScore.text = "BEST\n" + _score;
        }

        InfoPanel.SetActive(true);
    }

    public void OnClick_Play()
    {
        SceneManager.LoadScene(_sceneName);
        DataManager.Instance.key = _sceneName;
    }

    public void OnClick_GoMain()
    {
        SceneManager.LoadScene("MainScene");
    }
}