using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LoaderScript : MonoBehaviour
{
    AssetBundle myLoadedAssetBundle;
    float offset = -5;
    List<GameObject> GOs = new List<GameObject>();

    void Start()
    {
        myLoadedAssetBundle = AssetBundle.LoadFromFile("D:/Projects/AssetBundlePractice/AssettBundleTest/Assets/AssetBundles/shape3d");
        if (myLoadedAssetBundle == null)
        {
            Debug.Log("Failed to load AssetBundle!");
            return;
        }
        //GameObject prefab = myLoadedAssetBundle.LoadAsset<GameObject>("Sprite");
        //Instantiate(prefab);
    }

    public void createFromAssettBundle(string gameobjectName)
    {

        GameObject prefab = myLoadedAssetBundle.LoadAsset<GameObject>(gameobjectName);
        GOs.Add(Instantiate(prefab, new Vector3(0, offset, 0), Quaternion.identity));
        offset += 2;
    }

    public void destroyAllAndReset()
    {
        offset = -5;
        for (int i = 0; i < GOs.Count; i++)
        {
            Destroy(GOs[i]);
        }
        Debug.Log(GOs.Count);
        GOs.Clear();
        Debug.Log(GOs.Count);
    }

}
