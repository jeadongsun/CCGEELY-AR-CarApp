using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using DG.Tweening;
public class FactorMenuContrl : MonoBehaviour
{

    public GameObject ChongYaBtnT;

    public GameObject HanJieBtnT;

    public GameObject ZongZhuangBtn;

    public GameObject TuZhuangBtn;

    public GameObject CameraModel;

    public Animator ModelAni;

    public GameObject[] Model_D;

    public GameObject[] Model_Ani;

    public bool isChongYa = false;

    public bool isHanJie = false;

    public bool TuZhuang = false;

    public bool ZongZhuang = false;

    public GameObject Video360Menu;

    public GameObject Video360;

    Vector3 pos;
    Vector3 rota;

    public GameObject Btn360;

    private bool isVideo360 = false;

    public GameObject Camera360;

    private void Start()
    {
        //ModelAni.speed = 0;
    }

    private void Update()
    {
        ChongYaBtnT.transform.rotation = Quaternion.LookRotation(ChongYaBtnT.transform.position - CameraModel.transform.position);
        HanJieBtnT.transform.rotation = Quaternion.LookRotation(HanJieBtnT.transform.position - CameraModel.transform.position);
        ZongZhuangBtn.transform.rotation = Quaternion.LookRotation(ZongZhuangBtn.transform.position - CameraModel.transform.position);
        TuZhuangBtn.transform.rotation = Quaternion.LookRotation(TuZhuangBtn.transform.position - CameraModel.transform.position);
    }


    public void ChongYaBtn()
    {
   

        if (isChongYa == false)
        {
            Model_D[0].SetActive(false);
            Model_Ani[0].SetActive(true);
            isChongYa = true;

            pos = CameraModel.transform.position;
            rota = CameraModel.transform.localEulerAngles;

            CameraModel.transform.DOLocalMove(new Vector3(-380,137,98),1,false);
            CameraModel.transform.DOLocalRotate(new Vector3(42,-132,4),1);

            ChongYaBtnT.SetActive(false);
            Btn360.SetActive(true);
        }
        else
        {
            Model_D[0].SetActive(true);
            Model_Ani[0].SetActive(false);
            isChongYa = false;

 
        }
    }

    public void HanJieBtn()
    {
        if (isHanJie == false)
        {
            isHanJie = true;
            Model_D[1].SetActive(false);
            Model_Ani[1].SetActive(true);

            pos = CameraModel.transform.position;
            rota = CameraModel.transform.localEulerAngles;

            CameraModel.transform.DOLocalMove(new Vector3(-307, 129, -73), 1, false);
            CameraModel.transform.DOLocalRotate(new Vector3(42, -134, 4), 1);

            HanJieBtnT.SetActive(false);
        }
        else
        {
            isHanJie = false;
            Model_D[1].SetActive(true);
            Model_Ani[1].SetActive(false);
        }
    }

    public void TuZhuangBtnClick()
    {
        if (TuZhuang == false)
        {
            TuZhuang = true;
            Model_D[3].SetActive(false);
            Model_Ani[2].SetActive(true);

            pos = CameraModel.transform.position;
            rota = CameraModel.transform.localEulerAngles;

            CameraModel.transform.DOLocalMove(new Vector3(-146, 118, -91), 1, false);
            CameraModel.transform.DOLocalRotate(new Vector3(42, -238, 4), 1);

            TuZhuangBtn.SetActive(false);
        }
        else
        {
            TuZhuang = false;
            Model_D[3].SetActive(true);
            Model_Ani[2].SetActive(false);
        }
    }

    public void ZongZhuangBtnClick()
    {
        if (ZongZhuang == false)
        {
            ZongZhuang = true;
            Model_D[2].SetActive(false);
            Model_Ani[3].SetActive(true);
            Model_Ani[4].SetActive(true);


            pos = CameraModel.transform.position;
            rota = CameraModel.transform.localEulerAngles;

            CameraModel.transform.DOLocalMove(new Vector3(-176, 163, -253), 1, false);
            CameraModel.transform.DOLocalRotate(new Vector3(42, -146, 4), 1);

            ZongZhuangBtn.SetActive(false);
        }
        else
        {
            ZongZhuang = false;
            Model_D[2].SetActive(true);
            Model_Ani[3].SetActive(false);
            Model_Ani[4].SetActive(false);
        }
    }


    public void Play360Menu()
    {
        Video360Menu.SetActive(true);
        Video360.GetComponent<VideoPlayer>().DORewind();
        Video360.GetComponent<VideoPlayer>().Play ();

        isVideo360 = true;
    }

    //返回主场景
    public void BackMainMenu()
    {

        if (isVideo360 == true)
        {
            isVideo360 = false;
            Video360Menu.SetActive(false);
            Video360.GetComponent<VideoPlayer>().DORewind();
            Video360.GetComponent<VideoPlayer>().Stop();

            Camera360.transform.localEulerAngles = new Vector3(0,0,0);
        }
        else if (isChongYa == true || isHanJie == true || ZongZhuang == true || TuZhuang == true)
        {
            CameraModel.transform.DOLocalMove(pos, 1, false);
            CameraModel.transform.DOLocalRotate(rota, 1);

            ChongYaBtnT.SetActive(true);

            Btn360.SetActive(false);

            Model_D[0].SetActive(true);
            Model_Ani[0].SetActive(false);
            isChongYa = false;
            HanJieBtnT.SetActive(true);

            isHanJie = false;
            Model_D[1].SetActive(true);
            Model_Ani[1].SetActive(false);

            ZongZhuangBtn.SetActive(true);

            ZongZhuang = false;
            Model_D[2].SetActive(true);
            Model_Ani[3].SetActive(false);
            Model_Ani[4].SetActive(false);

            TuZhuangBtn.SetActive(true);

            TuZhuang = false;
            Model_D[3].SetActive(true);
            Model_Ani[2].SetActive(false);
        }
        else
        {

            SceneManager.LoadScene("MainMenu");
        }
    }
}
