using UdonSharp;
using UnityEngine;

/// <summary>リソース変化の通知を受けるクラス。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class ResourcesObserver : Observer
{
    /// <summary>
    /// リソース マネージャーの接続不備における、エラーメッセージ。
    /// </summary>
    private const string ERR_NO_RESOURCE_MANAGER =
        "リソース マネージャーへのリンクが設定されていません。";

#pragma warning disable IDE0044
    /// <summary>マルチ リソース対応ラベル一覧。</summary>
    [SerializeField]
    private Labels[] labels = new Labels[0];
#pragma warning restore IDE0044

    /// <summary>
    /// 静的ラベルの表示状態を更新します。
    /// </summary>
    /// <param name="labels">静的ラベル一覧。</param>
    /// <param name="language">言語タイプ。</param>
    public static void UpdateLabels(Labels[] labels, TypeLanguage language)
    {
        if (labels == null)
        {
            return;
        }
        foreach (Labels label in labels)
        {
            if (label == null)
            {
                continue;
            }
            for (int i = label.Length; --i >= 0;)
            {
                if (label[i] == null)
                {
                    continue;
                }
                label[i].SetActive((int)language == i);
            }
        }
    }

    /// <summary>
    /// 外部のサブジェクトの通知があった際に、呼び出し元がリソース
    /// マネージャーだった場合に、ラベルの表示状態を更新します。
    /// </summary>
    /// <param name="subject">サブジェクト本体。</param>
    /// <param name="labels">静的ラベル一覧。</param>
    public static void OnNotifyWhenResourcesManager(
        Subject subject, Labels[] labels)
    {
        if (subject == null)
        {
            return;
        }
        ResourcesManager res = subject.GetComponent<ResourcesManager>();
        if (res == null)
        {
            return;
        }
        if (res.Resources == null)
        {
            Debug.LogWarning(ERR_NO_RESOURCE_MANAGER);
            return;
        }
        UpdateLabels(labels, res.Resources.Type);
    }

    /// <summary>言語設定が変化した際に呼び出されます。</summary>
    /// <param name="subject">サブジェクト本体。</param>
    public override void OnNotify(Subject subject)
    {
        OnNotifyWhenResourcesManager(subject, labels);
    }
}
