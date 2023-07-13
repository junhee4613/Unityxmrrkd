using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    // ��ư�� ������ ����
    public Button startButton;
    public Button optionButton;
    public Button shopButton;
    private UnityAction action;
    void Start()
    {
        // UnityAction�� ����� �̺�Ʈ ���� ���
        action = () => OnButtonClick();
        startButton.onClick.AddListener(action);
        // ���� �޼��带 Ȱ���� �̺�Ʈ ���� ���
        optionButton.onClick.AddListener(delegate { OnButtonClick(); });
        // ���ٽ��� Ȱ���� �̺�Ʈ ���� ���
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
