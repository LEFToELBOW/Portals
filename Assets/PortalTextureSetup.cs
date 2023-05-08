using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextureSetup : MonoBehaviour
{
    [SerializeField] private Camera camera_A;
    [SerializeField] private Camera camera_B;

    [SerializeField] private Material camera_A_Mat;
    [SerializeField] private Material camera_B_Mat;


    [SerializeField] private Camera camera_C;
    [SerializeField] private Camera camera_D;

    [SerializeField] private Material camera_C_Mat;
    [SerializeField] private Material camera_D_Mat;

    [SerializeField] private Camera camera_E;
    [SerializeField] private Camera camera_F;

    [SerializeField] private Material camera_E_Mat;
    [SerializeField] private Material camera_F_Mat;

    [SerializeField] private Camera camera_G;
    [SerializeField] private Camera camera_H;

    [SerializeField] private Material camera_G_Mat;
    [SerializeField] private Material camera_H_Mat;

    [SerializeField] private Camera camera_I;
    [SerializeField] private Camera camera_J;

    [SerializeField] private Material camera_I_Mat;
    [SerializeField] private Material camera_J_Mat;

    [SerializeField] private Camera camera_K;

    [SerializeField] private Material camera_K_Mat;




    private void Setup(Camera camera, Material cameraMat)
    {
        if(camera.targetTexture != null)
        {
            camera.targetTexture.Release();
        }
        camera.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMat.mainTexture = camera.targetTexture;
    }

    private void Start()
    {
        Camera[] cams = {camera_A, camera_B, camera_C, camera_D, camera_E, camera_F, camera_G, camera_H, camera_I, camera_J, camera_K};
    
        Material[] mats = {camera_A_Mat, camera_B_Mat, camera_C_Mat, camera_D_Mat, camera_E_Mat, camera_F_Mat, camera_G_Mat, camera_H_Mat, camera_I_Mat, camera_J_Mat, camera_K_Mat};

        for(int i = 0; i < cams.Length; i++)
        {
            Setup(cams[i], mats[i]);
        }
    }
}
