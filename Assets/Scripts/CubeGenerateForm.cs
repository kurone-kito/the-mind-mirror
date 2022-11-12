
using UdonSharp;
using UnityEngine;

/// <summary>マインドキューブ生成フォーム。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]

public class CubeGenerateForm : UdonSharpBehaviour
{
    /// <summary>
    /// 生成ボタンの操作に対して呼び出す、コールバック。
    /// </summary>
    public void OnClickGenerateButton()
    {
        Debug.Log("マインドキューブを生成します。");
    }
}
