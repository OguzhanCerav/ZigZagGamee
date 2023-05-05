using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color[] colors;

    Color ikincirenk;
    int birinciRenk;

    public Material zeminMat;

    
    // Start is called before the first frame update
    void Start()
    {
        birinciRenk = Random.Range(0, colors.Length);
        ikincirenk = colors[IkinciRenkSec()];
        zeminMat.color = colors[birinciRenk];
        Camera.main.backgroundColor = colors[birinciRenk];
    }
    // Update is called once per frame
    void Update()
    {
        Color fark = zeminMat.color - ikincirenk;
        if (Mathf.Abs(fark.r) + Mathf.Abs(fark.g) + Mathf.Abs(fark.b)<0.2f)
        {
            ikincirenk = colors[IkinciRenkSec()];
        }
        zeminMat.color = Color.Lerp(zeminMat.color,ikincirenk,0.003f);
        Camera.main.backgroundColor = Color.Lerp(Camera.main.backgroundColor, ikincirenk, 0.0007f);
    }

    int IkinciRenkSec()
    {
        int ikinciRenkIndex;
        ikinciRenkIndex = Random.Range(0, colors.Length);
        while (ikinciRenkIndex==birinciRenk)
        {
            ikinciRenkIndex= Random.Range(0, colors.Length);
        }
        return ikinciRenkIndex;
    }



    
}
