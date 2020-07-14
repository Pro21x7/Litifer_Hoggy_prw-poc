using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class God : MonoBehaviour
{
    // Start is called before the first frame update
    public string url; 
    public Renderer   QuadBG, Quad0, Quad1, Quad2, Quad3, Quad4, Quad5;
    int milliseconds = 30;
    void Start()
    {

        url="https://s3.ap-south-1.amazonaws.com/open.myhoggy.com/temp/background.png";
        StartCoroutine(LoadFromLikeCoroutine(url,QuadBG));
        Thread.Sleep(1000);
        url="https://images.unsplash.com/photo-1594008037836-5f96d75c00f3?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1950&q=80";
        StartCoroutine(LoadFromLikeCoroutine(url,Quad0));
        Thread.Sleep(milliseconds);
        url="https://images.unsplash.com/photo-1593481580857-e4eb53b6d8bf?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1950&q=80";
        Thread.Sleep(milliseconds);
        StartCoroutine(LoadFromLikeCoroutine(url,Quad1));
        url="https://images.unsplash.com/photo-1593776804558-8dc141d5be27?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1350&q=80";
        Thread.Sleep(milliseconds);
        StartCoroutine(LoadFromLikeCoroutine(url,Quad2));
        url="https://images.unsplash.com/photo-1593381008273-5874bf72c908?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1350&q=80";
        Thread.Sleep(milliseconds);
        StartCoroutine(LoadFromLikeCoroutine(url,Quad3));
        url="https://images.unsplash.com/photo-1565555334087-ef43c7c0a90e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1950&q=80";
        Thread.Sleep(milliseconds);
        StartCoroutine(LoadFromLikeCoroutine(url,Quad4));
        url="https://images.unsplash.com/photo-1592500003030-7694cddc463d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1350&q=80";
        Thread.Sleep(milliseconds);
        StartCoroutine(LoadFromLikeCoroutine(url,Quad5));
        Thread.Sleep(3000);




    }

    // Update is called once per frame
    void Update()
    {
                foreach(Touch touch in Input.touches)
        {
        Thread.Sleep(5000);
        Destroy(GameObject.FindWithTag("kill"));
        Destroy(GameObject.FindWithTag("God"));
        }

    }

        private IEnumerator LoadFromLikeCoroutine(string URL, Renderer obj)
    {
        Debug.Log("Loading ....");
        WWW wwwLoader = new WWW(URL);   // create WWW object pointing to the url
        yield return wwwLoader;         // start loading whatever in that url ( delay happens here )
        print(URL);
        Debug.Log("Loaded");
        //Quad3.transform.GetComponent<Renderer>().material=wwwLoader.texture;
        obj.material.mainTexture = wwwLoader.texture;  // set loaded image
    }
}
