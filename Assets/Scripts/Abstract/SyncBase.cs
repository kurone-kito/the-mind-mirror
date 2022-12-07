
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;

/// <summary>同期関係のユーティリティ クラス。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class SyncBase : UdonSharpBehaviour
{
    /// <summary>
    /// 同期の要件不備における、エラーメッセージ。
    /// </summary>
    private const string ERR_INVALID_SYNC =
        "オーナーではないプレイヤーが同期を試みました。";

    /// <summary>
    /// このオブジェクトのオーナーが、ローカルのプレイヤーかどうかを
    /// 判定します。
    /// </summary>
    public bool IsOwner
    {
        get
        {
            VRCPlayerApi player = Networking.LocalPlayer;
            return player == null || Networking.IsOwner(player, gameObject);
        }
    }

    /// <summary>オブジェクトオーナーを奪取・変更します。</summary>
    public virtual void ChangeOwner()
    {
        VRCPlayerApi player = Networking.LocalPlayer;
        if (player != null && !IsOwner)
        {
            Networking.SetOwner(player, gameObject);
        }
    }
    /// <summary>同期を開始します。</summary>
    public virtual void Sync()
    {
        if (!IsOwner)
        {
            Debug.LogWarning(ERR_INVALID_SYNC);
            return;
        }
        RequestSerialization();
        Notify();
    }

    /// <summary>同期変数のアップデートを通知します。</summary>
    protected virtual void Notify()
    {
    }


    /// <summary>
    /// 同期データを受領・適用した後に呼び出す、コールバック。
    /// </summary>
    public override void OnDeserialization()
    {
        Notify();
    }
}
