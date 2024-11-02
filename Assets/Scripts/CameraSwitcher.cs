using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    //[SerializeField]
    //private Camera camera1,camera2,camera3;

    [SerializeField]
    private List<Camera> cameras = new List<Camera>();
    [SerializeField]
    private Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        ActiveCamera(0);
    }

    // Update is called once per frame
    void Update()
    {
        SwitchCamera();
    }
    

    void ActiveCamera(int index)
    {
        foreach (Camera c in cameras)
        {
            c.gameObject.SetActive(false);
        }

        cameras[index].gameObject.SetActive(true);
    }
    void ActiveCamera(Camera camera)
    {
        foreach (Camera c in cameras)
        {
            c.gameObject.SetActive(false);
        }

        camera.gameObject.SetActive(true);
    }
    void SwitchCamera()
    {
        for(int i = 0; i < cameras.Count; i++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                ActiveCamera(i);
            }
        }
    }
}
