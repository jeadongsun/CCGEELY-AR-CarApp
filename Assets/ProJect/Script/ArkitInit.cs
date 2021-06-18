using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.SceneManagement;
public class ArkitInit : MonoBehaviour
{
    public GameObject ARSessionOrigin;

    public GameObject ARSession;

    List<ARRaycastHit> hit = new List<ARRaycastHit>();
    Vector3 screenCenter = new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 0);

    private ARPlaneManager planeManager;

    ARRaycastManager aRRaycastManager;

    private GameObject SpawnObj;

    public GameObject CarContrlUI;

    public GameObject CarPrefab;

    public GameObject SpawnUI;

    GameObject obj;

    GameObject obj1;

    private void Awake()
    {
        obj = GameObject.Instantiate(ARSessionOrigin,transform.position,transform.rotation);

        obj.name = ARSessionOrigin.name;

        obj1 = GameObject.Instantiate(ARSession, transform.position, transform.rotation);

        obj1.name = ARSession.name;

        aRRaycastManager = GameObject.Find("AR Session Origin").GetComponent<ARRaycastManager>();

        planeManager = GameObject.Find("AR Session Origin").GetComponent<ARPlaneManager>();
    }

    public void OnSpawnContrl()
    {
        if (aRRaycastManager.Raycast(screenCenter, hit, TrackableType.PlaneWithinPolygon))
        {
            var hitPose = hit[0].pose;

            if (SpawnObj == null)
            {

                SpawnObj = Instantiate(CarPrefab, hitPose.position, hitPose.rotation);

                SpawnObj.transform.localScale = new Vector3(1f, 1f, 1f);

                SpawnUI.SetActive(false);
                CarContrlUI.SetActive(true);

            }
        }
    }

    public void BackMainMenu()
    {
        Destroy(obj);
        Destroy(obj1);

        SceneManager.LoadScene("MainMenu");
    }
}
