﻿<link href="~/Content/Styles.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="~/Content/Scripts.js"></script>

@Html.DevExpress().CheckBox(
	Sub(settings)
		settings.Name = "resizing"
		settings.Text = "Enable Resizing"
		settings.Properties.ClientSideEvents.CheckedChanged = "function(s, e) { grid.PerformCallback({ 'resizing': s.GetChecked() }); }"
	End Sub).GetHtml()

@Html.Partial("GridViewPartial")

