# KB9807-XamDataGrid-GetRecordsInView
XamDataGrid: 実際に画面に表示されているレコード(行)のみのコレクションを取得する方法

https://kb.jp.infragistics.com/?p=9807

XamDataGrid にバインドされているデータ数が多く縦スクロールバーが表示されている状態で、
画面上に表示されているレコード（行）のみを取得する際には、GetRecordsInView メソッドを
利用することができます。

```CS
private void Button_Click(object sender, RoutedEventArgs e)
{
    var recordsInView = this.xamDataGrid1.GetRecordsInView(false);
}
```

GetRecordsInView メソッド – Infragistics WPF™ ヘルプ
https://jp.infragistics.com/help/wpf/infragisticswpf.datapresenter~infragistics.windows.datapresenter.datapresenterbase~getrecordsinview(boolean)

※ GetRecordsInView メソッドの引数は、XamDataGrid の子階層を含めてレコードを取得する場合には true を、XamDataGrid の親階層のみレコードを取得する場合には false を設定します。
