using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class FactorMenuContrl : MonoBehaviour
{

    public GameObject VideoMenu;

    public VideoPlayer testChongYaVideo;

    //冲压动画
    public void ChongYaBtn()
    {
        VideoMenu.SetActive(true);
        testChongYaVideo.Stop();
        testChongYaVideo.Play();
    }


    //关闭动画 界面
    public void CloseVideoPlay()
    {
        testChongYaVideo.Stop();
        VideoMenu.SetActive(false);
    }

    //返回主场景
    public void BackMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
