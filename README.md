# 🪞 THE MIND MIRROR: 貴方の性格を映す鏡がある VRChat ワールド

## ワールド概要

このワールドは、VRChat ユーザーの性格を分析するための VRChat ワールドです。
ワールド上に積まれている小箱『マインドキューブ』を手に取り、併設する装置
『マインドライター』にそれを挿入すると、性格診断フォームが現れます。

問診は非常にシンプルで、生年月日と名前(VRChat の表示名)を入れるだけです。
[Dantalion](https://kurone-kito.github.io/dantalion/) エンジンを用いて、
四柱推命に基づいた性格診断を行い、結果をマインドキューブに書き込みます。  
(生年月日はプライバシー情報なので、計算後即座に破棄し保存も同期もしません)

マインドキューブの色は、そのまま性格診断結果を表しています。
色が似ているキューブ同士は、性格が似ているということを示します。

自分や好きな人、苦手な人などの生年月日も試してみましょう！

## システム要件

- Unity 2019.4.31f1

## 初期設定

1. Unity Hub でこのプロジェクトを指定して開きます。
2. 途中で追加のインポートの確認が出るので、全てインポートします。
3. Unity Editor が起動したら、VRChat SDK Package Resolver を開き、
   未インストールの依存関係がないことを確認します。

この時点で開発可能ですが、Visual Studio Code 環境では Intellisense
が正しく機能しない場合があります。その場合は下記の追加手順を実行します。

1. Unity Editor を閉じます。
2. 当該プロジェクトのルート フォルダにある、
   下記拡張子のファイルをすべて削除します。
   - .csproj
   - .sln
3. 再度当該プロジェクトを開きます。
