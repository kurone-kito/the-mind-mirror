
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;

/// <summary>出版-購読型モデルにおける、サブジェクト側のクラス。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class Subject : SyncBase
{
#pragma warning disable IDE0044
    /// <summary>オブザーバーのリスト。</summary>
    [SerializeField]
    private Observer[] observers;
#pragma warning restore IDE0044

    /// <summary>所有者が変化したことをオブザーバーへ通知します。</summary>
    protected void NotifyGotOwner()
    {
        foreach (Observer observer in observers)
        {
#pragma warning disable IDE0031
            if (observer != null)
            {
                observer.OnSubjectGotOwner();
            }
#pragma warning restore IDE0031
        }
    }

    /// <summary>オブジェクトオーナーを奪取・変更します。</summary>
    public override void ChangeOwner()
    {
        base.ChangeOwner();
        if (IsOwner)
        {
            NotifyGotOwner();
        }
    }

    /// <summary>
    /// 所有者が変化したことを受けた際に呼び出す、コールバック。
    /// </summary>
    /// <param name="player">プレイヤー情報。</param>
    public override void OnOwnershipTransferred(VRCPlayerApi player)
    {
        if (IsOwner)
        {
            NotifyGotOwner();
        }
    }

    /// <summary>
    /// プレイヤーがワールドに入室した際に呼び出される、コールバック。
    /// </summary>
    /// <param name="player">プレイヤー情報。</param>
    public override void OnPlayerJoined(VRCPlayerApi player)
    {
        if (Networking.LocalPlayer == player)
        {
            foreach (Observer observer in observers)
            {
                if (observer != null)
                {
                    observer.Subject = this;
                }
            }
        }
    }

    /// <summary>オブザーバーを呼び出します。</summary>
    protected override void Notify()
    {
        foreach (Observer observer in observers)
        {
#pragma warning disable IDE0031
            if (observer != null)
            {
                observer.OnNotify();
            }
#pragma warning restore IDE0031
        }
    }
}
