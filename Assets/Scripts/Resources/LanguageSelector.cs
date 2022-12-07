using System;
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;

/// <summary>言語セレクター フォーム。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class LanguageSelector : UdonSharpBehaviour
{
#pragma warning disable IDE0044
    /// <summary>言語ボタン群。</summary>
    [SerializeField]
    private Button[] buttons;

    /// <summary>リソース マネージャー。</summary>
    [SerializeField]
    private ResourcesManager resourcesManager;
#pragma warning restore IDE0044

    /// <summary>英語を選択したときに呼び出す、コールバック。</summary>
    public void OnSelectEnglish()
    {
        ChangeLanguage(TypeLanguage.English);
    }

    /// <summary>日本語を選択したときに呼び出す、コールバック。</summary>
    public void OnSelectJapanese()
    {
        ChangeLanguage(TypeLanguage.Japanese);
    }

    /// <summary>
    /// スペイン語を選択したときに呼び出す、コールバック。
    /// </summary>
    public void OnSelectSpanish()
    {
        ChangeLanguage(TypeLanguage.Spanish);
    }

    /// <summary>言語を切り替えます。</summary>
    private void ChangeLanguage(TypeLanguage language)
    {
        for (int i = buttons.Length; --i >= 0;)
        {
            if (buttons[i] != null)
            {
                buttons[i].interactable = (int)language != i;
            }
        }
        if (resourcesManager != null)
        {
            resourcesManager.Resources =
                resourcesManager.AvailableResources[(int)language];
        }
    }

    /// <summary>
    /// プレイヤーがワールドに入室した際に呼び出される、コールバック。
    /// </summary>
    /// <param name="player">プレイヤー情報。</param>
    public override void OnPlayerJoined(VRCPlayerApi player)
    {
        if (Networking.LocalPlayer != player)
        {
            return;
        }
        Start();
    }

    /// <summary>初期化時に呼び出される、コールバック。</summary>
    private void Start()
    {
        int tzGap = TimeZoneInfo.Local.BaseUtcOffset.Hours;
        bool jp = tzGap == 9;
        bool es1 = tzGap == -3;
        bool es2 = tzGap == -1;
        bool es3 = tzGap == 1;
        string target =
            jp ? nameof(OnSelectJapanese) :
            (es1 || es2 || es3) ? nameof(OnSelectSpanish) :
            nameof(OnSelectEnglish);
        SendCustomEventDelayedFrames(target, 1);
    }
}
