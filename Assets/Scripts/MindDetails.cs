
using UdonSharp;
using UnityEngine;

/// <summary>マインドキューブの情報ビューア。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public sealed class MindDetails : UdonSharpBehaviour
{
    /// <summary>スタックの接続不備における、エラーメッセージ。</summary>
    private const string ERR_NO_STACK =
        "スタックへのリンクが設定されていません。";

#pragma warning disable IDE0044
#pragma warning disable IDE0051
    /// <summary>フォーム本体。</summary>
    [SerializeField]
    private GameObject body;

    /// <summary>マインドキューブを一時預かりするスタック。</summary>
    [SerializeField]
    private MindStack mindStack;
#pragma warning restore IDE0044
#pragma warning restore IDE0051

    /// <summary>
    /// フォーム入力をキャンセルする際に呼び出す、コールバック。
    /// </summary>
    public void OnCancel()
    {
        if (mindStack == null)
        {
            Debug.LogError(ERR_NO_STACK);
            return;
        }
        mindStack.PutoutMindCube();
    }
}
