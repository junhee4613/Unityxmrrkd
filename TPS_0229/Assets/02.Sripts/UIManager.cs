using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    // 버튼을 연결할 변수
    public Button startButton;
    public Button optionButton;
    public Button shopButton;
    private UnityAction action;
    void Start()
    {
        // UnityAction을 사용한 이벤트 연결 방식
        action = () => OnButtonClick();
        startButton.onClick.AddListener(action);
        // 무명 메서드를 활용한 이벤트 연결 방식
        optionButton.onClick.AddListener(delegate { OnButtonClick(); });
        // 람다식을 활용한 이벤트 연결 방식
        shopButton.onClick.AddListener(() => OnButtonClick());
    }

    public void OnButtonClick()
    {
    }
    public void OnStartClick()
    {
        SceneManager.LoadScene("Level_01");
        SceneManager.LoadScene("Play", LoadSceneMode.Additive);
    }
}
