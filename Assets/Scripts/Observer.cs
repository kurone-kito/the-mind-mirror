
using UdonSharp;

/// <summary>出版-購読型モデルにおける、オブザーバー側のクラス。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class Observer : UdonSharpBehaviour
{
    /// <summary>
    /// サブジェクト本体。
    /// </summary>
    public Subject Subject { get; set; }

    /// <summary>
    /// サブジェクトからの呼び出しを受けた際に呼び出す、コールバック。
    /// </summary>
    public virtual void OnNotify()
    {
    }

    /// <summary>
    /// サブジェクトの所有権が成立した際に呼び出す、コールバック。
    /// </summary>
    public virtual void OnSubjectGotOwner()
    {
    }
}
