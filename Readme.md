<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/CustomSeparator/Form1.cs) (VB: [Form1.vb](./VB/CustomSeparator/Form1.vb))
* [HtmlSeparatorForm.cs](./CS/CustomSeparator/HtmlSeparatorForm.cs) (VB: [HtmlSeparatorForm.vb](./VB/CustomSeparator/HtmlSeparatorForm.vb))
* [MyMailMergeExportForm.cs](./CS/CustomSeparator/MyMailMergeExportForm.cs) (VB: [MyMailMergeExportForm.vb](./VB/CustomSeparator/MyMailMergeExportForm.vb))
* [RichSeparatorForm.cs](./CS/CustomSeparator/RichSeparatorForm.cs) (VB: [RichSeparatorForm.vb](./VB/CustomSeparator/RichSeparatorForm.vb))
<!-- default file list end -->
# How to provide custom separators between records in a merged document


<p>This example demonstrates how to provide a custom element to separate each record in a document when none of the standard separators meets your requirements. Handle the <a href="http://help.devexpress.com/#WindowsForms/DevExpressSnapSnapControl_MailMergeExportFormShowingtopic">SnapControl.MailMergeExportFormShowing</a> event and use the <a href="http://help.devexpress.com/#WindowsForms/DevExpressSnapCoreOptionsSnapMailMergeExportOptions_CustomSeparatortopic">SnapMailMergeExportOptions.CustomSeparator</a> property to create a custom separator.</p>
<p>Run this example, click <strong>Finish&Merge</strong> on the <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument16496"><u>Data Tools: Mail Merge</u></a> toolbar and specifya custom separator  that is inserted between each pair of master sections, as illustated in the picture below.<br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-provide-custom-separators-between-records-in-a-merged-document-e5073/15.1.9+/media/499d75dc-4cf6-11e6-80bf-00155d62480c.png"></p>
<p>See also: <a href="https://www.devexpress.com/Support/Center/p/E5074">How to add a custom progress indicator to a Snap application</a>.</p>

<br/>


