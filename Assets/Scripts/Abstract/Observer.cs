using UdonSharp;

/// <summary>出版-購読型モデルにおける、オブザーバー側のクラス。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public abstract class Observer : UdonSharpBehaviour
{
    /// <summary>
    /// サブジェクトからの呼び出しを受けた際に呼び出す、コールバック。
    /// </summary>
    /// <param name="subject">サブジェクト本体。</param>
    public abstract void OnNotify(Subject subject);
}
