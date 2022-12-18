using UdonSharp;
using UnityEngine;

/// <summary>出版-購読型モデルにおける、サブジェクト側のクラス。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class Subject : UdonSharpBehaviour
{
#pragma warning disable IDE0044
    /// <summary>非同期的な通知を行うかどうか。</summary>
    /// <remarks>
    /// 実行中に、この値を動的に操作しないでください。
    /// 一部の通知をキャンセルするなど、予期せぬ動作の原因となります。
    /// </remarks>
    [SerializeField]
    private bool asyncable = false;

    /// <summary>オブザーバーのリスト。</summary>
    /// <remarks>
    /// 非同期モードで実行中に、この値を動的に増減しないでください。
    /// 一部の通知をキャンセルするなど、予期せぬ動作の原因となります。
    /// </remarks>
    [SerializeField]
    private Observer[] observers;
#pragma warning restore IDE0044

    /// <summary>現在の呼び出し位置。</summary>
    private int cursor;

    /// <summary>オブザーバーを呼び出します。</summary>
    public virtual void Notify()
    {
        if (asyncable)
        {
            AsyncNotify();
        }
        else
        {
            SyncNotify();
        }
    }

    /// <summary>非同期的にオブザーバーを呼び出します。</summary>
    public void AsyncNotify()
    {
        if (cursor >= observers.Length)
        {
            cursor = 0;
            return;
        }
        if (observers[cursor] == null)
        {
            cursor++;
            AsyncNotify();
            return;
        }
        observers[cursor++].OnNotify(this);
        SendCustomEventDelayedFrames(nameof(AsyncNotify), 1);
    }

    /// <summary>同期的にオブザーバーを呼び出します。</summary>
    private void SyncNotify()
    {
        foreach (Observer observer in observers)
        {
            if (observer == null)
            {
                continue;
            }
            observer.OnNotify(this);
        }
    }
}
