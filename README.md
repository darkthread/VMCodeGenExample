# VMCodeGenExample
在[NG筆記3-使用TypeScript](http://blog.darkthread.net/post-2014-06-16-angularjs-notes-3-use-typescript.aspx#11075)
一文曾提及「另建程式碼產生器專案，將ViewModel規格轉成JavaScript(或TypeScript)、C#類別」的做法，方便Client及Server端共享一致的強型別ViewModel，規格如有更動，重跑程式產生器就能同步更新。

本專案即為上述做法之概念展示(Proof Of Concept, POC)，以XML（Model.xml）定義物件模型，透過[執行期間T4範本](http://blog.darkthread.net/post-2013-06-22-runtime-t4.aspx)
產生BaseModels.ts（TypeScript）及BaseModels.cs（C#），如此在ASP.NET前後端均可以強型別方式使用View Model。

詳細說明請見[Blog文章](http://blog.darkthread.net/post-2015-09-21-cs-ts-vm-codegen.aspx)。

聲明：這個範例旨在展示View Model程式碼產生器之概念及可行性，在防呆驗證、擴充性及支援廣泛度上還有很大的改良空間，留待大家自行研究發揮。
