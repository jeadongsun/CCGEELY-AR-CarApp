using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class CarRevealContrl : MonoBehaviour
{

    public GameObject[] CarPaintItem;

    public GameObject[] WheelBtnItem;

    public GameObject[] BgBtnItem;

    public GameObject PaintIBg;

    public GameObject[] CarPaintBtnItem;

    public Vector2[] CarPaintBtnPos;

    public GameObject[] ModelCarBody;

    public Material[] ModelCarPint_Mate;

    public GameObject[] Btn_OnSelect;

    public GameObject[] Wheel_OnSelect;

    public GameObject[] Bg_OnSelect;

    public GameObject[] Btn_Text;

    private bool CarPaint = false;

    private bool WheelMenu = false;

    private bool BgMenu = false;

    public GameObject WheelBg;

    public GameObject BggMenu;

    public Material[] CarRevealSkybox;

    public GameObject[] CarWheelObj;



    IEnumerator Start()
    {

        foreach (var item in CarPaintItem)
        {
            item.transform.DOScale(0, 0);
        }
        foreach (var item in WheelBtnItem)
        {
            item.transform.DOScale(0, 0);
        }
        foreach (var item in BgBtnItem)
        {
            item.transform.DOScale(0, 0);
        }


        PaintIBg.GetComponent<RectTransform>().DOSizeDelta(new Vector2(0, 160), 0);
        PaintIBg.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-334, 155), 0);

        WheelBg.GetComponent<RectTransform>().DOSizeDelta(new Vector2(0, 160), 0);
        WheelBg.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-354, 155), 0);

        BggMenu.GetComponent<RectTransform>().DOSizeDelta(new Vector2(0, 160), 0);
        BggMenu.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-159, 155), 0);

        for (int i = 0; i < CarPaintBtnItem.Length; i++)
        {
            CarPaintBtnItem[i].GetComponent<RectTransform>().DOAnchorPos(CarPaintBtnPos[i], 1).SetEase(Ease.Linear);
            yield return new WaitForSeconds(0.3f);
        }

        Bg1_Btn();
        Color_CarRedBtn();
        Wheel_1Btn();
    }



    public void OpenCarPaint()
    {
        CarPaintBtnItem_Contrl(0);

        PaintIBg.GetComponent<RectTransform>().DOSizeDelta(new Vector2(760, 160), 0.8f);
        PaintIBg.GetComponent<RectTransform>().DOAnchorPos(new Vector2(45, 155), 0.8f);

        StartCoroutine("CarPaintItem_Effect_Open");

        if (WheelMenu == true)
        {
            StartCoroutine("OpenWheelHubBtn_EffectClose");

            WheelBg.GetComponent<RectTransform>().DOSizeDelta(new Vector2(0, 160), 0.5f).SetDelay(0.5f);
            WheelBg.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-354, 155), 0.5f).SetDelay(0.5f);
        }
        if (BgMenu == true)
        {
            BggMenu.GetComponent<RectTransform>().DOSizeDelta(new Vector2(0, 160), 0.5f).SetDelay(0.5f);
            BggMenu.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-159, 155), 0.5f).SetDelay(0.5f);

            StartCoroutine("BgMenuBtnClick_Close_Effect");
        }
    }
    IEnumerator CarPaintItem_Effect_Open()
    {
        foreach (var item in CarPaintItem)
        {
            item.transform.DOScale(1, 0.5f).SetEase(Ease.InCubic);
            yield return new WaitForSeconds(0.1f);
        }
        CarPaint = true;
    }
    IEnumerator CarPaintItem_Effect_Close()
    {
        foreach (var item in CarPaintItem)
        {
            item.transform.DOScale(0, 0.5f).SetEase(Ease.InCubic);
            yield return new WaitForSeconds(0.1f);
        }
        CarPaint = false;
    }

    public void OpenWheelHubBtn()
    {
        CarPaintBtnItem_Contrl(1);

        if (CarPaint == true)
        {
            PaintIBg.GetComponent<RectTransform>().DOSizeDelta(new Vector2(0, 160), 0.5f).SetDelay(0.5f);
            PaintIBg.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-334, 155), 0.5f).SetDelay(0.5f);
            StartCoroutine("CarPaintItem_Effect_Close");
        }
        if (BgMenu == true)
        {
            BggMenu.GetComponent<RectTransform>().DOSizeDelta(new Vector2(0, 160), 0.5f).SetDelay(0.5f);
            BggMenu.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-159, 155), 0.5f).SetDelay(0.5f);

            StartCoroutine("BgMenuBtnClick_Close_Effect");
        }

        WheelBg.GetComponent<RectTransform>().DOSizeDelta(new Vector2(700, 160), 0.8f);
        WheelBg.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-5, 155), 0.8f);

        StartCoroutine("OpenWheelHubBtn_EffectOpen");
    }

    IEnumerator OpenWheelHubBtn_EffectOpen()
    {
        WheelMenu = true;
        foreach (var item in WheelBtnItem)
        {
            item.transform.DOScale(1, 0.5f).SetEase(Ease.InCubic);
            yield return new WaitForSeconds(0.1f);
        }
    }
    IEnumerator OpenWheelHubBtn_EffectClose()
    {
        WheelMenu = false;
        foreach (var item in WheelBtnItem)
        {
            item.transform.DOScale(0, 0.5f).SetEase(Ease.InCubic);
            yield return new WaitForSeconds(0.1f);
        }
    }

    public void BgMenuBtnClick()
    {
        CarPaintBtnItem_Contrl(2);
        if (WheelMenu == true)
        {
            StartCoroutine("OpenWheelHubBtn_EffectClose");

            WheelBg.GetComponent<RectTransform>().DOSizeDelta(new Vector2(0, 160), 0.5f).SetDelay(0.5f);
            WheelBg.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-354, 155), 0.5f).SetDelay(0.5f);
        }
        if (CarPaint == true)
        {
            PaintIBg.GetComponent<RectTransform>().DOSizeDelta(new Vector2(0, 160), 0.5f).SetDelay(0.5f);
            PaintIBg.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-334, 155), 0.5f).SetDelay(0.5f);
            StartCoroutine("CarPaintItem_Effect_Close");
        }

        BggMenu.GetComponent<RectTransform>().DOSizeDelta(new Vector2(700, 160), 0.8f);
        BggMenu.GetComponent<RectTransform>().DOAnchorPos(new Vector2(135, 155), 0.8f);

        StartCoroutine("BgMenuBtnClick_Open_Effect");
    }
    IEnumerator BgMenuBtnClick_Open_Effect()
    {
        BgMenu = true;
        foreach (var item in BgBtnItem)
        {
            item.transform.DOScale(1, 0.5f).SetEase(Ease.InCubic);
            yield return new WaitForSeconds(0.1f);
        }
    }
    IEnumerator BgMenuBtnClick_Close_Effect()
    {
        BgMenu = false;
        foreach (var item in BgBtnItem)
        {
            item.transform.DOScale(0, 0.5f).SetEase(Ease.InCubic);
            yield return new WaitForSeconds(0.1f);
        }
    }


    void CarPaintBtnItem_Contrl(int index)
    {
        foreach (var item in CarPaintBtnItem)
        {
            item.GetComponent<Button>().interactable = true;
        }

        foreach (var item in Btn_Text)
        {
            item.GetComponent<Text>().DOColor(new Color(255, 255, 255, 255), 0f);
        }
        CarPaintBtnItem[index].GetComponent<Button>().interactable = false;
        Btn_Text[index].GetComponent<Text>().DOColor(new Color(2 / 255, 255 / 255, 255 / 255, 255 / 255), 0f);
    }

    public void BackMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Color_CarBlueBtn()
    {
        ColorContrl(0);

        foreach (var item in ModelCarBody)
        {
            item.GetComponent<Renderer>().material = ModelCarPint_Mate[1];
        }
    }

    public void Color_CarRedBtn()
    {
        ColorContrl(1);

        foreach (var item in ModelCarBody)
        {
            item.GetComponent<Renderer>().material = ModelCarPint_Mate[0];
        }
    }
    public void Color_CarHuiBtn()
    {
        ColorContrl(2);

        foreach (var item in ModelCarBody)
        {
            item.GetComponent<Renderer>().material = ModelCarPint_Mate[2];
        }
    }
    public void Color_CarJinSeBtn()
    {
        ColorContrl(3);

        foreach (var item in ModelCarBody)
        {
            item.GetComponent<Renderer>().material = ModelCarPint_Mate[3];
        }
    }
    public void Color_CarZiSeBtn()
    {
        ColorContrl(4);

        foreach (var item in ModelCarBody)
        {
            item.GetComponent<Renderer>().material = ModelCarPint_Mate[4];
        }
    }
    public void Color_CarBaiSeBtn()
    {
        ColorContrl(5);

        foreach (var item in ModelCarBody)
        {
            item.GetComponent<Renderer>().material = ModelCarPint_Mate[5];
        }
    }

    public void Wheel_1Btn()
    {
        WheelContrl(0);
    }
    public void Wheel_2Btn()
    {
        WheelContrl(1);
    }
    public void Wheel_3Btn()
    {
        WheelContrl(2);
    }

    public void Bg1_Btn()
    {
        BgContrl(0);
        RenderSettings.skybox = CarRevealSkybox[0];
    }

    public void Bg2_Btn()
    {
        BgContrl(1);
        RenderSettings.skybox = CarRevealSkybox[1];
    }

    public void Bg3_Btn()
    {
        BgContrl(2);
        RenderSettings.skybox = CarRevealSkybox[2];
    }


    void ColorContrl(int index)
    {
        foreach (var item in Btn_OnSelect)
        {
            item.SetActive(false);
        }
        foreach (var item in CarPaintItem)
        {
            item.GetComponent<Image>().enabled = false;
        }
        CarPaintItem[index].GetComponent<Image>().enabled = true;

        Btn_OnSelect[index].SetActive(true);
    }

    void WheelContrl(int index)
    {
        foreach (var item in Wheel_OnSelect)
        {
            item.SetActive(false);
        }
        Wheel_OnSelect[index].SetActive(true);


        foreach (var item in CarWheelObj)
        {
            item.SetActive(false);
        }
        CarWheelObj[index].SetActive(true);


        foreach (var item in WheelBtnItem)
        {
            item.GetComponent<Image>().enabled = false;
        }
        WheelBtnItem[index].GetComponent<Image>().enabled = true;
    }

    void BgContrl(int index)
    {
        foreach (var item in Bg_OnSelect)
        {
            item.SetActive(false);
        }
        Bg_OnSelect[index].SetActive(true);
    }
}
