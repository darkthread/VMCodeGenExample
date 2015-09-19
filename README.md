# VMCodeGenExample
在[NG筆記3-使用TypeScript](http://blog.darkthread.net/post-2014-06-16-angularjs-notes-3-use-typescript.aspx#11075)
一文曾提及「另建程式碼產生器專案，將ViewModel規格轉成JavaScript(或TypeScript)及C#類別以及UI所需設定資料」的做法，
以便在Client及Server端產生一致的Strong Type ViewModel，規格更動時重跑程式即可同步更新。

本專案即為上述做法之概念展示，以XML（Model.xml）定義物件模型，透過[執行期間T4範本](http://blog.darkthread.net/post-2013-06-22-runtime-t4.aspx)
產生BaseModels.ts（TypeScript）及BaseModels.cs（C#），如此在ASP.NET前後端均可以強型別方式使用View Model。

詳細說明請見Blog文章（待補）。
