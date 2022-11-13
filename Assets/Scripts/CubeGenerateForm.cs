
using UdonSharp;
using UnityEngine;

/// <summary>マインドキューブ生成フォーム。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]

public class CubeGenerateForm : UdonSharpBehaviour
{
#pragma warning disable IDE0044
    /// <summary>生成するマインドキューブ本体。</summary>
    [SerializeField]
    private GameObject source = null;
    /// <summary>生成位置のオフセット座標。</summary>
    [SerializeField]
    private Vector3 offset;
#pragma warning restore IDE0044

    /// <summary>
    /// 生成ボタンの操作に対して呼び出す、コールバック。
    /// </summary>
    public void OnClickGenerateButton()
    {
        if (source == null)
        {
            Debug.LogWarning("マインドキューブのオブジェクトが設定されていません。");
            return;
        }
        GameObject _ = Instantiate(source, transform.position + offset, transform.rotation);
    }
}
