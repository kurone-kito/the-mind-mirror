
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;

/// <summary>マインドキューブに情報を書き出すクラス。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class MindWriter : UdonSharpBehaviour
{
#pragma warning disable IDE0044
#pragma warning disable IDE0051
    /// <summary>フォーム。</summary>
    [SerializeField]
    private GameObject form;

    /// <summary>名前入力フィールド。</summary>
    [SerializeField]
    private InputField nameInput;
#pragma warning restore IDE0044

    /// <summary>マインドキューブを取得または設定します。</summary>
    public MindCube MindCube { get; set; }

    /// <summary>
    /// フォーム入力をキャンセルする際に呼び出す、コールバック。
    /// </summary>
    public void OnCancel()
    {
        Debug.Log("OnCancel");
    }

    /// <summary>
    /// フォーム入力を確定する際に呼び出す、コールバック。
    /// </summary>
    public void OnDecide()
    {
        Debug.Log("OnDecide");
    }
}
