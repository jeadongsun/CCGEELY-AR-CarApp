using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class TrackMenuContrl : MonoBehaviour
{
    public GameObject MessageBg1;

    public GameObject MessageBg2;

    public GameObject MessageBg3;

    public GameObject MessageBg4;

    public GameObject TestModel;

    public GameObject Image1;

    public GameObject CameraModel;
    private void Update()
    {
        Image1.transform.rotation = Quaternion.LookRotation(Image1.transform.position - CameraModel.transform.position);
    }

    private void Start()
    {
        MessageBg1.GetComponent<RectTransform>().DOSizeDelta(new Vector2(4, 0), 0);
        MessageBg1.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-951, 10), 0);


        MessageBg2.transform.DOLocalMoveX(-1176,0,false).SetEase(Ease.Linear);

        MessageBg3.transform.DOLocalMoveX(-1216, 0, false).SetEase(Ease.Linear);

        MessageBg4.transform.DOLocalMoveY(-498, 0, false).SetEase(Ease.Linear);

        TestModel.SetActive(false);

        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }



    public void OpenUI()
    {
        MessageBg1.GetComponent<RectTransform>().DOSizeDelta(new Vector2(4, 680), 0.5f);
        MessageBg1.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-951, 10), 0.5f);

        MessageBg2.transform.DOLocalMoveX(-731, 0.5f, false).SetEase(Ease.InOutQuad).SetDelay(0.5f);

        MessageBg3.transform.DOLocalMoveX(-498, 0.5f, false).SetEase(Ease.InOutQuad).SetDelay(1f);

        MessageBg4.transform.DOLocalMoveY(-0, 0.5f, false).SetEase(Ease.InOutQuad).SetDelay(1f).OnComplete(() =>
        {
            TestModel.SetActive(true);
        });
    }

    public void CloseUI()
    {
        TestModel.SetActive(false);

        MessageBg4.transform.DOLocalMoveY(-498, 0.5f, false).SetEase(Ease.InOutQuad);

        MessageBg3.transform.DOLocalMoveX(-1216, 0.5f, false).SetEase(Ease.InOutQuad);

        MessageBg2.transform.DOLocalMoveX(-1176, 0.5f, false).SetEase(Ease.InOutQuad).SetDelay(0.5f);

        MessageBg1.GetComponent<RectTransform>().DOSizeDelta(new Vector2(4, 0), 0.5f).SetDelay(1f) ;
        MessageBg1.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-951, 10), 0.5f).SetDelay(1f) ;
    }
}
