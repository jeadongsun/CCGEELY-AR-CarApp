using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class FactorMenuContrl : MonoBehaviour
{

    public GameObject ChongYaBtnT;

    public GameObject HanJieBtnT;

    public GameObject ZongZhuangBtn;

    public GameObject TuZhuangBtn;

    public GameObject CameraModel;

    private void Update()
    {
        ChongYaBtnT.transform.rotation = Quaternion.LookRotation(ChongYaBtnT.transform.position - CameraModel.transform.position);
        HanJieBtnT.transform.rotation = Quaternion.LookRotation(HanJieBtnT.transform.position - CameraModel.transform.position);
        ZongZhuangBtn.transform.rotation = Quaternion.LookRotation(ZongZhuangBtn.transform.position - CameraModel.transform.position);
        TuZhuangBtn.transform.rotation = Quaternion.LookRotation(TuZhuangBtn.transform.position - CameraModel.transform.position);
    }




    //返回主场景
    public void BackMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
