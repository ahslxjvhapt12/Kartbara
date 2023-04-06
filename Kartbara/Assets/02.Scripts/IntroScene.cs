using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour
{
    //MainScene
    [SerializeField] private TextMeshProUGUI text;

    private void Start()
    {
        TextAnim();
    }

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("MainScene");
        }
    }

    void TextAnim()
    {
        Sequence seq = DOTween.Sequence()
        .Append(text.DOFade(0, 1))
        .Join(text.transform.DOScale(new Vector3(1f, 1f), 1))
        .Append(text.DOFade(1, 1))
        .Join(text.transform.DOScale(new Vector3(1.5f, 1.5f), 1))
        .OnComplete(() =>
        {
            TextAnim();
        });
    }
}
