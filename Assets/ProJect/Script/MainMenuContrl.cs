using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class MainMenuContrl : MonoBehaviour
{
    public GameObject MainMenuBg2;
    public GameObject MainMenuBg3;

    public GameObject[] MainMenuBtn;
    public GameObject[] MainMenuBtn_Text;

    public GameObject AR_CarTrackMenu_Text;
    public GameObject AR_CarShowMenu_Text;
    public GameObject AR_ARCarMenu_Text;
    public GameObject AR_FactorMenu_Text;

    public GameObject MainMenuBg_ipad;
    public GameObject MainMenuBg_iphone;

    void Start()
    {
        StartCoroutine("IEMainMenuContrl");

        string deviceInfo = SystemInfo.deviceModel.ToString();
        bool isPhone = deviceInfo.Contains("iPhone");

        if (isPhone == true)
        {
            MainMenuBg_ipad.SetActive(false);
            MainMenuBg_iphone.SetActive(true);
        }
        else
        {
            MainMenuBg_ipad.SetActive(true);
            MainMenuBg_iphone.SetActive(false);
        }
    }

    IEnumerator IEMainMenuContrl()
    {
       
        foreach (var item in MainMenuBtn)
        {
            item.transform.GetComponent<Image>().DOFade(0, 0).SetEase(Ease.Linear);
        }
        foreach (var item in MainMenuBtn_Text)
        {
            item.transform.GetComponent<Text>().DOFade(0, 0).SetEase(Ease.Linear);
        }

        MainMenuBg2.GetComponent<Image>().DOFade(0, 0).SetEase(Ease.Linear);
        MainMenuBg3.GetComponent<Image>().DOFade(0, 0).SetEase(Ease.Linear);

        yield return new WaitForSeconds(0.5f);

        MainMenuBg2.GetComponent<Image>().DOFade(1, 1).SetEase(Ease.Linear);
        MainMenuBg3.GetComponent<Image>().DOFade(1, 1).SetEase(Ease.Linear);

        foreach (var item in MainMenuBtn)
        {
            item.transform.GetComponent<Image>().DOFade(1, 1).SetEase(Ease.Linear);
        }
        foreach (var item in MainMenuBtn_Text)
        {
            item.transform.GetComponent<Text>().DOFade(1, 1).SetEase(Ease.Linear);
        }
    }

    //ar 虚拟驾驶
    public void OpenAR_ARCarMenu()
    {
        AR_ARCarMenu_Text.GetComponent<Text>().color = new Color(2 / 255, 255 / 255, 255 / 255, 255 / 255);
        SceneManager.LoadScene("CarMenu");
    }

    //进入ar驾驶 界面
    public void OpenAR_CarShowMenu()
    {
        AR_CarShowMenu_Text.GetComponent<Text>().color = new Color(2 / 255, 255 / 255, 255 / 255, 255 / 255);
        SceneManager.LoadScene("CarPaint_Quality_Very Low");
    }
    //ar 扫描模型
    public void OpenAR_CarTrackMenu()
    {
        AR_CarTrackMenu_Text.GetComponent<Text>().color = new Color(2 / 255,255 / 255,255 / 255,255 / 255);
    }
    //工厂沙盘
    public void OpenAR_FactorMenu()
    {
        AR_FactorMenu_Text.GetComponent<Text>().color = new Color(2 / 255, 255 / 255, 255 / 255, 255 / 255);
        SceneManager.LoadScene("JL");
    }

    public void OpenAR_CarTrackMenu_Up()
    {
        AR_CarTrackMenu_Text.GetComponent<Text>().color = new Color(255, 255, 255, 255);
        AR_CarShowMenu_Text.GetComponent<Text>().color = new Color(255, 255, 255, 255);
        AR_ARCarMenu_Text.GetComponent<Text>().color = new Color(255, 255, 255, 255);
        AR_FactorMenu_Text.GetComponent<Text>().color = new Color(255, 255, 255, 255);
    }
}
