<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128545542/17.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T576860)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Rich Text Editor for ASP.NET Web Forms - How to automatically change the availability of a custom Save button


This example demonstrates how to create a custom **Save** button that is disabled when the document has no changes and is enabled when the document is changed.

## Implementation Details

1. Create a function where you call the [FileSaveCommand.getState](https://docs.devexpress.com/AspNet/js-FileSaveCommand.getState) method to get the state of the default **Save** button.
2. Apply the availability state of the default button to your custom **Save** button.

```jscript
function checkOnChanges() {
    var currectState = richEdit.commands.fileSave.getState();
    var saveButton = richEdit.GetRibbon().GetItemByName("Save");
    saveButton.SetEnabled(currectState.enabled);
}
```

3. Call this function in [DocumentChanged](https://docs.devexpress.com/AspNet/js-ASPxClientRichEdit.DocumentChanged) and [EndCallback](https://docs.devexpress.com/AspNet/js-ASPxClientRichEdit.EndCallback) event handlers.

```jscript
function onDocumentChanged(s, e) {
    checkOnChanges();
}

function onEndCallback(s, e){
    checkOnChanges();
}
```

## Files to Review

* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
* [JavaScript.js](./CS/JavaScript.js) (VB: [JavaScript.js](./VB/JavaScript.js))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-richedit-custom-save-button&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-richedit-custom-save-button&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
