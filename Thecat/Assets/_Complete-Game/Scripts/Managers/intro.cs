using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class intro : MonoBehaviour
{
    public RawImage rawimage;
    public VideoPlayer videoPayer;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Playvideo());
    }

    // Update is called once per frame
    IEnumerator Playvideo()
    {
        videoPayer.Prepare();
        WaitForSeconds wait = new WaitForSeconds(1);
        while (!videoPayer.isPrepared)
        {
            yield return wait;
            break;
        }
        rawimage.texture = videoPayer.texture;
        videoPayer.Play();
        for (int i = 1; i <= 32; i++)
        {

            if (Input.GetButton("Fire1"))
            {
                break;
            }
            else
                yield return wait;
        }
        //WaitForSeconds c = new WaitForSeconds(32);
        //yield return c;
        Application.LoadLevel(1);
    }
}
