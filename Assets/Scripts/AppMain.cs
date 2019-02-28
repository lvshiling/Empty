﻿/**
 * 程序主入口
 */

using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class AppMain : MonoBehaviour
{
    /// <summary>
    /// 开始游戏，初始化配置文件
    /// </summary>
    private void Awake()
    {
        //AppConfig.UseAssetBundle = true;
        //AssetBundleManager.Instance.LoadAssetBundleConfig();
        //var prefab = ResourceManager.Instance.SyncLoad<GameObject>("Assets/GameAssets/Prefabs/ExamplePrefab1.prefab");
        //GameObject.Instantiate(prefab);
        //ResourceManager.Instance.AsyncLoad<GameObject>("Assets/GameAssets/Prefabs/ExamplePrefab1.prefab", (obj) =>
        //{
        //    GameObject.Instantiate(obj);
        //});
        AssetBundle manifestBundle = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/AssetBundles");
        var manifest = manifestBundle.LoadAsset<AssetBundleManifest>("AssetBundleManifest");
        var dependencies = manifest.GetAllDependencies("assets/gameassets/prefabs/exampleprefab1.prefab");
        //foreach(var path in )
    }
}
