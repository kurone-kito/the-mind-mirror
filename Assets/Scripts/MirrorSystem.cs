
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;

/// <summary>鏡のオンオフを管理するクラス。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class MirrorSystem : UdonSharpBehaviour
{
#pragma warning disable IDE0044
    /// <summary>鏡本体オブジェクト。</summary>
    [SerializeField]
    private GameObject body = null;

    /// <summary>トグル スイッチ。</summary>
    [SerializeField]
    private Toggle toggle = null;
#pragma warning restore IDE0044

    /// <summary>
    /// トグル スイッチの操作に対して呼び出す、コールバック。
    /// </summary>
    public void OnToggle()
    {
        if (body == null)
        {
            Debug.LogWarning("鏡のオブジェクトが設定されていません。");
            return;
        }
        body.SetActive(toggle != null && toggle.isOn);
    }
}
