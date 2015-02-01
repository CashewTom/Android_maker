#Android_maker
##概要
eclipseを使わないでandroid projectを作成、ビルド、デバッグ(実機)するためのツール。

##使い方
最初にant,sdk,adbが必要。  
(antのディレクトリ)/bin,(sdk root)/tools,(sdk root)/platform-toolsにPATHを通す。

###プロジェクト作成
Directoryにプロジェクトを作成する親ディレクトリを指定。  
settingに各種設定を記入。  
Createボタンを押す。

###ビルド
Directoryにプロジェクト作成の際に作られたフォルダを指定。  
Buildボタンを押す。(Settingは無関係)

###デバッグ
Directoryにプロジェクト作成の際に作られたフォルダを指定。  
SettingのNameの欄にプロジェクト名を記入。(その他は無関係)
Installボタンを押す。

##Settingの各意味
Target version -> ターゲットのandroidのバージョン  
Name           -> プロジェクト名  
Activity       -> メインアクティビティの名前  
Path           -> プロジェクトのディレクトリ名  
Package        -> パッケージ名  

