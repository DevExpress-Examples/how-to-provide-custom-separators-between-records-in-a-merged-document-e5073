﻿Namespace CustomSeparator
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim galleryItemGroup4 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim galleryItemGroup5 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim galleryItemGroup6 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim borderInfo2 As New DevExpress.XtraRichEdit.Model.BorderInfo()
            Dim chartControlCommandGalleryItemGroup2DColumn2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn()
            Dim createBarChartItem2 As New DevExpress.XtraCharts.UI.CreateBarChartItem()
            Dim createFullStackedBarChartItem2 As New DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem()
            Dim createSideBySideFullStackedBarChartItem2 As New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem()
            Dim createSideBySideStackedBarChartItem2 As New DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem()
            Dim createStackedBarChartItem2 As New DevExpress.XtraCharts.UI.CreateStackedBarChartItem()
            Dim chartControlCommandGalleryItemGroup3DColumn2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn()
            Dim createBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateBar3DChartItem()
            Dim createFullStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem()
            Dim createManhattanBarChartItem2 As New DevExpress.XtraCharts.UI.CreateManhattanBarChartItem()
            Dim createSideBySideFullStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem()
            Dim createSideBySideStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem()
            Dim createStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem()
            Dim chartControlCommandGalleryItemGroupCylinderColumn2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn()
            Dim createCylinderBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem()
            Dim createCylinderFullStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem()
            Dim createCylinderManhattanBarChartItem2 As New DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem()
            Dim createCylinderSideBySideFullStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem()
            Dim createCylinderSideBySideStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem()
            Dim createCylinderStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem()
            Dim chartControlCommandGalleryItemGroupConeColumn2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn()
            Dim createConeBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateConeBar3DChartItem()
            Dim createConeFullStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem()
            Dim createConeManhattanBarChartItem2 As New DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem()
            Dim createConeSideBySideFullStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem()
            Dim createConeSideBySideStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem()
            Dim createConeStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem()
            Dim chartControlCommandGalleryItemGroupPyramidColumn2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn()
            Dim createPyramidBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem()
            Dim createPyramidFullStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem()
            Dim createPyramidManhattanBarChartItem2 As New DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem()
            Dim createPyramidSideBySideFullStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem()
            Dim createPyramidSideBySideStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem()
            Dim createPyramidStackedBar3DChartItem2 As New DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem()
            Dim chartControlCommandGalleryItemGroup2DLine2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine()
            Dim createLineChartItem2 As New DevExpress.XtraCharts.UI.CreateLineChartItem()
            Dim createFullStackedLineChartItem2 As New DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem()
            Dim createScatterLineChartItem2 As New DevExpress.XtraCharts.UI.CreateScatterLineChartItem()
            Dim createSplineChartItem2 As New DevExpress.XtraCharts.UI.CreateSplineChartItem()
            Dim createStackedLineChartItem2 As New DevExpress.XtraCharts.UI.CreateStackedLineChartItem()
            Dim createStepLineChartItem2 As New DevExpress.XtraCharts.UI.CreateStepLineChartItem()
            Dim chartControlCommandGalleryItemGroup3DLine2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine()
            Dim createLine3DChartItem2 As New DevExpress.XtraCharts.UI.CreateLine3DChartItem()
            Dim createFullStackedLine3DChartItem2 As New DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem()
            Dim createSpline3DChartItem2 As New DevExpress.XtraCharts.UI.CreateSpline3DChartItem()
            Dim createStackedLine3DChartItem2 As New DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem()
            Dim createStepLine3DChartItem2 As New DevExpress.XtraCharts.UI.CreateStepLine3DChartItem()
            Dim chartControlCommandGalleryItemGroup2DPie2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie()
            Dim createPieChartItem2 As New DevExpress.XtraCharts.UI.CreatePieChartItem()
            Dim createDoughnutChartItem2 As New DevExpress.XtraCharts.UI.CreateDoughnutChartItem()
            Dim chartControlCommandGalleryItemGroup3DPie2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie()
            Dim createPie3DChartItem2 As New DevExpress.XtraCharts.UI.CreatePie3DChartItem()
            Dim createDoughnut3DChartItem2 As New DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem()
            Dim chartControlCommandGalleryItemGroup2DBar2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar()
            Dim createRotatedBarChartItem2 As New DevExpress.XtraCharts.UI.CreateRotatedBarChartItem()
            Dim createRotatedFullStackedBarChartItem2 As New DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem()
            Dim createRotatedSideBySideFullStackedBarChartItem2 As New DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem()
            Dim createRotatedSideBySideStackedBarChartItem2 As New DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem()
            Dim createRotatedStackedBarChartItem2 As New DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem()
            Dim chartControlCommandGalleryItemGroup2DArea2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea()
            Dim createAreaChartItem2 As New DevExpress.XtraCharts.UI.CreateAreaChartItem()
            Dim createFullStackedAreaChartItem2 As New DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem()
            Dim createFullStackedSplineAreaChartItem2 As New DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem()
            Dim createSplineAreaChartItem2 As New DevExpress.XtraCharts.UI.CreateSplineAreaChartItem()
            Dim createStackedAreaChartItem2 As New DevExpress.XtraCharts.UI.CreateStackedAreaChartItem()
            Dim createStackedSplineAreaChartItem2 As New DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem()
            Dim createStepAreaChartItem2 As New DevExpress.XtraCharts.UI.CreateStepAreaChartItem()
            Dim chartControlCommandGalleryItemGroup3DArea2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea()
            Dim createArea3DChartItem2 As New DevExpress.XtraCharts.UI.CreateArea3DChartItem()
            Dim createFullStackedArea3DChartItem2 As New DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem()
            Dim createFullStackedSplineArea3DChartItem2 As New DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem()
            Dim createSplineArea3DChartItem2 As New DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem()
            Dim createStackedArea3DChartItem2 As New DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem()
            Dim createStackedSplineArea3DChartItem2 As New DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem()
            Dim createStepArea3DChartItem2 As New DevExpress.XtraCharts.UI.CreateStepArea3DChartItem()
            Dim chartControlCommandGalleryItemGroupPoint2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint()
            Dim createPointChartItem2 As New DevExpress.XtraCharts.UI.CreatePointChartItem()
            Dim createBubbleChartItem2 As New DevExpress.XtraCharts.UI.CreateBubbleChartItem()
            Dim chartControlCommandGalleryItemGroupFunnel2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel()
            Dim createFunnelChartItem2 As New DevExpress.XtraCharts.UI.CreateFunnelChartItem()
            Dim createFunnel3DChartItem2 As New DevExpress.XtraCharts.UI.CreateFunnel3DChartItem()
            Dim chartControlCommandGalleryItemGroupFinancial2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial()
            Dim createStockChartItem2 As New DevExpress.XtraCharts.UI.CreateStockChartItem()
            Dim createCandleStickChartItem2 As New DevExpress.XtraCharts.UI.CreateCandleStickChartItem()
            Dim chartControlCommandGalleryItemGroupRadar2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar()
            Dim createRadarPointChartItem2 As New DevExpress.XtraCharts.UI.CreateRadarPointChartItem()
            Dim createRadarLineChartItem2 As New DevExpress.XtraCharts.UI.CreateRadarLineChartItem()
            Dim createRadarAreaChartItem2 As New DevExpress.XtraCharts.UI.CreateRadarAreaChartItem()
            Dim chartControlCommandGalleryItemGroupPolar2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar()
            Dim createPolarPointChartItem2 As New DevExpress.XtraCharts.UI.CreatePolarPointChartItem()
            Dim createPolarLineChartItem2 As New DevExpress.XtraCharts.UI.CreatePolarLineChartItem()
            Dim createPolarAreaChartItem2 As New DevExpress.XtraCharts.UI.CreatePolarAreaChartItem()
            Dim chartControlCommandGalleryItemGroupRange2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange()
            Dim createRangeBarChartItem2 As New DevExpress.XtraCharts.UI.CreateRangeBarChartItem()
            Dim createSideBySideRangeBarChartItem2 As New DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem()
            Dim createRangeAreaChartItem2 As New DevExpress.XtraCharts.UI.CreateRangeAreaChartItem()
            Dim createRangeArea3DChartItem2 As New DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem()
            Dim chartControlCommandGalleryItemGroupGantt2 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt()
            Dim createGanttChartItem2 As New DevExpress.XtraCharts.UI.CreateGanttChartItem()
            Dim createSideBySideGanttChartItem2 As New DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem()
            Dim skinPaddingEdges3 As New DevExpress.Skins.SkinPaddingEdges()
            Dim skinPaddingEdges4 As New DevExpress.Skins.SkinPaddingEdges()
            Dim serializableAppearanceObject5 As New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject6 As New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject7 As New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject8 As New DevExpress.Utils.SerializableAppearanceObject()
            Dim reduceOperation2 As New DevExpress.XtraBars.Ribbon.ReduceOperation()
            Me.stylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup()
            Me.galleryChangeStyleItem1 = New DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem()
            Me.snapControl1 = New DevExpress.Snap.SnapControl()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.fileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
            Me.fileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
            Me.fileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
            Me.fileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
            Me.commandBarItem1 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
            Me.printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
            Me.printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
            Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
            Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
            Me.commandBarItem2 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
            Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
            Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
            Me.pasteSpecialItem1 = New DevExpress.XtraRichEdit.UI.PasteSpecialItem()
            Me.barButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeFontNameItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontNameItem()
            Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
            Me.changeFontSizeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontSizeItem()
            Me.repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
            Me.fontSizeIncreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem()
            Me.fontSizeDecreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem()
            Me.barButtonGroup2 = New DevExpress.XtraBars.BarButtonGroup()
            Me.toggleFontBoldItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontBoldItem()
            Me.toggleFontItalicItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontItalicItem()
            Me.toggleFontUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem()
            Me.toggleFontDoubleUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem()
            Me.toggleFontStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem()
            Me.toggleFontDoubleStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem()
            Me.toggleFontSuperscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem()
            Me.toggleFontSubscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem()
            Me.barButtonGroup3 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeFontColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontColorItem()
            Me.changeFontBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem()
            Me.changeTextCaseItem1 = New DevExpress.XtraRichEdit.UI.ChangeTextCaseItem()
            Me.makeTextUpperCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem()
            Me.makeTextLowerCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem()
            Me.capitalizeEachWordCaseItem1 = New DevExpress.XtraRichEdit.UI.CapitalizeEachWordCaseItem()
            Me.toggleTextCaseItem1 = New DevExpress.XtraRichEdit.UI.ToggleTextCaseItem()
            Me.clearFormattingItem1 = New DevExpress.XtraRichEdit.UI.ClearFormattingItem()
            Me.barButtonGroup4 = New DevExpress.XtraBars.BarButtonGroup()
            Me.toggleBulletedListItem1 = New DevExpress.XtraRichEdit.UI.ToggleBulletedListItem()
            Me.toggleNumberingListItem1 = New DevExpress.XtraRichEdit.UI.ToggleNumberingListItem()
            Me.toggleMultiLevelListItem1 = New DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem()
            Me.barButtonGroup5 = New DevExpress.XtraBars.BarButtonGroup()
            Me.decreaseIndentItem1 = New DevExpress.XtraRichEdit.UI.DecreaseIndentItem()
            Me.increaseIndentItem1 = New DevExpress.XtraRichEdit.UI.IncreaseIndentItem()
            Me.toggleShowWhitespaceItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem()
            Me.barButtonGroup6 = New DevExpress.XtraBars.BarButtonGroup()
            Me.toggleParagraphAlignmentLeftItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem()
            Me.toggleParagraphAlignmentCenterItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem()
            Me.toggleParagraphAlignmentRightItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem()
            Me.toggleParagraphAlignmentJustifyItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem()
            Me.barButtonGroup7 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeParagraphLineSpacingItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem()
            Me.setSingleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem()
            Me.setSesquialteralParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem()
            Me.setDoubleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem()
            Me.showLineSpacingFormItem1 = New DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem()
            Me.addSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem()
            Me.removeSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem()
            Me.addSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem()
            Me.removeSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem()
            Me.changeParagraphBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem()
            Me.findItem1 = New DevExpress.XtraRichEdit.UI.FindItem()
            Me.replaceItem1 = New DevExpress.XtraRichEdit.UI.ReplaceItem()
            Me.insertPageBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem()
            Me.insertTableItem1 = New DevExpress.XtraRichEdit.UI.InsertTableItem()
            Me.insertPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertPictureItem()
            Me.insertFloatingPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem()
            Me.commandBarItem3 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.commandBarItem4 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.commandBarItem5 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.commandBarItem6 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.commandBarItem7 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.insertBookmarkItem1 = New DevExpress.XtraRichEdit.UI.InsertBookmarkItem()
            Me.insertHyperlinkItem1 = New DevExpress.XtraRichEdit.UI.InsertHyperlinkItem()
            Me.editPageHeaderItem1 = New DevExpress.XtraRichEdit.UI.EditPageHeaderItem()
            Me.editPageFooterItem1 = New DevExpress.XtraRichEdit.UI.EditPageFooterItem()
            Me.insertPageNumberItem1 = New DevExpress.XtraRichEdit.UI.InsertPageNumberItem()
            Me.insertPageCountItem1 = New DevExpress.XtraRichEdit.UI.InsertPageCountItem()
            Me.insertTextBoxItem1 = New DevExpress.XtraRichEdit.UI.InsertTextBoxItem()
            Me.insertSymbolItem1 = New DevExpress.XtraRichEdit.UI.InsertSymbolItem()
            Me.changeSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem()
            Me.setNormalSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem()
            Me.setNarrowSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem()
            Me.setModerateSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem()
            Me.setWideSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem()
            Me.showPageMarginsSetupFormItem1 = New DevExpress.XtraRichEdit.UI.ShowPageMarginsSetupFormItem()
            Me.changeSectionPageOrientationItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem()
            Me.setPortraitPageOrientationItem1 = New DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem()
            Me.setLandscapePageOrientationItem1 = New DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem()
            Me.changeSectionPaperKindItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem()
            Me.changeSectionColumnsItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem()
            Me.setSectionOneColumnItem1 = New DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem()
            Me.setSectionTwoColumnsItem1 = New DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem()
            Me.setSectionThreeColumnsItem1 = New DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem()
            Me.showColumnsSetupFormItem1 = New DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem()
            Me.insertBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertBreakItem()
            Me.insertColumnBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertColumnBreakItem()
            Me.insertSectionBreakNextPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem()
            Me.insertSectionBreakEvenPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem()
            Me.insertSectionBreakOddPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem()
            Me.changeSectionLineNumberingItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem()
            Me.setSectionLineNumberingNoneItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem()
            Me.setSectionLineNumberingContinuousItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem()
            Me.setSectionLineNumberingRestartNewPageItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem()
            Me.setSectionLineNumberingRestartNewSectionItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem()
            Me.toggleParagraphSuppressLineNumbersItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem()
            Me.showLineNumberingFormItem1 = New DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem()
            Me.changePageColorItem1 = New DevExpress.XtraRichEdit.UI.ChangePageColorItem()
            Me.switchToSimpleViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem()
            Me.switchToDraftViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem()
            Me.switchToPrintLayoutViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem()
            Me.toggleShowHorizontalRulerItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowHorizontalRulerItem()
            Me.toggleShowVerticalRulerItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowVerticalRulerItem()
            Me.zoomOutItem1 = New DevExpress.XtraRichEdit.UI.ZoomOutItem()
            Me.zoomInItem1 = New DevExpress.XtraRichEdit.UI.ZoomInItem()
            Me.snapBarToolbarsListItem1 = New DevExpress.Snap.Extensions.UI.SnapBarToolbarsListItem()
            Me.commandBarCheckItem1 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.showAllFieldCodesItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem()
            Me.showAllFieldResultsItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem()
            Me.toggleFieldHighlightingItem1 = New DevExpress.Snap.Extensions.UI.ToggleFieldHighlightingItem()
            Me.goToPageHeaderItem1 = New DevExpress.XtraRichEdit.UI.GoToPageHeaderItem()
            Me.goToPageFooterItem1 = New DevExpress.XtraRichEdit.UI.GoToPageFooterItem()
            Me.goToNextHeaderFooterItem1 = New DevExpress.XtraRichEdit.UI.GoToNextHeaderFooterItem()
            Me.goToPreviousHeaderFooterItem1 = New DevExpress.XtraRichEdit.UI.GoToPreviousHeaderFooterItem()
            Me.toggleLinkToPreviousItem1 = New DevExpress.XtraRichEdit.UI.ToggleLinkToPreviousItem()
            Me.toggleDifferentFirstPageItem1 = New DevExpress.XtraRichEdit.UI.ToggleDifferentFirstPageItem()
            Me.toggleDifferentOddAndEvenPagesItem1 = New DevExpress.XtraRichEdit.UI.ToggleDifferentOddAndEvenPagesItem()
            Me.closePageHeaderFooterItem1 = New DevExpress.XtraRichEdit.UI.ClosePageHeaderFooterItem()
            Me.toggleFirstRowItem1 = New DevExpress.XtraRichEdit.UI.ToggleFirstRowItem()
            Me.toggleLastRowItem1 = New DevExpress.XtraRichEdit.UI.ToggleLastRowItem()
            Me.toggleBandedRowsItem1 = New DevExpress.XtraRichEdit.UI.ToggleBandedRowsItem()
            Me.toggleFirstColumnItem1 = New DevExpress.XtraRichEdit.UI.ToggleFirstColumnItem()
            Me.toggleLastColumnItem1 = New DevExpress.XtraRichEdit.UI.ToggleLastColumnItem()
            Me.toggleBandedColumnItem1 = New DevExpress.XtraRichEdit.UI.ToggleBandedColumnsItem()
            Me.galleryChangeTableStyleItem1 = New DevExpress.XtraRichEdit.UI.GalleryChangeTableStyleItem()
            Me.galleryChangeTableCellStyleItem1 = New DevExpress.Snap.Extensions.UI.GalleryChangeTableCellStyleItem()
            Me.changeTableBorderLineStyleItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem()
            Me.repositoryItemBorderLineStyle1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle()
            Me.changeTableBorderLineWeightItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem()
            Me.repositoryItemBorderLineWeight1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight()
            Me.changeTableBorderColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem()
            Me.changeTableBordersItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBordersItem()
            Me.toggleTableCellsBottomBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem()
            Me.toggleTableCellsTopBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem()
            Me.toggleTableCellsLeftBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem()
            Me.toggleTableCellsRightBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem()
            Me.resetTableCellsAllBordersItem1 = New DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem()
            Me.toggleTableCellsAllBordersItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem()
            Me.toggleTableCellsOutsideBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem()
            Me.toggleTableCellsInsideBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem()
            Me.toggleTableCellsInsideHorizontalBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem()
            Me.toggleTableCellsInsideVerticalBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem()
            Me.toggleShowTableGridLinesItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem()
            Me.changeTableCellsShadingItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem()
            Me.selectTableElementsItem1 = New DevExpress.XtraRichEdit.UI.SelectTableElementsItem()
            Me.selectTableCellItem1 = New DevExpress.XtraRichEdit.UI.SelectTableCellItem()
            Me.selectTableColumnItem1 = New DevExpress.XtraRichEdit.UI.SelectTableColumnItem()
            Me.selectTableRowItem1 = New DevExpress.XtraRichEdit.UI.SelectTableRowItem()
            Me.selectTableItem1 = New DevExpress.XtraRichEdit.UI.SelectTableItem()
            Me.showTablePropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem()
            Me.deleteTableElementsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableElementsItem()
            Me.showDeleteTableCellsFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem()
            Me.deleteTableColumnsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem()
            Me.deleteTableRowsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableRowsItem()
            Me.deleteTableItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableItem()
            Me.insertTableRowAboveItem1 = New DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem()
            Me.insertTableRowBelowItem1 = New DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem()
            Me.insertTableColumnToLeftItem1 = New DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem()
            Me.insertTableColumnToRightItem1 = New DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem()
            Me.mergeTableCellsItem1 = New DevExpress.XtraRichEdit.UI.MergeTableCellsItem()
            Me.showSplitTableCellsForm1 = New DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm()
            Me.splitTableItem1 = New DevExpress.XtraRichEdit.UI.SplitTableItem()
            Me.toggleTableAutoFitItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem()
            Me.toggleTableAutoFitContentsItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem()
            Me.toggleTableAutoFitWindowItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem()
            Me.toggleTableFixedColumnWidthItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem()
            Me.toggleTableCellsTopLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem()
            Me.toggleTableCellsMiddleLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem()
            Me.toggleTableCellsBottomLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem()
            Me.toggleTableCellsTopCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem()
            Me.toggleTableCellsMiddleCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem()
            Me.toggleTableCellsBottomCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem()
            Me.toggleTableCellsTopRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem()
            Me.toggleTableCellsMiddleRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem()
            Me.toggleTableCellsBottomRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem()
            Me.showTableOptionsFormItem1 = New DevExpress.XtraRichEdit.UI.ShowTableOptionsFormItem()
            Me.checkSpellingItem1 = New DevExpress.XtraRichEdit.UI.CheckSpellingItem()
            Me.insertTableOfContentsItem1 = New DevExpress.XtraRichEdit.UI.InsertTableOfContentsItem()
            Me.updateTableOfContentsItem1 = New DevExpress.XtraRichEdit.UI.UpdateTableOfContentsItem()
            Me.addParagraphsToTableOfContentItem1 = New DevExpress.XtraRichEdit.UI.AddParagraphsToTableOfContentItem()
            Me.setParagraphHeadingLevelItem1 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem2 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem3 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem4 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem5 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem6 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem7 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem8 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem9 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem10 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.insertCaptionPlaceholderItem1 = New DevExpress.XtraRichEdit.UI.InsertCaptionPlaceholderItem()
            Me.insertFiguresCaptionItems1 = New DevExpress.XtraRichEdit.UI.InsertFiguresCaptionItems()
            Me.insertTablesCaptionItems1 = New DevExpress.XtraRichEdit.UI.InsertTablesCaptionItems()
            Me.insertEquationsCaptionItems1 = New DevExpress.XtraRichEdit.UI.InsertEquationsCaptionItems()
            Me.insertTableOfFiguresPlaceholderItem1 = New DevExpress.XtraRichEdit.UI.InsertTableOfFiguresPlaceholderItem()
            Me.insertTableOfFiguresItems1 = New DevExpress.XtraRichEdit.UI.InsertTableOfFiguresItems()
            Me.insertTableOfTablesItems1 = New DevExpress.XtraRichEdit.UI.InsertTableOfTablesItems()
            Me.insertTableOfEquationsItems1 = New DevExpress.XtraRichEdit.UI.InsertTableOfEquationsItems()
            Me.updateTableOfFiguresItem1 = New DevExpress.XtraRichEdit.UI.UpdateTableOfFiguresItem()
            Me.changeFloatingObjectFillColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectFillColorItem()
            Me.changeFloatingObjectOutlineColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineColorItem()
            Me.changeFloatingObjectOutlineWeightItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineWeightItem()
            Me.repositoryItemFloatingObjectOutlineWeight1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight()
            Me.changeFloatingObjectTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectTextWrapTypeItem()
            Me.setFloatingObjectSquareTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectSquareTextWrapTypeItem()
            Me.setFloatingObjectTightTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTightTextWrapTypeItem()
            Me.setFloatingObjectThroughTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectThroughTextWrapTypeItem()
            Me.setFloatingObjectTopAndBottomTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopAndBottomTextWrapTypeItem()
            Me.setFloatingObjectBehindTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBehindTextWrapTypeItem()
            Me.setFloatingObjectInFrontOfTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectInFrontOfTextWrapTypeItem()
            Me.changeFloatingObjectAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectAlignmentItem()
            Me.setFloatingObjectTopLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopLeftAlignmentItem()
            Me.setFloatingObjectTopCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopCenterAlignmentItem()
            Me.setFloatingObjectTopRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopRightAlignmentItem()
            Me.setFloatingObjectMiddleLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleLeftAlignmentItem()
            Me.setFloatingObjectMiddleCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleCenterAlignmentItem()
            Me.setFloatingObjectMiddleRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleRightAlignmentItem()
            Me.setFloatingObjectBottomLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomLeftAlignmentItem()
            Me.setFloatingObjectBottomCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomCenterAlignmentItem()
            Me.setFloatingObjectBottomRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomRightAlignmentItem()
            Me.floatingObjectBringForwardSubItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardSubItem()
            Me.floatingObjectBringForwardItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardItem()
            Me.floatingObjectBringToFrontItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringToFrontItem()
            Me.floatingObjectBringInFrontOfTextItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringInFrontOfTextItem()
            Me.floatingObjectSendBackwardSubItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardSubItem()
            Me.floatingObjectSendBackwardItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardItem()
            Me.floatingObjectSendToBackItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendToBackItem()
            Me.floatingObjectSendBehindTextItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendBehindTextItem()
            Me.themesGalleryBarItem1 = New DevExpress.Snap.Extensions.UI.ThemesGalleryBarItem()
            Me.commandBarCheckItem2 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem3 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem4 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarSubItem1 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
            Me.commandBarCheckItem5 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem6 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem7 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem8 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem9 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.filterPopupButtonItem1 = New DevExpress.Snap.Extensions.UI.FilterPopupButtonItem()
            Me.propertiesBarButtonItem1 = New DevExpress.Snap.Extensions.UI.PropertiesBarButtonItem()
            Me.commandBarSubItem2 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
            Me.commandBarCheckItem10 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem11 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarSubItem3 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
            Me.commandBarCheckItem12 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem13 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarItem8 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.commandBarItem9 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.commandBarSubItem4 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
            Me.commandBarCheckItem14 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem15 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem16 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem17 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem18 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem19 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem20 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarSubItem5 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
            Me.commandBarCheckItem21 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem22 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarSubItem6 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
            Me.commandBarCheckItem23 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem24 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarItem10 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.commandBarItem11 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.commandBarSubItem7 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
            Me.commandBarCheckItem25 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem26 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem27 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem28 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem29 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem30 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem31 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarItem12 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.barButtonGroup8 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeEditorRowLimitItem1 = New DevExpress.Snap.Extensions.UI.ChangeEditorRowLimitItem()
            Me.repositoryItemEditorRowLimitEdit1 = New DevExpress.Snap.Design.RepositoryItemEditorRowLimitEdit()
            Me.createBarBaseItem1 = New DevExpress.XtraCharts.UI.CreateBarBaseItem()
            Me.commandBarGalleryDropDown1 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.createLineBaseItem1 = New DevExpress.XtraCharts.UI.CreateLineBaseItem()
            Me.commandBarGalleryDropDown2 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.createPieBaseItem1 = New DevExpress.XtraCharts.UI.CreatePieBaseItem()
            Me.commandBarGalleryDropDown3 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.createRotatedBarBaseItem1 = New DevExpress.XtraCharts.UI.CreateRotatedBarBaseItem()
            Me.commandBarGalleryDropDown4 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.createAreaBaseItem1 = New DevExpress.XtraCharts.UI.CreateAreaBaseItem()
            Me.commandBarGalleryDropDown5 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.createOtherSeriesTypesBaseItem1 = New DevExpress.XtraCharts.UI.CreateOtherSeriesTypesBaseItem()
            Me.commandBarGalleryDropDown6 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.changePaletteGalleryBaseItem1 = New DevExpress.XtraCharts.UI.ChangePaletteGalleryBaseItem()
            Me.commandBarGalleryDropDown7 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.changeAppearanceGalleryBaseItem1 = New DevExpress.XtraCharts.UI.ChangeAppearanceGalleryBaseItem()
            Me.runWizardChartItem1 = New DevExpress.XtraCharts.UI.RunWizardChartItem()
            Me.mailMergeDataSourceItem1 = New DevExpress.Snap.Extensions.UI.MailMergeDataSourceItem()
            Me.commandBarCheckItem32 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem33 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.mailMergeCurrentRecordItem1 = New DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordItem()
            Me.repositoryItemMailMergeCurrentRecordEdit1 = New DevExpress.Snap.Extensions.UI.RepositoryItemMailMergeCurrentRecordEdit()
            Me.commandBarSubItem8 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
            Me.commandBarItem13 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.commandBarItem14 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.commandBarItem15 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.headerFooterToolsRibbonPageCategory1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsRibbonPageCategory()
            Me.headerFooterToolsDesignRibbonPage1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignRibbonPage()
            Me.headerFooterToolsDesignNavigationRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignNavigationRibbonPageGroup()
            Me.headerFooterToolsDesignOptionsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignOptionsRibbonPageGroup()
            Me.headerFooterToolsDesignCloseRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignCloseRibbonPageGroup()
            Me.tableToolsRibbonPageCategory1 = New DevExpress.XtraRichEdit.UI.TableToolsRibbonPageCategory()
            Me.tableDesignRibbonPage1 = New DevExpress.XtraRichEdit.UI.TableDesignRibbonPage()
            Me.tableStyleOptionsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableStyleOptionsRibbonPageGroup()
            Me.tableStylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableStylesRibbonPageGroup()
            Me.tableCellStylesRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.TableCellStylesRibbonPageGroup()
            Me.tableDrawBordersRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableDrawBordersRibbonPageGroup()
            Me.tableLayoutRibbonPage1 = New DevExpress.XtraRichEdit.UI.TableLayoutRibbonPage()
            Me.tableTableRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableTableRibbonPageGroup()
            Me.tableRowsAndColumnsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableRowsAndColumnsRibbonPageGroup()
            Me.tableMergeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableMergeRibbonPageGroup()
            Me.tableCellSizeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableCellSizeRibbonPageGroup()
            Me.tableAlignmentRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableAlignmentRibbonPageGroup()
            Me.floatingPictureToolsRibbonPageCategory1 = New DevExpress.XtraRichEdit.UI.FloatingPictureToolsRibbonPageCategory()
            Me.floatingPictureToolsFormatPage1 = New DevExpress.XtraRichEdit.UI.FloatingPictureToolsFormatPage()
            Me.floatingPictureToolsShapeStylesPageGroup1 = New DevExpress.XtraRichEdit.UI.FloatingPictureToolsShapeStylesPageGroup()
            Me.floatingPictureToolsArrangePageGroup1 = New DevExpress.XtraRichEdit.UI.FloatingPictureToolsArrangePageGroup()
            Me.dataToolsRibbonPageCategory1 = New DevExpress.Snap.Extensions.UI.DataToolsRibbonPageCategory()
            Me.appearanceRibbonPage1 = New DevExpress.Snap.Extensions.UI.AppearanceRibbonPage()
            Me.themesRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ThemesRibbonPageGroup()
            Me.snMergeFieldToolsRibbonPage1 = New DevExpress.Snap.Extensions.UI.SNMergeFieldToolsRibbonPage()
            Me.dataShapingRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.DataShapingRibbonPageGroup()
            Me.snMergeFieldPropertiesRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.SNMergeFieldPropertiesRibbonPageGroup()
            Me.groupToolsRibbonPage1 = New DevExpress.Snap.Extensions.UI.GroupToolsRibbonPage()
            Me.groupingRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.GroupingRibbonPageGroup()
            Me.listToolsRibbonPage1 = New DevExpress.Snap.Extensions.UI.ListToolsRibbonPage()
            Me.listHeaderAndFooterRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ListHeaderAndFooterRibbonPageGroup()
            Me.listCommandsRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ListCommandsRibbonPageGroup()
            Me.listEditorRowLimitRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ListEditorRowLimitRibbonPageGroup()
            Me.mailMergeRibbonPage1 = New DevExpress.Snap.Extensions.UI.MailMergeRibbonPage()
            Me.mailMergeRibbonPageGroup2 = New DevExpress.Snap.Extensions.UI.MailMergeRibbonPageGroup()
            Me.mailMergeCurrentRecordRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordRibbonPageGroup()
            Me.finishAndMergeRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.FinishAndMergeRibbonPageGroup()
            Me.chartRibbonPageCategory1 = New DevExpress.XtraCharts.UI.ChartRibbonPageCategory()
            Me.createChartRibbonPage1 = New DevExpress.XtraCharts.UI.CreateChartRibbonPage()
            Me.chartTypeRibbonPageGroup1 = New DevExpress.XtraCharts.UI.ChartTypeRibbonPageGroup()
            Me.chartAppearanceRibbonPageGroup1 = New DevExpress.XtraCharts.UI.ChartAppearanceRibbonPageGroup()
            Me.chartWizardRibbonPageGroup1 = New DevExpress.XtraCharts.UI.ChartWizardRibbonPageGroup()
            Me.fileRibbonPage1 = New DevExpress.XtraRichEdit.UI.FileRibbonPage()
            Me.commonRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup()
            Me.dataRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.DataRibbonPageGroup()
            Me.homeRibbonPage1 = New DevExpress.XtraRichEdit.UI.HomeRibbonPage()
            Me.clipboardRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup()
            Me.fontRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.FontRibbonPageGroup()
            Me.paragraphRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup()
            Me.editingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup()
            Me.insertRibbonPage1 = New DevExpress.XtraRichEdit.UI.InsertRibbonPage()
            Me.pagesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup()
            Me.tablesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup()
            Me.illustrationsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup()
            Me.toolboxRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ToolboxRibbonPageGroup()
            Me.linksRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup()
            Me.headerFooterRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup()
            Me.textRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TextRibbonPageGroup()
            Me.symbolsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup()
            Me.pageLayoutRibbonPage1 = New DevExpress.XtraRichEdit.UI.PageLayoutRibbonPage()
            Me.pageSetupRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PageSetupRibbonPageGroup()
            Me.pageBackgroundRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PageBackgroundRibbonPageGroup()
            Me.viewRibbonPage1 = New DevExpress.XtraRichEdit.UI.ViewRibbonPage()
            Me.documentViewsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentViewsRibbonPageGroup()
            Me.showRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ShowRibbonPageGroup()
            Me.zoomRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ZoomRibbonPageGroup()
            Me.viewRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ViewRibbonPageGroup()
            Me.mailMergeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup()
            Me.reviewRibbonPage1 = New DevExpress.XtraRichEdit.UI.ReviewRibbonPage()
            Me.documentProofingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentProofingRibbonPageGroup()
            Me.referencesRibbonPage1 = New DevExpress.XtraRichEdit.UI.ReferencesRibbonPage()
            Me.tableOfContentsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableOfContentsRibbonPageGroup()
            Me.captionsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CaptionsRibbonPageGroup()
            Me.snapDockManager1 = New DevExpress.Snap.Extensions.SnapDockManager(Me.components)
            Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.fieldListDockPanel1 = New DevExpress.Snap.Extensions.UI.FieldListDockPanel()
            Me.fieldListDockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.reportExplorerDockPanel1 = New DevExpress.Snap.Extensions.UI.ReportExplorerDockPanel()
            Me.reportExplorerDockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.snapDocumentManager1 = New DevExpress.Snap.Extensions.SnapDocumentManager(Me.components)
            Me.noDocumentsView1 = New DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView(Me.components)
            Me.snapBarController1 = New DevExpress.Snap.Extensions.SnapBarController()
            Me.insertPageBreakItem2 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemFloatingObjectOutlineWeight1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemEditorRowLimitEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.commandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.commandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.commandBarGalleryDropDown3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.commandBarGalleryDropDown4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.commandBarGalleryDropDown5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.commandBarGalleryDropDown6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.commandBarGalleryDropDown7, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemMailMergeCurrentRecordEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.snapDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelContainer1.SuspendLayout()
            Me.fieldListDockPanel1.SuspendLayout()
            Me.reportExplorerDockPanel1.SuspendLayout()
            DirectCast(Me.snapDocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.noDocumentsView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.snapBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' stylesRibbonPageGroup1
            ' 
            Me.stylesRibbonPageGroup1.Glyph = (DirectCast(resources.GetObject("stylesRibbonPageGroup1.Glyph"), System.Drawing.Image))
            Me.stylesRibbonPageGroup1.ItemLinks.Add(Me.galleryChangeStyleItem1)
            Me.stylesRibbonPageGroup1.Name = "stylesRibbonPageGroup1"
            ' 
            ' galleryChangeStyleItem1
            ' 
            ' 
            ' 
            ' 
            Me.galleryChangeStyleItem1.Gallery.ColumnCount = 10
            Me.galleryChangeStyleItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup4})
            Me.galleryChangeStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.galleryChangeStyleItem1.Id = 63
            Me.galleryChangeStyleItem1.Name = "galleryChangeStyleItem1"
            ' 
            ' snapControl1
            ' 
            Me.snapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.snapControl1.Location = New System.Drawing.Point(0, 142)
            Me.snapControl1.MenuManager = Me.ribbonControl1
            Me.snapControl1.Modified = True
            Me.snapControl1.Name = "snapControl1"
            Me.snapControl1.Options.Fields.UseCurrentCultureDateTimeFormat = False
            Me.snapControl1.Options.SnapMailMergeVisualOptions.DataSourceName = Nothing
            Me.snapControl1.Size = New System.Drawing.Size(568, 435)
            Me.snapControl1.TabIndex = 0
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.fileNewItem1, Me.fileOpenItem1, Me.fileSaveItem1, Me.fileSaveAsItem1, Me.commandBarItem1, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.undoItem1, Me.redoItem1, Me.commandBarItem2, Me.pasteItem1, Me.cutItem1, Me.copyItem1, Me.pasteSpecialItem1, Me.barButtonGroup1, Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.fontSizeIncreaseItem1, Me.fontSizeDecreaseItem1, Me.barButtonGroup2, Me.toggleFontBoldItem1, Me.toggleFontItalicItem1, Me.toggleFontUnderlineItem1, Me.toggleFontDoubleUnderlineItem1, Me.toggleFontStrikeoutItem1, Me.toggleFontDoubleStrikeoutItem1, Me.toggleFontSuperscriptItem1, Me.toggleFontSubscriptItem1, Me.barButtonGroup3, Me.changeFontColorItem1, Me.changeFontBackColorItem1, Me.changeTextCaseItem1, Me.makeTextUpperCaseItem1, Me.makeTextLowerCaseItem1, Me.capitalizeEachWordCaseItem1, Me.toggleTextCaseItem1, Me.clearFormattingItem1, Me.barButtonGroup4, Me.toggleBulletedListItem1, Me.toggleNumberingListItem1, Me.toggleMultiLevelListItem1, Me.barButtonGroup5, Me.decreaseIndentItem1, Me.increaseIndentItem1, Me.barButtonGroup6, Me.toggleParagraphAlignmentLeftItem1, Me.toggleParagraphAlignmentCenterItem1, Me.toggleParagraphAlignmentRightItem1, Me.toggleParagraphAlignmentJustifyItem1, Me.toggleShowWhitespaceItem1, Me.barButtonGroup7, Me.changeParagraphLineSpacingItem1, Me.setSingleParagraphSpacingItem1, Me.setSesquialteralParagraphSpacingItem1, Me.setDoubleParagraphSpacingItem1, Me.showLineSpacingFormItem1, Me.addSpacingBeforeParagraphItem1, Me.removeSpacingBeforeParagraphItem1, Me.addSpacingAfterParagraphItem1, Me.removeSpacingAfterParagraphItem1, Me.changeParagraphBackColorItem1, Me.galleryChangeStyleItem1, Me.findItem1, Me.replaceItem1, Me.insertPageBreakItem1, Me.insertTableItem1, Me.insertPictureItem1, Me.insertFloatingPictureItem1, Me.commandBarItem3, Me.commandBarItem4, Me.commandBarItem5, Me.commandBarItem6, Me.commandBarItem7, Me.insertBookmarkItem1, Me.insertHyperlinkItem1, Me.editPageHeaderItem1, Me.editPageFooterItem1, Me.insertPageNumberItem1, Me.insertPageCountItem1, Me.insertTextBoxItem1, Me.insertSymbolItem1, Me.changeSectionPageMarginsItem1, Me.setNormalSectionPageMarginsItem1, Me.setNarrowSectionPageMarginsItem1, Me.setModerateSectionPageMarginsItem1, Me.setWideSectionPageMarginsItem1, Me.showPageMarginsSetupFormItem1, Me.changeSectionPageOrientationItem1, Me.setPortraitPageOrientationItem1, Me.setLandscapePageOrientationItem1, Me.changeSectionPaperKindItem1, Me.changeSectionColumnsItem1, Me.setSectionOneColumnItem1, Me.setSectionTwoColumnsItem1, Me.setSectionThreeColumnsItem1, Me.showColumnsSetupFormItem1, Me.insertBreakItem1, Me.insertColumnBreakItem1, Me.insertSectionBreakNextPageItem1, Me.insertSectionBreakEvenPageItem1, Me.insertSectionBreakOddPageItem1, Me.changeSectionLineNumberingItem1, Me.setSectionLineNumberingNoneItem1, Me.setSectionLineNumberingContinuousItem1, Me.setSectionLineNumberingRestartNewPageItem1, Me.setSectionLineNumberingRestartNewSectionItem1, Me.toggleParagraphSuppressLineNumbersItem1, Me.showLineNumberingFormItem1, Me.changePageColorItem1, Me.switchToSimpleViewItem1, Me.switchToDraftViewItem1, Me.switchToPrintLayoutViewItem1, Me.toggleShowHorizontalRulerItem1, Me.toggleShowVerticalRulerItem1, Me.zoomOutItem1, Me.zoomInItem1, Me.snapBarToolbarsListItem1, Me.commandBarCheckItem1, Me.showAllFieldCodesItem1, Me.showAllFieldResultsItem1, Me.toggleFieldHighlightingItem1, Me.goToPageHeaderItem1, Me.goToPageFooterItem1, Me.goToNextHeaderFooterItem1, Me.goToPreviousHeaderFooterItem1, Me.toggleLinkToPreviousItem1, Me.toggleDifferentFirstPageItem1, Me.toggleDifferentOddAndEvenPagesItem1, Me.closePageHeaderFooterItem1, Me.toggleFirstRowItem1, Me.toggleLastRowItem1, Me.toggleBandedRowsItem1, Me.toggleFirstColumnItem1, Me.toggleLastColumnItem1, Me.toggleBandedColumnItem1, Me.galleryChangeTableStyleItem1, Me.galleryChangeTableCellStyleItem1, Me.changeTableBorderLineStyleItem1, Me.changeTableBorderLineWeightItem1, Me.changeTableBorderColorItem1, Me.changeTableBordersItem1, Me.toggleTableCellsBottomBorderItem1, Me.toggleTableCellsTopBorderItem1, Me.toggleTableCellsLeftBorderItem1, Me.toggleTableCellsRightBorderItem1, Me.resetTableCellsAllBordersItem1, Me.toggleTableCellsAllBordersItem1, Me.toggleTableCellsOutsideBorderItem1, Me.toggleTableCellsInsideBorderItem1, Me.toggleTableCellsInsideHorizontalBorderItem1, Me.toggleTableCellsInsideVerticalBorderItem1, Me.toggleShowTableGridLinesItem1, Me.changeTableCellsShadingItem1, Me.selectTableElementsItem1, Me.selectTableCellItem1, Me.selectTableColumnItem1, Me.selectTableRowItem1, Me.selectTableItem1, Me.showTablePropertiesFormItem1, Me.deleteTableElementsItem1, Me.showDeleteTableCellsFormItem1, Me.deleteTableColumnsItem1, Me.deleteTableRowsItem1, Me.deleteTableItem1, Me.insertTableRowAboveItem1, Me.insertTableRowBelowItem1, Me.insertTableColumnToLeftItem1, Me.insertTableColumnToRightItem1, Me.mergeTableCellsItem1, Me.showSplitTableCellsForm1, Me.splitTableItem1, Me.toggleTableAutoFitItem1, Me.toggleTableAutoFitContentsItem1, Me.toggleTableAutoFitWindowItem1, Me.toggleTableFixedColumnWidthItem1, Me.toggleTableCellsTopLeftAlignmentItem1, Me.toggleTableCellsMiddleLeftAlignmentItem1, Me.toggleTableCellsBottomLeftAlignmentItem1, Me.toggleTableCellsTopCenterAlignmentItem1, Me.toggleTableCellsMiddleCenterAlignmentItem1, Me.toggleTableCellsBottomCenterAlignmentItem1, Me.toggleTableCellsTopRightAlignmentItem1, Me.toggleTableCellsMiddleRightAlignmentItem1, Me.toggleTableCellsBottomRightAlignmentItem1, Me.showTableOptionsFormItem1, Me.checkSpellingItem1, Me.insertTableOfContentsItem1, Me.updateTableOfContentsItem1, Me.addParagraphsToTableOfContentItem1, Me.setParagraphHeadingLevelItem1, Me.setParagraphHeadingLevelItem2, Me.setParagraphHeadingLevelItem3, Me.setParagraphHeadingLevelItem4, Me.setParagraphHeadingLevelItem5, Me.setParagraphHeadingLevelItem6, Me.setParagraphHeadingLevelItem7, Me.setParagraphHeadingLevelItem8, Me.setParagraphHeadingLevelItem9, Me.setParagraphHeadingLevelItem10, Me.insertCaptionPlaceholderItem1, Me.insertFiguresCaptionItems1, Me.insertTablesCaptionItems1, Me.insertEquationsCaptionItems1, Me.insertTableOfFiguresPlaceholderItem1, Me.insertTableOfFiguresItems1, Me.insertTableOfTablesItems1, Me.insertTableOfEquationsItems1, Me.updateTableOfFiguresItem1, Me.changeFloatingObjectFillColorItem1, Me.changeFloatingObjectOutlineColorItem1, Me.changeFloatingObjectOutlineWeightItem1, Me.changeFloatingObjectTextWrapTypeItem1, Me.setFloatingObjectSquareTextWrapTypeItem1, Me.setFloatingObjectTightTextWrapTypeItem1, Me.setFloatingObjectThroughTextWrapTypeItem1, Me.setFloatingObjectTopAndBottomTextWrapTypeItem1, Me.setFloatingObjectBehindTextWrapTypeItem1, Me.setFloatingObjectInFrontOfTextWrapTypeItem1, Me.changeFloatingObjectAlignmentItem1, Me.setFloatingObjectTopLeftAlignmentItem1, Me.setFloatingObjectTopCenterAlignmentItem1, Me.setFloatingObjectTopRightAlignmentItem1, Me.setFloatingObjectMiddleLeftAlignmentItem1, Me.setFloatingObjectMiddleCenterAlignmentItem1, Me.setFloatingObjectMiddleRightAlignmentItem1, Me.setFloatingObjectBottomLeftAlignmentItem1, Me.setFloatingObjectBottomCenterAlignmentItem1, Me.setFloatingObjectBottomRightAlignmentItem1, Me.floatingObjectBringForwardSubItem1, Me.floatingObjectBringForwardItem1, Me.floatingObjectBringToFrontItem1, Me.floatingObjectBringInFrontOfTextItem1, Me.floatingObjectSendBackwardSubItem1, Me.floatingObjectSendBackwardItem1, Me.floatingObjectSendToBackItem1, Me.floatingObjectSendBehindTextItem1, Me.themesGalleryBarItem1, Me.commandBarCheckItem2, Me.commandBarCheckItem3, Me.commandBarCheckItem4, Me.commandBarSubItem1, Me.commandBarCheckItem5, Me.commandBarCheckItem6, Me.commandBarCheckItem7, Me.commandBarCheckItem8, Me.commandBarCheckItem9, Me.filterPopupButtonItem1, Me.propertiesBarButtonItem1, Me.commandBarSubItem2, Me.commandBarCheckItem10, Me.commandBarCheckItem11, Me.commandBarSubItem3, Me.commandBarCheckItem12, Me.commandBarCheckItem13, Me.commandBarItem8, Me.commandBarItem9, Me.commandBarSubItem4, Me.commandBarCheckItem14, Me.commandBarCheckItem15, Me.commandBarCheckItem16, Me.commandBarCheckItem17, Me.commandBarCheckItem18, Me.commandBarCheckItem19, Me.commandBarCheckItem20, Me.commandBarSubItem5, Me.commandBarCheckItem21, Me.commandBarCheckItem22, Me.commandBarSubItem6, Me.commandBarCheckItem23, Me.commandBarCheckItem24, Me.commandBarItem10, Me.commandBarItem11, Me.commandBarSubItem7, Me.commandBarCheckItem25, Me.commandBarCheckItem26, Me.commandBarCheckItem27, Me.commandBarCheckItem28, Me.commandBarCheckItem29, Me.commandBarCheckItem30, Me.commandBarCheckItem31, Me.commandBarItem12, Me.barButtonGroup8, Me.changeEditorRowLimitItem1, Me.createBarBaseItem1, Me.createLineBaseItem1, Me.createPieBaseItem1, Me.createRotatedBarBaseItem1, Me.createAreaBaseItem1, Me.createOtherSeriesTypesBaseItem1, Me.changePaletteGalleryBaseItem1, Me.changeAppearanceGalleryBaseItem1, Me.runWizardChartItem1, Me.mailMergeDataSourceItem1, Me.commandBarCheckItem32, Me.commandBarCheckItem33, Me.mailMergeCurrentRecordItem1, Me.commandBarSubItem8, Me.commandBarItem13, Me.commandBarItem14, Me.commandBarItem15})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 302
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() { Me.headerFooterToolsRibbonPageCategory1, Me.tableToolsRibbonPageCategory1, Me.floatingPictureToolsRibbonPageCategory1, Me.dataToolsRibbonPageCategory1, Me.chartRibbonPageCategory1})
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.fileRibbonPage1, Me.homeRibbonPage1, Me.insertRibbonPage1, Me.pageLayoutRibbonPage1, Me.viewRibbonPage1, Me.reviewRibbonPage1, Me.referencesRibbonPage1})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemFontEdit1, Me.repositoryItemRichEditFontSizeEdit1, Me.repositoryItemBorderLineStyle1, Me.repositoryItemBorderLineWeight1, Me.repositoryItemFloatingObjectOutlineWeight1, Me.repositoryItemEditorRowLimitEdit1, Me.repositoryItemMailMergeCurrentRecordEdit1})
            Me.ribbonControl1.Size = New System.Drawing.Size(768, 142)
            ' 
            ' fileNewItem1
            ' 
            Me.fileNewItem1.Id = 1
            Me.fileNewItem1.Name = "fileNewItem1"
            ' 
            ' fileOpenItem1
            ' 
            Me.fileOpenItem1.Id = 2
            Me.fileOpenItem1.Name = "fileOpenItem1"
            ' 
            ' fileSaveItem1
            ' 
            Me.fileSaveItem1.Id = 3
            Me.fileSaveItem1.Name = "fileSaveItem1"
            ' 
            ' fileSaveAsItem1
            ' 
            Me.fileSaveAsItem1.Id = 4
            Me.fileSaveAsItem1.Name = "fileSaveAsItem1"
            ' 
            ' commandBarItem1
            ' 
            Me.commandBarItem1.Id = 5
            Me.commandBarItem1.Name = "commandBarItem1"
            Me.commandBarItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ExportDocument
            ' 
            ' quickPrintItem1
            ' 
            Me.quickPrintItem1.Id = 6
            Me.quickPrintItem1.Name = "quickPrintItem1"
            ' 
            ' printItem1
            ' 
            Me.printItem1.Id = 7
            Me.printItem1.Name = "printItem1"
            ' 
            ' printPreviewItem1
            ' 
            Me.printPreviewItem1.Id = 8
            Me.printPreviewItem1.Name = "printPreviewItem1"
            ' 
            ' undoItem1
            ' 
            Me.undoItem1.Id = 9
            Me.undoItem1.Name = "undoItem1"
            ' 
            ' redoItem1
            ' 
            Me.redoItem1.Id = 10
            Me.redoItem1.Name = "redoItem1"
            ' 
            ' commandBarItem2
            ' 
            Me.commandBarItem2.Id = 11
            Me.commandBarItem2.Name = "commandBarItem2"
            Me.commandBarItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.NewDataSource
            ' 
            ' pasteItem1
            ' 
            Me.pasteItem1.Id = 19
            Me.pasteItem1.Name = "pasteItem1"
            ' 
            ' cutItem1
            ' 
            Me.cutItem1.Id = 20
            Me.cutItem1.Name = "cutItem1"
            ' 
            ' copyItem1
            ' 
            Me.copyItem1.Id = 21
            Me.copyItem1.Name = "copyItem1"
            ' 
            ' pasteSpecialItem1
            ' 
            Me.pasteSpecialItem1.Id = 22
            Me.pasteSpecialItem1.Name = "pasteSpecialItem1"
            ' 
            ' barButtonGroup1
            ' 
            Me.barButtonGroup1.Id = 12
            Me.barButtonGroup1.ItemLinks.Add(Me.changeFontNameItem1)
            Me.barButtonGroup1.ItemLinks.Add(Me.changeFontSizeItem1)
            Me.barButtonGroup1.ItemLinks.Add(Me.fontSizeIncreaseItem1)
            Me.barButtonGroup1.ItemLinks.Add(Me.fontSizeDecreaseItem1)
            Me.barButtonGroup1.Name = "barButtonGroup1"
            Me.barButtonGroup1.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}"
            ' 
            ' changeFontNameItem1
            ' 
            Me.changeFontNameItem1.Edit = Me.repositoryItemFontEdit1
            Me.changeFontNameItem1.Id = 23
            Me.changeFontNameItem1.Name = "changeFontNameItem1"
            ' 
            ' repositoryItemFontEdit1
            ' 
            Me.repositoryItemFontEdit1.AutoHeight = False
            Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
            ' 
            ' changeFontSizeItem1
            ' 
            Me.changeFontSizeItem1.Edit = Me.repositoryItemRichEditFontSizeEdit1
            Me.changeFontSizeItem1.Id = 24
            Me.changeFontSizeItem1.Name = "changeFontSizeItem1"
            ' 
            ' repositoryItemRichEditFontSizeEdit1
            ' 
            Me.repositoryItemRichEditFontSizeEdit1.AutoHeight = False
            Me.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemRichEditFontSizeEdit1.Control = Me.snapControl1
            Me.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1"
            ' 
            ' fontSizeIncreaseItem1
            ' 
            Me.fontSizeIncreaseItem1.Id = 25
            Me.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1"
            ' 
            ' fontSizeDecreaseItem1
            ' 
            Me.fontSizeDecreaseItem1.Id = 26
            Me.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1"
            ' 
            ' barButtonGroup2
            ' 
            Me.barButtonGroup2.Id = 13
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontBoldItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontItalicItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontUnderlineItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontDoubleUnderlineItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontStrikeoutItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontDoubleStrikeoutItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontSuperscriptItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontSubscriptItem1)
            Me.barButtonGroup2.Name = "barButtonGroup2"
            Me.barButtonGroup2.Tag = "{433DA7F0-03E2-4650-9DB5-66DD92D16E39}"
            ' 
            ' toggleFontBoldItem1
            ' 
            Me.toggleFontBoldItem1.Id = 27
            Me.toggleFontBoldItem1.Name = "toggleFontBoldItem1"
            ' 
            ' toggleFontItalicItem1
            ' 
            Me.toggleFontItalicItem1.Id = 28
            Me.toggleFontItalicItem1.Name = "toggleFontItalicItem1"
            ' 
            ' toggleFontUnderlineItem1
            ' 
            Me.toggleFontUnderlineItem1.Id = 29
            Me.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1"
            ' 
            ' toggleFontDoubleUnderlineItem1
            ' 
            Me.toggleFontDoubleUnderlineItem1.Id = 30
            Me.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1"
            ' 
            ' toggleFontStrikeoutItem1
            ' 
            Me.toggleFontStrikeoutItem1.Id = 31
            Me.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1"
            ' 
            ' toggleFontDoubleStrikeoutItem1
            ' 
            Me.toggleFontDoubleStrikeoutItem1.Id = 32
            Me.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1"
            ' 
            ' toggleFontSuperscriptItem1
            ' 
            Me.toggleFontSuperscriptItem1.Id = 33
            Me.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1"
            ' 
            ' toggleFontSubscriptItem1
            ' 
            Me.toggleFontSubscriptItem1.Id = 34
            Me.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1"
            ' 
            ' barButtonGroup3
            ' 
            Me.barButtonGroup3.Id = 14
            Me.barButtonGroup3.ItemLinks.Add(Me.changeFontColorItem1)
            Me.barButtonGroup3.ItemLinks.Add(Me.changeFontBackColorItem1)
            Me.barButtonGroup3.Name = "barButtonGroup3"
            Me.barButtonGroup3.Tag = "{DF8C5334-EDE3-47c9-A42C-FE9A9247E180}"
            ' 
            ' changeFontColorItem1
            ' 
            Me.changeFontColorItem1.Id = 35
            Me.changeFontColorItem1.Name = "changeFontColorItem1"
            ' 
            ' changeFontBackColorItem1
            ' 
            Me.changeFontBackColorItem1.Id = 36
            Me.changeFontBackColorItem1.Name = "changeFontBackColorItem1"
            ' 
            ' changeTextCaseItem1
            ' 
            Me.changeTextCaseItem1.Id = 37
            Me.changeTextCaseItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextUpperCaseItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextLowerCaseItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.capitalizeEachWordCaseItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTextCaseItem1) _
            })
            Me.changeTextCaseItem1.Name = "changeTextCaseItem1"
            ' 
            ' makeTextUpperCaseItem1
            ' 
            Me.makeTextUpperCaseItem1.Id = 38
            Me.makeTextUpperCaseItem1.Name = "makeTextUpperCaseItem1"
            ' 
            ' makeTextLowerCaseItem1
            ' 
            Me.makeTextLowerCaseItem1.Id = 39
            Me.makeTextLowerCaseItem1.Name = "makeTextLowerCaseItem1"
            ' 
            ' capitalizeEachWordCaseItem1
            ' 
            Me.capitalizeEachWordCaseItem1.Id = 40
            Me.capitalizeEachWordCaseItem1.Name = "capitalizeEachWordCaseItem1"
            ' 
            ' toggleTextCaseItem1
            ' 
            Me.toggleTextCaseItem1.Id = 41
            Me.toggleTextCaseItem1.Name = "toggleTextCaseItem1"
            ' 
            ' clearFormattingItem1
            ' 
            Me.clearFormattingItem1.Id = 42
            Me.clearFormattingItem1.Name = "clearFormattingItem1"
            ' 
            ' barButtonGroup4
            ' 
            Me.barButtonGroup4.Id = 15
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleBulletedListItem1)
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleNumberingListItem1)
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleMultiLevelListItem1)
            Me.barButtonGroup4.Name = "barButtonGroup4"
            Me.barButtonGroup4.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}"
            ' 
            ' toggleBulletedListItem1
            ' 
            Me.toggleBulletedListItem1.Id = 43
            Me.toggleBulletedListItem1.Name = "toggleBulletedListItem1"
            ' 
            ' toggleNumberingListItem1
            ' 
            Me.toggleNumberingListItem1.Id = 44
            Me.toggleNumberingListItem1.Name = "toggleNumberingListItem1"
            ' 
            ' toggleMultiLevelListItem1
            ' 
            Me.toggleMultiLevelListItem1.Id = 45
            Me.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1"
            ' 
            ' barButtonGroup5
            ' 
            Me.barButtonGroup5.Id = 16
            Me.barButtonGroup5.ItemLinks.Add(Me.decreaseIndentItem1)
            Me.barButtonGroup5.ItemLinks.Add(Me.increaseIndentItem1)
            Me.barButtonGroup5.ItemLinks.Add(Me.toggleShowWhitespaceItem1)
            Me.barButtonGroup5.Name = "barButtonGroup5"
            Me.barButtonGroup5.Tag = "{4747D5AB-2BEB-4ea6-9A1D-8E4FB36F1B40}"
            ' 
            ' decreaseIndentItem1
            ' 
            Me.decreaseIndentItem1.Id = 46
            Me.decreaseIndentItem1.Name = "decreaseIndentItem1"
            ' 
            ' increaseIndentItem1
            ' 
            Me.increaseIndentItem1.Id = 47
            Me.increaseIndentItem1.Name = "increaseIndentItem1"
            ' 
            ' toggleShowWhitespaceItem1
            ' 
            Me.toggleShowWhitespaceItem1.Id = 52
            Me.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1"
            ' 
            ' barButtonGroup6
            ' 
            Me.barButtonGroup6.Id = 17
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentLeftItem1)
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentCenterItem1)
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentRightItem1)
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentJustifyItem1)
            Me.barButtonGroup6.Name = "barButtonGroup6"
            Me.barButtonGroup6.Tag = "{8E89E775-996E-49a0-AADA-DE338E34732E}"
            ' 
            ' toggleParagraphAlignmentLeftItem1
            ' 
            Me.toggleParagraphAlignmentLeftItem1.Id = 48
            Me.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1"
            ' 
            ' toggleParagraphAlignmentCenterItem1
            ' 
            Me.toggleParagraphAlignmentCenterItem1.Id = 49
            Me.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1"
            ' 
            ' toggleParagraphAlignmentRightItem1
            ' 
            Me.toggleParagraphAlignmentRightItem1.Id = 50
            Me.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1"
            ' 
            ' toggleParagraphAlignmentJustifyItem1
            ' 
            Me.toggleParagraphAlignmentJustifyItem1.Id = 51
            Me.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1"
            ' 
            ' barButtonGroup7
            ' 
            Me.barButtonGroup7.Id = 18
            Me.barButtonGroup7.ItemLinks.Add(Me.changeParagraphLineSpacingItem1)
            Me.barButtonGroup7.ItemLinks.Add(Me.changeParagraphBackColorItem1)
            Me.barButtonGroup7.Name = "barButtonGroup7"
            Me.barButtonGroup7.Tag = "{9A8DEAD8-3890-4857-A395-EC625FD02217}"
            ' 
            ' changeParagraphLineSpacingItem1
            ' 
            Me.changeParagraphLineSpacingItem1.Id = 53
            Me.changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSingleParagraphSpacingItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSesquialteralParagraphSpacingItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setDoubleParagraphSpacingItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.showLineSpacingFormItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingBeforeParagraphItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingBeforeParagraphItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingAfterParagraphItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingAfterParagraphItem1) _
            })
            Me.changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1"
            ' 
            ' setSingleParagraphSpacingItem1
            ' 
            Me.setSingleParagraphSpacingItem1.Id = 54
            Me.setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1"
            ' 
            ' setSesquialteralParagraphSpacingItem1
            ' 
            Me.setSesquialteralParagraphSpacingItem1.Id = 55
            Me.setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1"
            ' 
            ' setDoubleParagraphSpacingItem1
            ' 
            Me.setDoubleParagraphSpacingItem1.Id = 56
            Me.setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1"
            ' 
            ' showLineSpacingFormItem1
            ' 
            Me.showLineSpacingFormItem1.Id = 57
            Me.showLineSpacingFormItem1.Name = "showLineSpacingFormItem1"
            ' 
            ' addSpacingBeforeParagraphItem1
            ' 
            Me.addSpacingBeforeParagraphItem1.Id = 58
            Me.addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1"
            ' 
            ' removeSpacingBeforeParagraphItem1
            ' 
            Me.removeSpacingBeforeParagraphItem1.Id = 59
            Me.removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1"
            ' 
            ' addSpacingAfterParagraphItem1
            ' 
            Me.addSpacingAfterParagraphItem1.Id = 60
            Me.addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1"
            ' 
            ' removeSpacingAfterParagraphItem1
            ' 
            Me.removeSpacingAfterParagraphItem1.Id = 61
            Me.removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1"
            ' 
            ' changeParagraphBackColorItem1
            ' 
            Me.changeParagraphBackColorItem1.Id = 62
            Me.changeParagraphBackColorItem1.Name = "changeParagraphBackColorItem1"
            ' 
            ' findItem1
            ' 
            Me.findItem1.Id = 64
            Me.findItem1.Name = "findItem1"
            ' 
            ' replaceItem1
            ' 
            Me.replaceItem1.Id = 65
            Me.replaceItem1.Name = "replaceItem1"
            ' 
            ' insertPageBreakItem1
            ' 
            Me.insertPageBreakItem1.Id = 66
            Me.insertPageBreakItem1.Name = "insertPageBreakItem1"
            ' 
            ' insertTableItem1
            ' 
            Me.insertTableItem1.Id = 67
            Me.insertTableItem1.Name = "insertTableItem1"
            ' 
            ' insertPictureItem1
            ' 
            Me.insertPictureItem1.Id = 68
            Me.insertPictureItem1.Name = "insertPictureItem1"
            ' 
            ' insertFloatingPictureItem1
            ' 
            Me.insertFloatingPictureItem1.Id = 69
            Me.insertFloatingPictureItem1.Name = "insertFloatingPictureItem1"
            ' 
            ' commandBarItem3
            ' 
            Me.commandBarItem3.Id = 70
            Me.commandBarItem3.Name = "commandBarItem3"
            Me.commandBarItem3.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertBarCode
            ' 
            ' commandBarItem4
            ' 
            Me.commandBarItem4.Id = 71
            Me.commandBarItem4.Name = "commandBarItem4"
            Me.commandBarItem4.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertCheckBox
            ' 
            ' commandBarItem5
            ' 
            Me.commandBarItem5.Id = 72
            Me.commandBarItem5.Name = "commandBarItem5"
            Me.commandBarItem5.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertChart
            ' 
            ' commandBarItem6
            ' 
            Me.commandBarItem6.Id = 73
            Me.commandBarItem6.Name = "commandBarItem6"
            Me.commandBarItem6.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSparkline
            ' 
            ' commandBarItem7
            ' 
            Me.commandBarItem7.Id = 74
            Me.commandBarItem7.Name = "commandBarItem7"
            Me.commandBarItem7.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertIndex
            ' 
            ' insertBookmarkItem1
            ' 
            Me.insertBookmarkItem1.Id = 75
            Me.insertBookmarkItem1.Name = "insertBookmarkItem1"
            ' 
            ' insertHyperlinkItem1
            ' 
            Me.insertHyperlinkItem1.Id = 76
            Me.insertHyperlinkItem1.Name = "insertHyperlinkItem1"
            ' 
            ' editPageHeaderItem1
            ' 
            Me.editPageHeaderItem1.Id = 77
            Me.editPageHeaderItem1.Name = "editPageHeaderItem1"
            ' 
            ' editPageFooterItem1
            ' 
            Me.editPageFooterItem1.Id = 78
            Me.editPageFooterItem1.Name = "editPageFooterItem1"
            ' 
            ' insertPageNumberItem1
            ' 
            Me.insertPageNumberItem1.Id = 79
            Me.insertPageNumberItem1.Name = "insertPageNumberItem1"
            ' 
            ' insertPageCountItem1
            ' 
            Me.insertPageCountItem1.Id = 80
            Me.insertPageCountItem1.Name = "insertPageCountItem1"
            ' 
            ' insertTextBoxItem1
            ' 
            Me.insertTextBoxItem1.Id = 81
            Me.insertTextBoxItem1.Name = "insertTextBoxItem1"
            ' 
            ' insertSymbolItem1
            ' 
            Me.insertSymbolItem1.Id = 82
            Me.insertSymbolItem1.Name = "insertSymbolItem1"
            ' 
            ' changeSectionPageMarginsItem1
            ' 
            Me.changeSectionPageMarginsItem1.Id = 83
            Me.changeSectionPageMarginsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setNormalSectionPageMarginsItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setNarrowSectionPageMarginsItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setModerateSectionPageMarginsItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setWideSectionPageMarginsItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.showPageMarginsSetupFormItem1) _
            })
            Me.changeSectionPageMarginsItem1.Name = "changeSectionPageMarginsItem1"
            ' 
            ' setNormalSectionPageMarginsItem1
            ' 
            Me.setNormalSectionPageMarginsItem1.Id = 84
            Me.setNormalSectionPageMarginsItem1.Name = "setNormalSectionPageMarginsItem1"
            ' 
            ' setNarrowSectionPageMarginsItem1
            ' 
            Me.setNarrowSectionPageMarginsItem1.Id = 85
            Me.setNarrowSectionPageMarginsItem1.Name = "setNarrowSectionPageMarginsItem1"
            ' 
            ' setModerateSectionPageMarginsItem1
            ' 
            Me.setModerateSectionPageMarginsItem1.Id = 86
            Me.setModerateSectionPageMarginsItem1.Name = "setModerateSectionPageMarginsItem1"
            ' 
            ' setWideSectionPageMarginsItem1
            ' 
            Me.setWideSectionPageMarginsItem1.Id = 87
            Me.setWideSectionPageMarginsItem1.Name = "setWideSectionPageMarginsItem1"
            ' 
            ' showPageMarginsSetupFormItem1
            ' 
            Me.showPageMarginsSetupFormItem1.Id = 88
            Me.showPageMarginsSetupFormItem1.Name = "showPageMarginsSetupFormItem1"
            ' 
            ' changeSectionPageOrientationItem1
            ' 
            Me.changeSectionPageOrientationItem1.Id = 89
            Me.changeSectionPageOrientationItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setPortraitPageOrientationItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setLandscapePageOrientationItem1) _
            })
            Me.changeSectionPageOrientationItem1.Name = "changeSectionPageOrientationItem1"
            ' 
            ' setPortraitPageOrientationItem1
            ' 
            Me.setPortraitPageOrientationItem1.Id = 90
            Me.setPortraitPageOrientationItem1.Name = "setPortraitPageOrientationItem1"
            ' 
            ' setLandscapePageOrientationItem1
            ' 
            Me.setLandscapePageOrientationItem1.Id = 91
            Me.setLandscapePageOrientationItem1.Name = "setLandscapePageOrientationItem1"
            ' 
            ' changeSectionPaperKindItem1
            ' 
            Me.changeSectionPaperKindItem1.Id = 92
            Me.changeSectionPaperKindItem1.Name = "changeSectionPaperKindItem1"
            ' 
            ' changeSectionColumnsItem1
            ' 
            Me.changeSectionColumnsItem1.Id = 93
            Me.changeSectionColumnsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionOneColumnItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionTwoColumnsItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionThreeColumnsItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.showColumnsSetupFormItem1) _
            })
            Me.changeSectionColumnsItem1.Name = "changeSectionColumnsItem1"
            ' 
            ' setSectionOneColumnItem1
            ' 
            Me.setSectionOneColumnItem1.Id = 94
            Me.setSectionOneColumnItem1.Name = "setSectionOneColumnItem1"
            ' 
            ' setSectionTwoColumnsItem1
            ' 
            Me.setSectionTwoColumnsItem1.Id = 95
            Me.setSectionTwoColumnsItem1.Name = "setSectionTwoColumnsItem1"
            ' 
            ' setSectionThreeColumnsItem1
            ' 
            Me.setSectionThreeColumnsItem1.Id = 96
            Me.setSectionThreeColumnsItem1.Name = "setSectionThreeColumnsItem1"
            ' 
            ' showColumnsSetupFormItem1
            ' 
            Me.showColumnsSetupFormItem1.Id = 97
            Me.showColumnsSetupFormItem1.Name = "showColumnsSetupFormItem1"
            ' 
            ' insertBreakItem1
            ' 
            Me.insertBreakItem1.Id = 98
            Me.insertBreakItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertPageBreakItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertColumnBreakItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakNextPageItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakEvenPageItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakOddPageItem1) _
            })
            Me.insertBreakItem1.Name = "insertBreakItem1"
            ' 
            ' insertColumnBreakItem1
            ' 
            Me.insertColumnBreakItem1.Id = 99
            Me.insertColumnBreakItem1.Name = "insertColumnBreakItem1"
            ' 
            ' insertSectionBreakNextPageItem1
            ' 
            Me.insertSectionBreakNextPageItem1.Id = 100
            Me.insertSectionBreakNextPageItem1.Name = "insertSectionBreakNextPageItem1"
            ' 
            ' insertSectionBreakEvenPageItem1
            ' 
            Me.insertSectionBreakEvenPageItem1.Id = 101
            Me.insertSectionBreakEvenPageItem1.Name = "insertSectionBreakEvenPageItem1"
            ' 
            ' insertSectionBreakOddPageItem1
            ' 
            Me.insertSectionBreakOddPageItem1.Id = 102
            Me.insertSectionBreakOddPageItem1.Name = "insertSectionBreakOddPageItem1"
            ' 
            ' changeSectionLineNumberingItem1
            ' 
            Me.changeSectionLineNumberingItem1.Id = 103
            Me.changeSectionLineNumberingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingNoneItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingContinuousItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingRestartNewPageItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingRestartNewSectionItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleParagraphSuppressLineNumbersItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.showLineNumberingFormItem1) _
            })
            Me.changeSectionLineNumberingItem1.Name = "changeSectionLineNumberingItem1"
            ' 
            ' setSectionLineNumberingNoneItem1
            ' 
            Me.setSectionLineNumberingNoneItem1.Id = 104
            Me.setSectionLineNumberingNoneItem1.Name = "setSectionLineNumberingNoneItem1"
            ' 
            ' setSectionLineNumberingContinuousItem1
            ' 
            Me.setSectionLineNumberingContinuousItem1.Id = 105
            Me.setSectionLineNumberingContinuousItem1.Name = "setSectionLineNumberingContinuousItem1"
            ' 
            ' setSectionLineNumberingRestartNewPageItem1
            ' 
            Me.setSectionLineNumberingRestartNewPageItem1.Id = 106
            Me.setSectionLineNumberingRestartNewPageItem1.Name = "setSectionLineNumberingRestartNewPageItem1"
            ' 
            ' setSectionLineNumberingRestartNewSectionItem1
            ' 
            Me.setSectionLineNumberingRestartNewSectionItem1.Id = 107
            Me.setSectionLineNumberingRestartNewSectionItem1.Name = "setSectionLineNumberingRestartNewSectionItem1"
            ' 
            ' toggleParagraphSuppressLineNumbersItem1
            ' 
            Me.toggleParagraphSuppressLineNumbersItem1.Id = 108
            Me.toggleParagraphSuppressLineNumbersItem1.Name = "toggleParagraphSuppressLineNumbersItem1"
            ' 
            ' showLineNumberingFormItem1
            ' 
            Me.showLineNumberingFormItem1.Id = 109
            Me.showLineNumberingFormItem1.Name = "showLineNumberingFormItem1"
            ' 
            ' changePageColorItem1
            ' 
            Me.changePageColorItem1.Id = 110
            Me.changePageColorItem1.Name = "changePageColorItem1"
            ' 
            ' switchToSimpleViewItem1
            ' 
            Me.switchToSimpleViewItem1.Id = 111
            Me.switchToSimpleViewItem1.Name = "switchToSimpleViewItem1"
            ' 
            ' switchToDraftViewItem1
            ' 
            Me.switchToDraftViewItem1.Id = 112
            Me.switchToDraftViewItem1.Name = "switchToDraftViewItem1"
            ' 
            ' switchToPrintLayoutViewItem1
            ' 
            Me.switchToPrintLayoutViewItem1.Id = 113
            Me.switchToPrintLayoutViewItem1.Name = "switchToPrintLayoutViewItem1"
            ' 
            ' toggleShowHorizontalRulerItem1
            ' 
            Me.toggleShowHorizontalRulerItem1.Id = 114
            Me.toggleShowHorizontalRulerItem1.Name = "toggleShowHorizontalRulerItem1"
            ' 
            ' toggleShowVerticalRulerItem1
            ' 
            Me.toggleShowVerticalRulerItem1.Id = 115
            Me.toggleShowVerticalRulerItem1.Name = "toggleShowVerticalRulerItem1"
            ' 
            ' zoomOutItem1
            ' 
            Me.zoomOutItem1.Id = 116
            Me.zoomOutItem1.Name = "zoomOutItem1"
            ' 
            ' zoomInItem1
            ' 
            Me.zoomInItem1.Id = 117
            Me.zoomInItem1.Name = "zoomInItem1"
            ' 
            ' snapBarToolbarsListItem1
            ' 
            Me.snapBarToolbarsListItem1.Caption = "&Windows"
            Me.snapBarToolbarsListItem1.Glyph = (DirectCast(resources.GetObject("snapBarToolbarsListItem1.Glyph"), System.Drawing.Image))
            Me.snapBarToolbarsListItem1.Id = 118
            Me.snapBarToolbarsListItem1.LargeGlyph = (DirectCast(resources.GetObject("snapBarToolbarsListItem1.LargeGlyph"), System.Drawing.Image))
            Me.snapBarToolbarsListItem1.Name = "snapBarToolbarsListItem1"
            Me.snapBarToolbarsListItem1.ShowCustomizationItem = False
            Me.snapBarToolbarsListItem1.ShowDockPanels = True
            Me.snapBarToolbarsListItem1.ShowToolbars = False
            ' 
            ' commandBarCheckItem1
            ' 
            Me.commandBarCheckItem1.Id = 119
            Me.commandBarCheckItem1.Name = "commandBarCheckItem1"
            Me.commandBarCheckItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.HighlightActiveElement
            ' 
            ' showAllFieldCodesItem1
            ' 
            Me.showAllFieldCodesItem1.Id = 120
            Me.showAllFieldCodesItem1.Name = "showAllFieldCodesItem1"
            ' 
            ' showAllFieldResultsItem1
            ' 
            Me.showAllFieldResultsItem1.Id = 121
            Me.showAllFieldResultsItem1.Name = "showAllFieldResultsItem1"
            ' 
            ' toggleFieldHighlightingItem1
            ' 
            Me.toggleFieldHighlightingItem1.Glyph = (DirectCast(resources.GetObject("toggleFieldHighlightingItem1.Glyph"), System.Drawing.Image))
            Me.toggleFieldHighlightingItem1.Id = 122
            Me.toggleFieldHighlightingItem1.LargeGlyph = (DirectCast(resources.GetObject("toggleFieldHighlightingItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleFieldHighlightingItem1.Name = "toggleFieldHighlightingItem1"
            ' 
            ' goToPageHeaderItem1
            ' 
            Me.goToPageHeaderItem1.Id = 123
            Me.goToPageHeaderItem1.Name = "goToPageHeaderItem1"
            ' 
            ' goToPageFooterItem1
            ' 
            Me.goToPageFooterItem1.Id = 124
            Me.goToPageFooterItem1.Name = "goToPageFooterItem1"
            ' 
            ' goToNextHeaderFooterItem1
            ' 
            Me.goToNextHeaderFooterItem1.Id = 125
            Me.goToNextHeaderFooterItem1.Name = "goToNextHeaderFooterItem1"
            ' 
            ' goToPreviousHeaderFooterItem1
            ' 
            Me.goToPreviousHeaderFooterItem1.Id = 126
            Me.goToPreviousHeaderFooterItem1.Name = "goToPreviousHeaderFooterItem1"
            ' 
            ' toggleLinkToPreviousItem1
            ' 
            Me.toggleLinkToPreviousItem1.Id = 127
            Me.toggleLinkToPreviousItem1.Name = "toggleLinkToPreviousItem1"
            ' 
            ' toggleDifferentFirstPageItem1
            ' 
            Me.toggleDifferentFirstPageItem1.Id = 128
            Me.toggleDifferentFirstPageItem1.Name = "toggleDifferentFirstPageItem1"
            ' 
            ' toggleDifferentOddAndEvenPagesItem1
            ' 
            Me.toggleDifferentOddAndEvenPagesItem1.Id = 129
            Me.toggleDifferentOddAndEvenPagesItem1.Name = "toggleDifferentOddAndEvenPagesItem1"
            ' 
            ' closePageHeaderFooterItem1
            ' 
            Me.closePageHeaderFooterItem1.Id = 130
            Me.closePageHeaderFooterItem1.Name = "closePageHeaderFooterItem1"
            ' 
            ' toggleFirstRowItem1
            ' 
            Me.toggleFirstRowItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.toggleFirstRowItem1.Id = 131
            Me.toggleFirstRowItem1.Name = "toggleFirstRowItem1"
            ' 
            ' toggleLastRowItem1
            ' 
            Me.toggleLastRowItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.toggleLastRowItem1.Id = 132
            Me.toggleLastRowItem1.Name = "toggleLastRowItem1"
            ' 
            ' toggleBandedRowsItem1
            ' 
            Me.toggleBandedRowsItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.toggleBandedRowsItem1.Id = 133
            Me.toggleBandedRowsItem1.Name = "toggleBandedRowsItem1"
            ' 
            ' toggleFirstColumnItem1
            ' 
            Me.toggleFirstColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.toggleFirstColumnItem1.Id = 134
            Me.toggleFirstColumnItem1.Name = "toggleFirstColumnItem1"
            ' 
            ' toggleLastColumnItem1
            ' 
            Me.toggleLastColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.toggleLastColumnItem1.Id = 135
            Me.toggleLastColumnItem1.Name = "toggleLastColumnItem1"
            ' 
            ' toggleBandedColumnItem1
            ' 
            Me.toggleBandedColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.toggleBandedColumnItem1.Id = 136
            Me.toggleBandedColumnItem1.Name = "toggleBandedColumnItem1"
            ' 
            ' galleryChangeTableStyleItem1
            ' 
            Me.galleryChangeTableStyleItem1.CurrentItem = Nothing
            Me.galleryChangeTableStyleItem1.CurrentItemStyle = Nothing
            Me.galleryChangeTableStyleItem1.CurrentStyle = Nothing
            Me.galleryChangeTableStyleItem1.DeleteItemLink = Nothing
            ' 
            ' 
            ' 
            Me.galleryChangeTableStyleItem1.Gallery.ColumnCount = 3
            Me.galleryChangeTableStyleItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup5})
            Me.galleryChangeTableStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.galleryChangeTableStyleItem1.Id = 137
            Me.galleryChangeTableStyleItem1.ModifyItemLink = Nothing
            Me.galleryChangeTableStyleItem1.Name = "galleryChangeTableStyleItem1"
            Me.galleryChangeTableStyleItem1.NewItemLink = Nothing
            Me.galleryChangeTableStyleItem1.PopupGallery = Nothing
            ' 
            ' galleryChangeTableCellStyleItem1
            ' 
            Me.galleryChangeTableCellStyleItem1.CurrentCellStyle = Nothing
            Me.galleryChangeTableCellStyleItem1.CurrentItem = Nothing
            Me.galleryChangeTableCellStyleItem1.CurrentItemCellStyle = Nothing
            Me.galleryChangeTableCellStyleItem1.DeleteItemLink = Nothing
            ' 
            ' 
            ' 
            Me.galleryChangeTableCellStyleItem1.Gallery.ColumnCount = 3
            Me.galleryChangeTableCellStyleItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup6})
            Me.galleryChangeTableCellStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.galleryChangeTableCellStyleItem1.Id = 138
            Me.galleryChangeTableCellStyleItem1.ModifyItemLink = Nothing
            Me.galleryChangeTableCellStyleItem1.Name = "galleryChangeTableCellStyleItem1"
            Me.galleryChangeTableCellStyleItem1.NewItemLink = Nothing
            Me.galleryChangeTableCellStyleItem1.PopupGallery = Nothing
            ' 
            ' changeTableBorderLineStyleItem1
            ' 
            Me.changeTableBorderLineStyleItem1.Edit = Me.repositoryItemBorderLineStyle1
            borderInfo2.Color = System.Drawing.Color.Black
            borderInfo2.Frame = False
            borderInfo2.Offset = 0
            borderInfo2.Shadow = False
            borderInfo2.Style = DevExpress.XtraRichEdit.Model.BorderLineStyle.Single
            borderInfo2.Width = 10
            Me.changeTableBorderLineStyleItem1.EditValue = borderInfo2
            Me.changeTableBorderLineStyleItem1.Id = 139
            Me.changeTableBorderLineStyleItem1.Name = "changeTableBorderLineStyleItem1"
            ' 
            ' repositoryItemBorderLineStyle1
            ' 
            Me.repositoryItemBorderLineStyle1.AutoHeight = False
            Me.repositoryItemBorderLineStyle1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemBorderLineStyle1.Control = Me.snapControl1
            Me.repositoryItemBorderLineStyle1.Name = "repositoryItemBorderLineStyle1"
            ' 
            ' changeTableBorderLineWeightItem1
            ' 
            Me.changeTableBorderLineWeightItem1.Edit = Me.repositoryItemBorderLineWeight1
            Me.changeTableBorderLineWeightItem1.EditValue = 20
            Me.changeTableBorderLineWeightItem1.Id = 140
            Me.changeTableBorderLineWeightItem1.Name = "changeTableBorderLineWeightItem1"
            ' 
            ' repositoryItemBorderLineWeight1
            ' 
            Me.repositoryItemBorderLineWeight1.AutoHeight = False
            Me.repositoryItemBorderLineWeight1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemBorderLineWeight1.Control = Me.snapControl1
            Me.repositoryItemBorderLineWeight1.Name = "repositoryItemBorderLineWeight1"
            ' 
            ' changeTableBorderColorItem1
            ' 
            Me.changeTableBorderColorItem1.Id = 141
            Me.changeTableBorderColorItem1.Name = "changeTableBorderColorItem1"
            ' 
            ' changeTableBordersItem1
            ' 
            Me.changeTableBordersItem1.Id = 142
            Me.changeTableBordersItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsBottomBorderItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsTopBorderItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsLeftBorderItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsRightBorderItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.resetTableCellsAllBordersItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsAllBordersItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsOutsideBorderItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideBorderItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideHorizontalBorderItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideVerticalBorderItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleShowTableGridLinesItem1) _
            })
            Me.changeTableBordersItem1.Name = "changeTableBordersItem1"
            ' 
            ' toggleTableCellsBottomBorderItem1
            ' 
            Me.toggleTableCellsBottomBorderItem1.Id = 143
            Me.toggleTableCellsBottomBorderItem1.Name = "toggleTableCellsBottomBorderItem1"
            ' 
            ' toggleTableCellsTopBorderItem1
            ' 
            Me.toggleTableCellsTopBorderItem1.Id = 144
            Me.toggleTableCellsTopBorderItem1.Name = "toggleTableCellsTopBorderItem1"
            ' 
            ' toggleTableCellsLeftBorderItem1
            ' 
            Me.toggleTableCellsLeftBorderItem1.Id = 145
            Me.toggleTableCellsLeftBorderItem1.Name = "toggleTableCellsLeftBorderItem1"
            ' 
            ' toggleTableCellsRightBorderItem1
            ' 
            Me.toggleTableCellsRightBorderItem1.Id = 146
            Me.toggleTableCellsRightBorderItem1.Name = "toggleTableCellsRightBorderItem1"
            ' 
            ' resetTableCellsAllBordersItem1
            ' 
            Me.resetTableCellsAllBordersItem1.Id = 147
            Me.resetTableCellsAllBordersItem1.Name = "resetTableCellsAllBordersItem1"
            ' 
            ' toggleTableCellsAllBordersItem1
            ' 
            Me.toggleTableCellsAllBordersItem1.Id = 148
            Me.toggleTableCellsAllBordersItem1.Name = "toggleTableCellsAllBordersItem1"
            ' 
            ' toggleTableCellsOutsideBorderItem1
            ' 
            Me.toggleTableCellsOutsideBorderItem1.Id = 149
            Me.toggleTableCellsOutsideBorderItem1.Name = "toggleTableCellsOutsideBorderItem1"
            ' 
            ' toggleTableCellsInsideBorderItem1
            ' 
            Me.toggleTableCellsInsideBorderItem1.Id = 150
            Me.toggleTableCellsInsideBorderItem1.Name = "toggleTableCellsInsideBorderItem1"
            ' 
            ' toggleTableCellsInsideHorizontalBorderItem1
            ' 
            Me.toggleTableCellsInsideHorizontalBorderItem1.Id = 151
            Me.toggleTableCellsInsideHorizontalBorderItem1.Name = "toggleTableCellsInsideHorizontalBorderItem1"
            ' 
            ' toggleTableCellsInsideVerticalBorderItem1
            ' 
            Me.toggleTableCellsInsideVerticalBorderItem1.Id = 152
            Me.toggleTableCellsInsideVerticalBorderItem1.Name = "toggleTableCellsInsideVerticalBorderItem1"
            ' 
            ' toggleShowTableGridLinesItem1
            ' 
            Me.toggleShowTableGridLinesItem1.Id = 153
            Me.toggleShowTableGridLinesItem1.Name = "toggleShowTableGridLinesItem1"
            ' 
            ' changeTableCellsShadingItem1
            ' 
            Me.changeTableCellsShadingItem1.Id = 154
            Me.changeTableCellsShadingItem1.Name = "changeTableCellsShadingItem1"
            ' 
            ' selectTableElementsItem1
            ' 
            Me.selectTableElementsItem1.Id = 155
            Me.selectTableElementsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableCellItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableColumnItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableRowItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableItem1) _
            })
            Me.selectTableElementsItem1.Name = "selectTableElementsItem1"
            ' 
            ' selectTableCellItem1
            ' 
            Me.selectTableCellItem1.Id = 156
            Me.selectTableCellItem1.Name = "selectTableCellItem1"
            ' 
            ' selectTableColumnItem1
            ' 
            Me.selectTableColumnItem1.Id = 157
            Me.selectTableColumnItem1.Name = "selectTableColumnItem1"
            ' 
            ' selectTableRowItem1
            ' 
            Me.selectTableRowItem1.Id = 158
            Me.selectTableRowItem1.Name = "selectTableRowItem1"
            ' 
            ' selectTableItem1
            ' 
            Me.selectTableItem1.Id = 159
            Me.selectTableItem1.Name = "selectTableItem1"
            ' 
            ' showTablePropertiesFormItem1
            ' 
            Me.showTablePropertiesFormItem1.Id = 160
            Me.showTablePropertiesFormItem1.Name = "showTablePropertiesFormItem1"
            ' 
            ' deleteTableElementsItem1
            ' 
            Me.deleteTableElementsItem1.Id = 161
            Me.deleteTableElementsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.showDeleteTableCellsFormItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableColumnsItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableRowsItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableItem1) _
            })
            Me.deleteTableElementsItem1.Name = "deleteTableElementsItem1"
            ' 
            ' showDeleteTableCellsFormItem1
            ' 
            Me.showDeleteTableCellsFormItem1.Id = 162
            Me.showDeleteTableCellsFormItem1.Name = "showDeleteTableCellsFormItem1"
            ' 
            ' deleteTableColumnsItem1
            ' 
            Me.deleteTableColumnsItem1.Id = 163
            Me.deleteTableColumnsItem1.Name = "deleteTableColumnsItem1"
            ' 
            ' deleteTableRowsItem1
            ' 
            Me.deleteTableRowsItem1.Id = 164
            Me.deleteTableRowsItem1.Name = "deleteTableRowsItem1"
            ' 
            ' deleteTableItem1
            ' 
            Me.deleteTableItem1.Id = 165
            Me.deleteTableItem1.Name = "deleteTableItem1"
            ' 
            ' insertTableRowAboveItem1
            ' 
            Me.insertTableRowAboveItem1.Id = 166
            Me.insertTableRowAboveItem1.Name = "insertTableRowAboveItem1"
            ' 
            ' insertTableRowBelowItem1
            ' 
            Me.insertTableRowBelowItem1.Id = 167
            Me.insertTableRowBelowItem1.Name = "insertTableRowBelowItem1"
            ' 
            ' insertTableColumnToLeftItem1
            ' 
            Me.insertTableColumnToLeftItem1.Id = 168
            Me.insertTableColumnToLeftItem1.Name = "insertTableColumnToLeftItem1"
            ' 
            ' insertTableColumnToRightItem1
            ' 
            Me.insertTableColumnToRightItem1.Id = 169
            Me.insertTableColumnToRightItem1.Name = "insertTableColumnToRightItem1"
            ' 
            ' mergeTableCellsItem1
            ' 
            Me.mergeTableCellsItem1.Id = 170
            Me.mergeTableCellsItem1.Name = "mergeTableCellsItem1"
            ' 
            ' showSplitTableCellsForm1
            ' 
            Me.showSplitTableCellsForm1.Id = 171
            Me.showSplitTableCellsForm1.Name = "showSplitTableCellsForm1"
            ' 
            ' splitTableItem1
            ' 
            Me.splitTableItem1.Id = 172
            Me.splitTableItem1.Name = "splitTableItem1"
            ' 
            ' toggleTableAutoFitItem1
            ' 
            Me.toggleTableAutoFitItem1.Id = 173
            Me.toggleTableAutoFitItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableAutoFitContentsItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableAutoFitWindowItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableFixedColumnWidthItem1) _
            })
            Me.toggleTableAutoFitItem1.Name = "toggleTableAutoFitItem1"
            ' 
            ' toggleTableAutoFitContentsItem1
            ' 
            Me.toggleTableAutoFitContentsItem1.Id = 174
            Me.toggleTableAutoFitContentsItem1.Name = "toggleTableAutoFitContentsItem1"
            ' 
            ' toggleTableAutoFitWindowItem1
            ' 
            Me.toggleTableAutoFitWindowItem1.Id = 175
            Me.toggleTableAutoFitWindowItem1.Name = "toggleTableAutoFitWindowItem1"
            ' 
            ' toggleTableFixedColumnWidthItem1
            ' 
            Me.toggleTableFixedColumnWidthItem1.Id = 176
            Me.toggleTableFixedColumnWidthItem1.Name = "toggleTableFixedColumnWidthItem1"
            ' 
            ' toggleTableCellsTopLeftAlignmentItem1
            ' 
            Me.toggleTableCellsTopLeftAlignmentItem1.Id = 177
            Me.toggleTableCellsTopLeftAlignmentItem1.Name = "toggleTableCellsTopLeftAlignmentItem1"
            ' 
            ' toggleTableCellsMiddleLeftAlignmentItem1
            ' 
            Me.toggleTableCellsMiddleLeftAlignmentItem1.Id = 178
            Me.toggleTableCellsMiddleLeftAlignmentItem1.Name = "toggleTableCellsMiddleLeftAlignmentItem1"
            ' 
            ' toggleTableCellsBottomLeftAlignmentItem1
            ' 
            Me.toggleTableCellsBottomLeftAlignmentItem1.Id = 179
            Me.toggleTableCellsBottomLeftAlignmentItem1.Name = "toggleTableCellsBottomLeftAlignmentItem1"
            ' 
            ' toggleTableCellsTopCenterAlignmentItem1
            ' 
            Me.toggleTableCellsTopCenterAlignmentItem1.Id = 180
            Me.toggleTableCellsTopCenterAlignmentItem1.Name = "toggleTableCellsTopCenterAlignmentItem1"
            ' 
            ' toggleTableCellsMiddleCenterAlignmentItem1
            ' 
            Me.toggleTableCellsMiddleCenterAlignmentItem1.Id = 181
            Me.toggleTableCellsMiddleCenterAlignmentItem1.Name = "toggleTableCellsMiddleCenterAlignmentItem1"
            ' 
            ' toggleTableCellsBottomCenterAlignmentItem1
            ' 
            Me.toggleTableCellsBottomCenterAlignmentItem1.Id = 182
            Me.toggleTableCellsBottomCenterAlignmentItem1.Name = "toggleTableCellsBottomCenterAlignmentItem1"
            ' 
            ' toggleTableCellsTopRightAlignmentItem1
            ' 
            Me.toggleTableCellsTopRightAlignmentItem1.Id = 183
            Me.toggleTableCellsTopRightAlignmentItem1.Name = "toggleTableCellsTopRightAlignmentItem1"
            ' 
            ' toggleTableCellsMiddleRightAlignmentItem1
            ' 
            Me.toggleTableCellsMiddleRightAlignmentItem1.Id = 184
            Me.toggleTableCellsMiddleRightAlignmentItem1.Name = "toggleTableCellsMiddleRightAlignmentItem1"
            ' 
            ' toggleTableCellsBottomRightAlignmentItem1
            ' 
            Me.toggleTableCellsBottomRightAlignmentItem1.Id = 185
            Me.toggleTableCellsBottomRightAlignmentItem1.Name = "toggleTableCellsBottomRightAlignmentItem1"
            ' 
            ' showTableOptionsFormItem1
            ' 
            Me.showTableOptionsFormItem1.Id = 186
            Me.showTableOptionsFormItem1.Name = "showTableOptionsFormItem1"
            ' 
            ' checkSpellingItem1
            ' 
            Me.checkSpellingItem1.Id = 187
            Me.checkSpellingItem1.Name = "checkSpellingItem1"
            ' 
            ' insertTableOfContentsItem1
            ' 
            Me.insertTableOfContentsItem1.Id = 188
            Me.insertTableOfContentsItem1.Name = "insertTableOfContentsItem1"
            ' 
            ' updateTableOfContentsItem1
            ' 
            Me.updateTableOfContentsItem1.Id = 189
            Me.updateTableOfContentsItem1.Name = "updateTableOfContentsItem1"
            ' 
            ' addParagraphsToTableOfContentItem1
            ' 
            Me.addParagraphsToTableOfContentItem1.Id = 190
            Me.addParagraphsToTableOfContentItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem2), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem3), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem4), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem5), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem6), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem7), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem8), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem9), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem10) _
            })
            Me.addParagraphsToTableOfContentItem1.Name = "addParagraphsToTableOfContentItem1"
            ' 
            ' setParagraphHeadingLevelItem1
            ' 
            Me.setParagraphHeadingLevelItem1.Id = 191
            Me.setParagraphHeadingLevelItem1.Name = "setParagraphHeadingLevelItem1"
            Me.setParagraphHeadingLevelItem1.OutlineLevel = 0
            ' 
            ' setParagraphHeadingLevelItem2
            ' 
            Me.setParagraphHeadingLevelItem2.Id = 192
            Me.setParagraphHeadingLevelItem2.Name = "setParagraphHeadingLevelItem2"
            Me.setParagraphHeadingLevelItem2.OutlineLevel = 1
            ' 
            ' setParagraphHeadingLevelItem3
            ' 
            Me.setParagraphHeadingLevelItem3.Id = 193
            Me.setParagraphHeadingLevelItem3.Name = "setParagraphHeadingLevelItem3"
            Me.setParagraphHeadingLevelItem3.OutlineLevel = 2
            ' 
            ' setParagraphHeadingLevelItem4
            ' 
            Me.setParagraphHeadingLevelItem4.Id = 194
            Me.setParagraphHeadingLevelItem4.Name = "setParagraphHeadingLevelItem4"
            Me.setParagraphHeadingLevelItem4.OutlineLevel = 3
            ' 
            ' setParagraphHeadingLevelItem5
            ' 
            Me.setParagraphHeadingLevelItem5.Id = 195
            Me.setParagraphHeadingLevelItem5.Name = "setParagraphHeadingLevelItem5"
            Me.setParagraphHeadingLevelItem5.OutlineLevel = 4
            ' 
            ' setParagraphHeadingLevelItem6
            ' 
            Me.setParagraphHeadingLevelItem6.Id = 196
            Me.setParagraphHeadingLevelItem6.Name = "setParagraphHeadingLevelItem6"
            Me.setParagraphHeadingLevelItem6.OutlineLevel = 5
            ' 
            ' setParagraphHeadingLevelItem7
            ' 
            Me.setParagraphHeadingLevelItem7.Id = 197
            Me.setParagraphHeadingLevelItem7.Name = "setParagraphHeadingLevelItem7"
            Me.setParagraphHeadingLevelItem7.OutlineLevel = 6
            ' 
            ' setParagraphHeadingLevelItem8
            ' 
            Me.setParagraphHeadingLevelItem8.Id = 198
            Me.setParagraphHeadingLevelItem8.Name = "setParagraphHeadingLevelItem8"
            Me.setParagraphHeadingLevelItem8.OutlineLevel = 7
            ' 
            ' setParagraphHeadingLevelItem9
            ' 
            Me.setParagraphHeadingLevelItem9.Id = 199
            Me.setParagraphHeadingLevelItem9.Name = "setParagraphHeadingLevelItem9"
            Me.setParagraphHeadingLevelItem9.OutlineLevel = 8
            ' 
            ' setParagraphHeadingLevelItem10
            ' 
            Me.setParagraphHeadingLevelItem10.Id = 200
            Me.setParagraphHeadingLevelItem10.Name = "setParagraphHeadingLevelItem10"
            Me.setParagraphHeadingLevelItem10.OutlineLevel = 9
            ' 
            ' insertCaptionPlaceholderItem1
            ' 
            Me.insertCaptionPlaceholderItem1.Id = 201
            Me.insertCaptionPlaceholderItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertFiguresCaptionItems1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertTablesCaptionItems1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertEquationsCaptionItems1) _
            })
            Me.insertCaptionPlaceholderItem1.Name = "insertCaptionPlaceholderItem1"
            ' 
            ' insertFiguresCaptionItems1
            ' 
            Me.insertFiguresCaptionItems1.Id = 202
            Me.insertFiguresCaptionItems1.Name = "insertFiguresCaptionItems1"
            ' 
            ' insertTablesCaptionItems1
            ' 
            Me.insertTablesCaptionItems1.Id = 203
            Me.insertTablesCaptionItems1.Name = "insertTablesCaptionItems1"
            ' 
            ' insertEquationsCaptionItems1
            ' 
            Me.insertEquationsCaptionItems1.Id = 204
            Me.insertEquationsCaptionItems1.Name = "insertEquationsCaptionItems1"
            ' 
            ' insertTableOfFiguresPlaceholderItem1
            ' 
            Me.insertTableOfFiguresPlaceholderItem1.Id = 205
            Me.insertTableOfFiguresPlaceholderItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertTableOfFiguresItems1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertTableOfTablesItems1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertTableOfEquationsItems1) _
            })
            Me.insertTableOfFiguresPlaceholderItem1.Name = "insertTableOfFiguresPlaceholderItem1"
            ' 
            ' insertTableOfFiguresItems1
            ' 
            Me.insertTableOfFiguresItems1.Id = 206
            Me.insertTableOfFiguresItems1.Name = "insertTableOfFiguresItems1"
            ' 
            ' insertTableOfTablesItems1
            ' 
            Me.insertTableOfTablesItems1.Id = 207
            Me.insertTableOfTablesItems1.Name = "insertTableOfTablesItems1"
            ' 
            ' insertTableOfEquationsItems1
            ' 
            Me.insertTableOfEquationsItems1.Id = 208
            Me.insertTableOfEquationsItems1.Name = "insertTableOfEquationsItems1"
            ' 
            ' updateTableOfFiguresItem1
            ' 
            Me.updateTableOfFiguresItem1.Id = 209
            Me.updateTableOfFiguresItem1.Name = "updateTableOfFiguresItem1"
            ' 
            ' changeFloatingObjectFillColorItem1
            ' 
            Me.changeFloatingObjectFillColorItem1.Id = 210
            Me.changeFloatingObjectFillColorItem1.Name = "changeFloatingObjectFillColorItem1"
            ' 
            ' changeFloatingObjectOutlineColorItem1
            ' 
            Me.changeFloatingObjectOutlineColorItem1.Id = 211
            Me.changeFloatingObjectOutlineColorItem1.Name = "changeFloatingObjectOutlineColorItem1"
            ' 
            ' changeFloatingObjectOutlineWeightItem1
            ' 
            Me.changeFloatingObjectOutlineWeightItem1.Edit = Me.repositoryItemFloatingObjectOutlineWeight1
            Me.changeFloatingObjectOutlineWeightItem1.EditValue = 20
            Me.changeFloatingObjectOutlineWeightItem1.Id = 212
            Me.changeFloatingObjectOutlineWeightItem1.Name = "changeFloatingObjectOutlineWeightItem1"
            ' 
            ' repositoryItemFloatingObjectOutlineWeight1
            ' 
            Me.repositoryItemFloatingObjectOutlineWeight1.AutoHeight = False
            Me.repositoryItemFloatingObjectOutlineWeight1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemFloatingObjectOutlineWeight1.Control = Me.snapControl1
            Me.repositoryItemFloatingObjectOutlineWeight1.Name = "repositoryItemFloatingObjectOutlineWeight1"
            ' 
            ' changeFloatingObjectTextWrapTypeItem1
            ' 
            Me.changeFloatingObjectTextWrapTypeItem1.Id = 213
            Me.changeFloatingObjectTextWrapTypeItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectSquareTextWrapTypeItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTightTextWrapTypeItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectThroughTextWrapTypeItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTopAndBottomTextWrapTypeItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectBehindTextWrapTypeItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectInFrontOfTextWrapTypeItem1) _
            })
            Me.changeFloatingObjectTextWrapTypeItem1.Name = "changeFloatingObjectTextWrapTypeItem1"
            ' 
            ' setFloatingObjectSquareTextWrapTypeItem1
            ' 
            Me.setFloatingObjectSquareTextWrapTypeItem1.Id = 214
            Me.setFloatingObjectSquareTextWrapTypeItem1.Name = "setFloatingObjectSquareTextWrapTypeItem1"
            ' 
            ' setFloatingObjectTightTextWrapTypeItem1
            ' 
            Me.setFloatingObjectTightTextWrapTypeItem1.Id = 215
            Me.setFloatingObjectTightTextWrapTypeItem1.Name = "setFloatingObjectTightTextWrapTypeItem1"
            ' 
            ' setFloatingObjectThroughTextWrapTypeItem1
            ' 
            Me.setFloatingObjectThroughTextWrapTypeItem1.Id = 216
            Me.setFloatingObjectThroughTextWrapTypeItem1.Name = "setFloatingObjectThroughTextWrapTypeItem1"
            ' 
            ' setFloatingObjectTopAndBottomTextWrapTypeItem1
            ' 
            Me.setFloatingObjectTopAndBottomTextWrapTypeItem1.Id = 217
            Me.setFloatingObjectTopAndBottomTextWrapTypeItem1.Name = "setFloatingObjectTopAndBottomTextWrapTypeItem1"
            ' 
            ' setFloatingObjectBehindTextWrapTypeItem1
            ' 
            Me.setFloatingObjectBehindTextWrapTypeItem1.Id = 218
            Me.setFloatingObjectBehindTextWrapTypeItem1.Name = "setFloatingObjectBehindTextWrapTypeItem1"
            ' 
            ' setFloatingObjectInFrontOfTextWrapTypeItem1
            ' 
            Me.setFloatingObjectInFrontOfTextWrapTypeItem1.Id = 219
            Me.setFloatingObjectInFrontOfTextWrapTypeItem1.Name = "setFloatingObjectInFrontOfTextWrapTypeItem1"
            ' 
            ' changeFloatingObjectAlignmentItem1
            ' 
            Me.changeFloatingObjectAlignmentItem1.Id = 220
            Me.changeFloatingObjectAlignmentItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTopLeftAlignmentItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTopCenterAlignmentItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTopRightAlignmentItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectMiddleLeftAlignmentItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectMiddleCenterAlignmentItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectMiddleRightAlignmentItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectBottomLeftAlignmentItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectBottomCenterAlignmentItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectBottomRightAlignmentItem1) _
            })
            Me.changeFloatingObjectAlignmentItem1.Name = "changeFloatingObjectAlignmentItem1"
            ' 
            ' setFloatingObjectTopLeftAlignmentItem1
            ' 
            Me.setFloatingObjectTopLeftAlignmentItem1.Id = 221
            Me.setFloatingObjectTopLeftAlignmentItem1.Name = "setFloatingObjectTopLeftAlignmentItem1"
            ' 
            ' setFloatingObjectTopCenterAlignmentItem1
            ' 
            Me.setFloatingObjectTopCenterAlignmentItem1.Id = 222
            Me.setFloatingObjectTopCenterAlignmentItem1.Name = "setFloatingObjectTopCenterAlignmentItem1"
            ' 
            ' setFloatingObjectTopRightAlignmentItem1
            ' 
            Me.setFloatingObjectTopRightAlignmentItem1.Id = 223
            Me.setFloatingObjectTopRightAlignmentItem1.Name = "setFloatingObjectTopRightAlignmentItem1"
            ' 
            ' setFloatingObjectMiddleLeftAlignmentItem1
            ' 
            Me.setFloatingObjectMiddleLeftAlignmentItem1.Id = 224
            Me.setFloatingObjectMiddleLeftAlignmentItem1.Name = "setFloatingObjectMiddleLeftAlignmentItem1"
            ' 
            ' setFloatingObjectMiddleCenterAlignmentItem1
            ' 
            Me.setFloatingObjectMiddleCenterAlignmentItem1.Id = 225
            Me.setFloatingObjectMiddleCenterAlignmentItem1.Name = "setFloatingObjectMiddleCenterAlignmentItem1"
            ' 
            ' setFloatingObjectMiddleRightAlignmentItem1
            ' 
            Me.setFloatingObjectMiddleRightAlignmentItem1.Id = 226
            Me.setFloatingObjectMiddleRightAlignmentItem1.Name = "setFloatingObjectMiddleRightAlignmentItem1"
            ' 
            ' setFloatingObjectBottomLeftAlignmentItem1
            ' 
            Me.setFloatingObjectBottomLeftAlignmentItem1.Id = 227
            Me.setFloatingObjectBottomLeftAlignmentItem1.Name = "setFloatingObjectBottomLeftAlignmentItem1"
            ' 
            ' setFloatingObjectBottomCenterAlignmentItem1
            ' 
            Me.setFloatingObjectBottomCenterAlignmentItem1.Id = 228
            Me.setFloatingObjectBottomCenterAlignmentItem1.Name = "setFloatingObjectBottomCenterAlignmentItem1"
            ' 
            ' setFloatingObjectBottomRightAlignmentItem1
            ' 
            Me.setFloatingObjectBottomRightAlignmentItem1.Id = 229
            Me.setFloatingObjectBottomRightAlignmentItem1.Name = "setFloatingObjectBottomRightAlignmentItem1"
            ' 
            ' floatingObjectBringForwardSubItem1
            ' 
            Me.floatingObjectBringForwardSubItem1.Id = 230
            Me.floatingObjectBringForwardSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectBringForwardItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectBringToFrontItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectBringInFrontOfTextItem1) _
            })
            Me.floatingObjectBringForwardSubItem1.Name = "floatingObjectBringForwardSubItem1"
            ' 
            ' floatingObjectBringForwardItem1
            ' 
            Me.floatingObjectBringForwardItem1.Id = 231
            Me.floatingObjectBringForwardItem1.Name = "floatingObjectBringForwardItem1"
            ' 
            ' floatingObjectBringToFrontItem1
            ' 
            Me.floatingObjectBringToFrontItem1.Id = 232
            Me.floatingObjectBringToFrontItem1.Name = "floatingObjectBringToFrontItem1"
            ' 
            ' floatingObjectBringInFrontOfTextItem1
            ' 
            Me.floatingObjectBringInFrontOfTextItem1.Id = 233
            Me.floatingObjectBringInFrontOfTextItem1.Name = "floatingObjectBringInFrontOfTextItem1"
            ' 
            ' floatingObjectSendBackwardSubItem1
            ' 
            Me.floatingObjectSendBackwardSubItem1.Id = 234
            Me.floatingObjectSendBackwardSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectSendBackwardItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectSendToBackItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectSendBehindTextItem1) _
            })
            Me.floatingObjectSendBackwardSubItem1.Name = "floatingObjectSendBackwardSubItem1"
            ' 
            ' floatingObjectSendBackwardItem1
            ' 
            Me.floatingObjectSendBackwardItem1.Id = 235
            Me.floatingObjectSendBackwardItem1.Name = "floatingObjectSendBackwardItem1"
            ' 
            ' floatingObjectSendToBackItem1
            ' 
            Me.floatingObjectSendToBackItem1.Id = 236
            Me.floatingObjectSendToBackItem1.Name = "floatingObjectSendToBackItem1"
            ' 
            ' floatingObjectSendBehindTextItem1
            ' 
            Me.floatingObjectSendBehindTextItem1.Id = 237
            Me.floatingObjectSendBehindTextItem1.Name = "floatingObjectSendBehindTextItem1"
            ' 
            ' themesGalleryBarItem1
            ' 
            ' 
            ' 
            ' 
            Me.themesGalleryBarItem1.Gallery.ColumnCount = 7
            Me.themesGalleryBarItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.themesGalleryBarItem1.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleCheck
            Me.themesGalleryBarItem1.Gallery.RowCount = 1
            Me.themesGalleryBarItem1.Id = 238
            Me.themesGalleryBarItem1.Name = "themesGalleryBarItem1"
            ' 
            ' commandBarCheckItem2
            ' 
            Me.commandBarCheckItem2.Id = 239
            Me.commandBarCheckItem2.Name = "commandBarCheckItem2"
            Me.commandBarCheckItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            Me.commandBarCheckItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupByField
            ' 
            ' commandBarCheckItem3
            ' 
            Me.commandBarCheckItem3.Id = 240
            Me.commandBarCheckItem3.Name = "commandBarCheckItem3"
            Me.commandBarCheckItem3.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapSortFieldAscending
            ' 
            ' commandBarCheckItem4
            ' 
            Me.commandBarCheckItem4.Id = 241
            Me.commandBarCheckItem4.Name = "commandBarCheckItem4"
            Me.commandBarCheckItem4.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapSortFieldDescending
            ' 
            ' commandBarSubItem1
            ' 
            Me.commandBarSubItem1.Id = 242
            Me.commandBarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem5), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem6), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem7), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem8), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem9) _
            })
            Me.commandBarSubItem1.Name = "commandBarSubItem1"
            Me.commandBarSubItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryByField
            ' 
            ' commandBarCheckItem5
            ' 
            Me.commandBarCheckItem5.Id = 243
            Me.commandBarCheckItem5.Name = "commandBarCheckItem5"
            Me.commandBarCheckItem5.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryCount
            ' 
            ' commandBarCheckItem6
            ' 
            Me.commandBarCheckItem6.Id = 244
            Me.commandBarCheckItem6.Name = "commandBarCheckItem6"
            Me.commandBarCheckItem6.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummarySum
            ' 
            ' commandBarCheckItem7
            ' 
            Me.commandBarCheckItem7.Id = 245
            Me.commandBarCheckItem7.Name = "commandBarCheckItem7"
            Me.commandBarCheckItem7.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryAverage
            ' 
            ' commandBarCheckItem8
            ' 
            Me.commandBarCheckItem8.Id = 246
            Me.commandBarCheckItem8.Name = "commandBarCheckItem8"
            Me.commandBarCheckItem8.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryMax
            ' 
            ' commandBarCheckItem9
            ' 
            Me.commandBarCheckItem9.Id = 247
            Me.commandBarCheckItem9.Name = "commandBarCheckItem9"
            Me.commandBarCheckItem9.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryMin
            ' 
            ' filterPopupButtonItem1
            ' 
            Me.filterPopupButtonItem1.ActAsDropDown = True
            Me.filterPopupButtonItem1.Id = 248
            Me.filterPopupButtonItem1.Name = "filterPopupButtonItem1"
            ' 
            ' propertiesBarButtonItem1
            ' 
            Me.propertiesBarButtonItem1.ActAsDropDown = True
            Me.propertiesBarButtonItem1.Id = 249
            Me.propertiesBarButtonItem1.Name = "propertiesBarButtonItem1"
            Me.propertiesBarButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' commandBarSubItem2
            ' 
            Me.commandBarSubItem2.Id = 250
            Me.commandBarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem10), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem11) _
            })
            Me.commandBarSubItem2.Name = "commandBarSubItem2"
            Me.commandBarSubItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            Me.commandBarSubItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupHeader
            ' 
            ' commandBarCheckItem10
            ' 
            Me.commandBarCheckItem10.Id = 251
            Me.commandBarCheckItem10.Name = "commandBarCheckItem10"
            Me.commandBarCheckItem10.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertGroupHeader
            ' 
            ' commandBarCheckItem11
            ' 
            Me.commandBarCheckItem11.Id = 252
            Me.commandBarCheckItem11.Name = "commandBarCheckItem11"
            Me.commandBarCheckItem11.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveGroupHeader
            ' 
            ' commandBarSubItem3
            ' 
            Me.commandBarSubItem3.Id = 253
            Me.commandBarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem12), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem13) _
            })
            Me.commandBarSubItem3.Name = "commandBarSubItem3"
            Me.commandBarSubItem3.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupFooter
            ' 
            ' commandBarCheckItem12
            ' 
            Me.commandBarCheckItem12.Id = 254
            Me.commandBarCheckItem12.Name = "commandBarCheckItem12"
            Me.commandBarCheckItem12.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertGroupFooter
            ' 
            ' commandBarCheckItem13
            ' 
            Me.commandBarCheckItem13.Id = 255
            Me.commandBarCheckItem13.Name = "commandBarCheckItem13"
            Me.commandBarCheckItem13.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveGroupFooter
            ' 
            ' commandBarItem8
            ' 
            Me.commandBarItem8.Id = 256
            Me.commandBarItem8.Name = "commandBarItem8"
            Me.commandBarItem8.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupFieldsCollection
            ' 
            ' commandBarItem9
            ' 
            Me.commandBarItem9.Id = 257
            Me.commandBarItem9.Name = "commandBarItem9"
            Me.commandBarItem9.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ShowReportStructureEditorForm
            ' 
            ' commandBarSubItem4
            ' 
            Me.commandBarSubItem4.Id = 258
            Me.commandBarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem14), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem15), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem16), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem17), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem18), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem19), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem20) _
            })
            Me.commandBarSubItem4.Name = "commandBarSubItem4"
            Me.commandBarSubItem4.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertGroupSeparator
            ' 
            ' commandBarCheckItem14
            ' 
            Me.commandBarCheckItem14.Id = 259
            Me.commandBarCheckItem14.Name = "commandBarCheckItem14"
            Me.commandBarCheckItem14.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertPageBreakGroupSeparator
            ' 
            ' commandBarCheckItem15
            ' 
            Me.commandBarCheckItem15.Id = 260
            Me.commandBarCheckItem15.Name = "commandBarCheckItem15"
            Me.commandBarCheckItem15.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakNextPageGroupSeparator
            ' 
            ' commandBarCheckItem16
            ' 
            Me.commandBarCheckItem16.Id = 261
            Me.commandBarCheckItem16.Name = "commandBarCheckItem16"
            Me.commandBarCheckItem16.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakEvenPageGroupSeparator
            ' 
            ' commandBarCheckItem17
            ' 
            Me.commandBarCheckItem17.Id = 262
            Me.commandBarCheckItem17.Name = "commandBarCheckItem17"
            Me.commandBarCheckItem17.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakOddPageGroupSeparator
            ' 
            ' commandBarCheckItem18
            ' 
            Me.commandBarCheckItem18.Id = 263
            Me.commandBarCheckItem18.Name = "commandBarCheckItem18"
            Me.commandBarCheckItem18.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyParagraphGroupSeparator
            ' 
            ' commandBarCheckItem19
            ' 
            Me.commandBarCheckItem19.Id = 264
            Me.commandBarCheckItem19.Name = "commandBarCheckItem19"
            Me.commandBarCheckItem19.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyRowGroupSeparator
            ' 
            ' commandBarCheckItem20
            ' 
            Me.commandBarCheckItem20.Id = 265
            Me.commandBarCheckItem20.Name = "commandBarCheckItem20"
            Me.commandBarCheckItem20.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertNoneGroupSeparator
            ' 
            ' commandBarSubItem5
            ' 
            Me.commandBarSubItem5.Id = 267
            Me.commandBarSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem21), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem22) _
            })
            Me.commandBarSubItem5.Name = "commandBarSubItem5"
            Me.commandBarSubItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            Me.commandBarSubItem5.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ListHeader
            ' 
            ' commandBarCheckItem21
            ' 
            Me.commandBarCheckItem21.Id = 268
            Me.commandBarCheckItem21.Name = "commandBarCheckItem21"
            Me.commandBarCheckItem21.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertListHeader
            ' 
            ' commandBarCheckItem22
            ' 
            Me.commandBarCheckItem22.Id = 269
            Me.commandBarCheckItem22.Name = "commandBarCheckItem22"
            Me.commandBarCheckItem22.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveListHeader
            ' 
            ' commandBarSubItem6
            ' 
            Me.commandBarSubItem6.Id = 270
            Me.commandBarSubItem6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem23), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem24) _
            })
            Me.commandBarSubItem6.Name = "commandBarSubItem6"
            Me.commandBarSubItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            Me.commandBarSubItem6.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ListFooter
            ' 
            ' commandBarCheckItem23
            ' 
            Me.commandBarCheckItem23.Id = 271
            Me.commandBarCheckItem23.Name = "commandBarCheckItem23"
            Me.commandBarCheckItem23.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertListFooter
            ' 
            ' commandBarCheckItem24
            ' 
            Me.commandBarCheckItem24.Id = 272
            Me.commandBarCheckItem24.Name = "commandBarCheckItem24"
            Me.commandBarCheckItem24.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveListFooter
            ' 
            ' commandBarItem10
            ' 
            Me.commandBarItem10.Id = 273
            Me.commandBarItem10.Name = "commandBarItem10"
            Me.commandBarItem10.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.FilterList
            ' 
            ' commandBarItem11
            ' 
            Me.commandBarItem11.Id = 274
            Me.commandBarItem11.Name = "commandBarItem11"
            Me.commandBarItem11.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ConvertToParagraphs
            ' 
            ' commandBarSubItem7
            ' 
            Me.commandBarSubItem7.Id = 275
            Me.commandBarSubItem7.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem25), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem26), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem27), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem28), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem29), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem30), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem31) _
            })
            Me.commandBarSubItem7.Name = "commandBarSubItem7"
            Me.commandBarSubItem7.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertDataRowSeparator
            ' 
            ' commandBarCheckItem25
            ' 
            Me.commandBarCheckItem25.Id = 276
            Me.commandBarCheckItem25.Name = "commandBarCheckItem25"
            Me.commandBarCheckItem25.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertPageBreakDataRowSeparator
            ' 
            ' commandBarCheckItem26
            ' 
            Me.commandBarCheckItem26.Id = 277
            Me.commandBarCheckItem26.Name = "commandBarCheckItem26"
            Me.commandBarCheckItem26.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakNextPageDataRowSeparator
            ' 
            ' commandBarCheckItem27
            ' 
            Me.commandBarCheckItem27.Id = 278
            Me.commandBarCheckItem27.Name = "commandBarCheckItem27"
            Me.commandBarCheckItem27.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakEvenPageDataRowSeparator
            ' 
            ' commandBarCheckItem28
            ' 
            Me.commandBarCheckItem28.Id = 279
            Me.commandBarCheckItem28.Name = "commandBarCheckItem28"
            Me.commandBarCheckItem28.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakOddPageDataRowSeparator
            ' 
            ' commandBarCheckItem29
            ' 
            Me.commandBarCheckItem29.Id = 280
            Me.commandBarCheckItem29.Name = "commandBarCheckItem29"
            Me.commandBarCheckItem29.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyParagraphDataRowSeparator
            ' 
            ' commandBarCheckItem30
            ' 
            Me.commandBarCheckItem30.Id = 281
            Me.commandBarCheckItem30.Name = "commandBarCheckItem30"
            Me.commandBarCheckItem30.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyRowDataRowSeparator
            ' 
            ' commandBarCheckItem31
            ' 
            Me.commandBarCheckItem31.Id = 282
            Me.commandBarCheckItem31.Name = "commandBarCheckItem31"
            Me.commandBarCheckItem31.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertNoneDataRowSeparator
            ' 
            ' commandBarItem12
            ' 
            Me.commandBarItem12.Id = 283
            Me.commandBarItem12.Name = "commandBarItem12"
            Me.commandBarItem12.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.DeleteList
            ' 
            ' barButtonGroup8
            ' 
            Me.barButtonGroup8.Id = 266
            Me.barButtonGroup8.ItemLinks.Add(Me.changeEditorRowLimitItem1)
            Me.barButtonGroup8.Name = "barButtonGroup8"
            Me.barButtonGroup8.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}"
            ' 
            ' changeEditorRowLimitItem1
            ' 
            Me.changeEditorRowLimitItem1.Edit = Me.repositoryItemEditorRowLimitEdit1
            Me.changeEditorRowLimitItem1.Id = 284
            Me.changeEditorRowLimitItem1.Name = "changeEditorRowLimitItem1"
            Me.changeEditorRowLimitItem1.Width = 90
            ' 
            ' repositoryItemEditorRowLimitEdit1
            ' 
            Me.repositoryItemEditorRowLimitEdit1.AutoHeight = False
            Me.repositoryItemEditorRowLimitEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemEditorRowLimitEdit1.Control = Me.snapControl1
            Me.repositoryItemEditorRowLimitEdit1.Name = "repositoryItemEditorRowLimitEdit1"
            ' 
            ' createBarBaseItem1
            ' 
            Me.createBarBaseItem1.DropDownControl = Me.commandBarGalleryDropDown1
            Me.createBarBaseItem1.Id = 285
            Me.createBarBaseItem1.Name = "createBarBaseItem1"
            ' 
            ' commandBarGalleryDropDown1
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown1.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown1.Gallery.ColumnCount = 4
            chartControlCommandGalleryItemGroup2DColumn2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createBarChartItem2, createFullStackedBarChartItem2, createSideBySideFullStackedBarChartItem2, createSideBySideStackedBarChartItem2, createStackedBarChartItem2})
            chartControlCommandGalleryItemGroup3DColumn2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createBar3DChartItem2, createFullStackedBar3DChartItem2, createManhattanBarChartItem2, createSideBySideFullStackedBar3DChartItem2, createSideBySideStackedBar3DChartItem2, createStackedBar3DChartItem2})
            chartControlCommandGalleryItemGroupCylinderColumn2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createCylinderBar3DChartItem2, createCylinderFullStackedBar3DChartItem2, createCylinderManhattanBarChartItem2, createCylinderSideBySideFullStackedBar3DChartItem2, createCylinderSideBySideStackedBar3DChartItem2, createCylinderStackedBar3DChartItem2})
            chartControlCommandGalleryItemGroupConeColumn2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createConeBar3DChartItem2, createConeFullStackedBar3DChartItem2, createConeManhattanBarChartItem2, createConeSideBySideFullStackedBar3DChartItem2, createConeSideBySideStackedBar3DChartItem2, createConeStackedBar3DChartItem2})
            chartControlCommandGalleryItemGroupPyramidColumn2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPyramidBar3DChartItem2, createPyramidFullStackedBar3DChartItem2, createPyramidManhattanBarChartItem2, createPyramidSideBySideFullStackedBar3DChartItem2, createPyramidSideBySideStackedBar3DChartItem2, createPyramidStackedBar3DChartItem2})
            Me.commandBarGalleryDropDown1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DColumn2, chartControlCommandGalleryItemGroup3DColumn2, chartControlCommandGalleryItemGroupCylinderColumn2, chartControlCommandGalleryItemGroupConeColumn2, chartControlCommandGalleryItemGroupPyramidColumn2})
            Me.commandBarGalleryDropDown1.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown1.Gallery.RowCount = 10
            Me.commandBarGalleryDropDown1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown1.Manager = Nothing
            Me.commandBarGalleryDropDown1.Name = "commandBarGalleryDropDown1"
            ' 
            ' createLineBaseItem1
            ' 
            Me.createLineBaseItem1.DropDownControl = Me.commandBarGalleryDropDown2
            Me.createLineBaseItem1.Id = 286
            Me.createLineBaseItem1.Name = "createLineBaseItem1"
            ' 
            ' commandBarGalleryDropDown2
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown2.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown2.Gallery.ColumnCount = 3
            chartControlCommandGalleryItemGroup2DLine2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createLineChartItem2, createFullStackedLineChartItem2, createScatterLineChartItem2, createSplineChartItem2, createStackedLineChartItem2, createStepLineChartItem2})
            chartControlCommandGalleryItemGroup3DLine2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createLine3DChartItem2, createFullStackedLine3DChartItem2, createSpline3DChartItem2, createStackedLine3DChartItem2, createStepLine3DChartItem2})
            Me.commandBarGalleryDropDown2.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DLine2, chartControlCommandGalleryItemGroup3DLine2})
            Me.commandBarGalleryDropDown2.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown2.Gallery.RowCount = 4
            Me.commandBarGalleryDropDown2.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown2.Manager = Nothing
            Me.commandBarGalleryDropDown2.Name = "commandBarGalleryDropDown2"
            ' 
            ' createPieBaseItem1
            ' 
            Me.createPieBaseItem1.DropDownControl = Me.commandBarGalleryDropDown3
            Me.createPieBaseItem1.Id = 287
            Me.createPieBaseItem1.Name = "createPieBaseItem1"
            ' 
            ' commandBarGalleryDropDown3
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown3.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown3.Gallery.ColumnCount = 2
            chartControlCommandGalleryItemGroup2DPie2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPieChartItem2, createDoughnutChartItem2})
            chartControlCommandGalleryItemGroup3DPie2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPie3DChartItem2, createDoughnut3DChartItem2})
            Me.commandBarGalleryDropDown3.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DPie2, chartControlCommandGalleryItemGroup3DPie2})
            Me.commandBarGalleryDropDown3.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown3.Gallery.RowCount = 2
            Me.commandBarGalleryDropDown3.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown3.Manager = Nothing
            Me.commandBarGalleryDropDown3.Name = "commandBarGalleryDropDown3"
            ' 
            ' createRotatedBarBaseItem1
            ' 
            Me.createRotatedBarBaseItem1.DropDownControl = Me.commandBarGalleryDropDown4
            Me.createRotatedBarBaseItem1.Id = 288
            Me.createRotatedBarBaseItem1.Name = "createRotatedBarBaseItem1"
            ' 
            ' commandBarGalleryDropDown4
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown4.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown4.Gallery.ColumnCount = 3
            chartControlCommandGalleryItemGroup2DBar2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRotatedBarChartItem2, createRotatedFullStackedBarChartItem2, createRotatedSideBySideFullStackedBarChartItem2, createRotatedSideBySideStackedBarChartItem2, createRotatedStackedBarChartItem2})
            Me.commandBarGalleryDropDown4.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DBar2})
            Me.commandBarGalleryDropDown4.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown4.Gallery.RowCount = 2
            Me.commandBarGalleryDropDown4.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown4.Manager = Nothing
            Me.commandBarGalleryDropDown4.Name = "commandBarGalleryDropDown4"
            ' 
            ' createAreaBaseItem1
            ' 
            Me.createAreaBaseItem1.DropDownControl = Me.commandBarGalleryDropDown5
            Me.createAreaBaseItem1.Id = 289
            Me.createAreaBaseItem1.Name = "createAreaBaseItem1"
            ' 
            ' commandBarGalleryDropDown5
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown5.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown5.Gallery.ColumnCount = 4
            chartControlCommandGalleryItemGroup2DArea2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createAreaChartItem2, createFullStackedAreaChartItem2, createFullStackedSplineAreaChartItem2, createSplineAreaChartItem2, createStackedAreaChartItem2, createStackedSplineAreaChartItem2, createStepAreaChartItem2})
            chartControlCommandGalleryItemGroup3DArea2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createArea3DChartItem2, createFullStackedArea3DChartItem2, createFullStackedSplineArea3DChartItem2, createSplineArea3DChartItem2, createStackedArea3DChartItem2, createStackedSplineArea3DChartItem2, createStepArea3DChartItem2})
            Me.commandBarGalleryDropDown5.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DArea2, chartControlCommandGalleryItemGroup3DArea2})
            Me.commandBarGalleryDropDown5.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown5.Gallery.RowCount = 4
            Me.commandBarGalleryDropDown5.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown5.Manager = Nothing
            Me.commandBarGalleryDropDown5.Name = "commandBarGalleryDropDown5"
            ' 
            ' createOtherSeriesTypesBaseItem1
            ' 
            Me.createOtherSeriesTypesBaseItem1.DropDownControl = Me.commandBarGalleryDropDown6
            Me.createOtherSeriesTypesBaseItem1.Id = 290
            Me.createOtherSeriesTypesBaseItem1.Name = "createOtherSeriesTypesBaseItem1"
            ' 
            ' commandBarGalleryDropDown6
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown6.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown6.Gallery.ColumnCount = 4
            chartControlCommandGalleryItemGroupPoint2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPointChartItem2, createBubbleChartItem2})
            chartControlCommandGalleryItemGroupFunnel2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createFunnelChartItem2, createFunnel3DChartItem2})
            chartControlCommandGalleryItemGroupFinancial2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createStockChartItem2, createCandleStickChartItem2})
            chartControlCommandGalleryItemGroupRadar2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRadarPointChartItem2, createRadarLineChartItem2, createRadarAreaChartItem2})
            chartControlCommandGalleryItemGroupPolar2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPolarPointChartItem2, createPolarLineChartItem2, createPolarAreaChartItem2})
            chartControlCommandGalleryItemGroupRange2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRangeBarChartItem2, createSideBySideRangeBarChartItem2, createRangeAreaChartItem2, createRangeArea3DChartItem2})
            chartControlCommandGalleryItemGroupGantt2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createGanttChartItem2, createSideBySideGanttChartItem2})
            Me.commandBarGalleryDropDown6.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroupPoint2, chartControlCommandGalleryItemGroupFunnel2, chartControlCommandGalleryItemGroupFinancial2, chartControlCommandGalleryItemGroupRadar2, chartControlCommandGalleryItemGroupPolar2, chartControlCommandGalleryItemGroupRange2, chartControlCommandGalleryItemGroupGantt2})
            Me.commandBarGalleryDropDown6.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown6.Gallery.RowCount = 7
            Me.commandBarGalleryDropDown6.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown6.Manager = Nothing
            Me.commandBarGalleryDropDown6.Name = "commandBarGalleryDropDown6"
            ' 
            ' changePaletteGalleryBaseItem1
            ' 
            Me.changePaletteGalleryBaseItem1.DropDownControl = Me.commandBarGalleryDropDown7
            Me.changePaletteGalleryBaseItem1.Id = 291
            Me.changePaletteGalleryBaseItem1.Name = "changePaletteGalleryBaseItem1"
            ' 
            ' commandBarGalleryDropDown7
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown7.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseFont = True
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = True
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseFont = True
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = True
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseFont = True
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = True
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.commandBarGalleryDropDown7.Gallery.ColumnCount = 1
            Me.commandBarGalleryDropDown7.Gallery.ImageSize = New System.Drawing.Size(160, 10)
            Me.commandBarGalleryDropDown7.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown7.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Right
            skinPaddingEdges3.Bottom = -3
            skinPaddingEdges3.Top = -3
            Me.commandBarGalleryDropDown7.Gallery.ItemImagePadding = skinPaddingEdges3
            skinPaddingEdges4.Bottom = -3
            skinPaddingEdges4.Top = -3
            Me.commandBarGalleryDropDown7.Gallery.ItemTextPadding = skinPaddingEdges4
            Me.commandBarGalleryDropDown7.Gallery.RowCount = 10
            Me.commandBarGalleryDropDown7.Gallery.ShowGroupCaption = False
            Me.commandBarGalleryDropDown7.Gallery.ShowItemText = True
            Me.commandBarGalleryDropDown7.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown7.Manager = Nothing
            Me.commandBarGalleryDropDown7.Name = "commandBarGalleryDropDown7"
            ' 
            ' changeAppearanceGalleryBaseItem1
            ' 
            ' 
            ' 
            ' 
            Me.changeAppearanceGalleryBaseItem1.Gallery.ColumnCount = 7
            Me.changeAppearanceGalleryBaseItem1.Gallery.ImageSize = New System.Drawing.Size(80, 50)
            Me.changeAppearanceGalleryBaseItem1.Gallery.RowCount = 4
            Me.changeAppearanceGalleryBaseItem1.Id = 292
            Me.changeAppearanceGalleryBaseItem1.Name = "changeAppearanceGalleryBaseItem1"
            ' 
            ' runWizardChartItem1
            ' 
            Me.runWizardChartItem1.Id = 293
            Me.runWizardChartItem1.Name = "runWizardChartItem1"
            ' 
            ' mailMergeDataSourceItem1
            ' 
            Me.mailMergeDataSourceItem1.Id = 294
            Me.mailMergeDataSourceItem1.Name = "mailMergeDataSourceItem1"
            ' 
            ' commandBarCheckItem32
            ' 
            Me.commandBarCheckItem32.Id = 295
            Me.commandBarCheckItem32.Name = "commandBarCheckItem32"
            Me.commandBarCheckItem32.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.MailMergeFilters
            ' 
            ' commandBarCheckItem33
            ' 
            Me.commandBarCheckItem33.Id = 296
            Me.commandBarCheckItem33.Name = "commandBarCheckItem33"
            Me.commandBarCheckItem33.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.MailMergeSorting
            ' 
            ' mailMergeCurrentRecordItem1
            ' 
            Me.mailMergeCurrentRecordItem1.Description = resources.GetString("mailMergeCurrentRecordItem1.Description")
            Me.mailMergeCurrentRecordItem1.Edit = Me.repositoryItemMailMergeCurrentRecordEdit1
            Me.mailMergeCurrentRecordItem1.Id = 297
            Me.mailMergeCurrentRecordItem1.Name = "mailMergeCurrentRecordItem1"
            Me.mailMergeCurrentRecordItem1.Width = 90
            ' 
            ' repositoryItemMailMergeCurrentRecordEdit1
            ' 
            Me.repositoryItemMailMergeCurrentRecordEdit1.AutoHeight = False
            Me.repositoryItemMailMergeCurrentRecordEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { _
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleLeft, (DirectCast(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit1.Buttons"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "Previous", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Prev, Nothing, True), _
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleRight, (DirectCast(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit1.Buttons1"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "Next", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Next, Nothing, True), _
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleLeft, (DirectCast(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit1.Buttons2"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject7, "First", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.First, Nothing, True), _
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleRight, (DirectCast(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit1.Buttons3"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject8, "Last", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Last, Nothing, True) _
            })
            Me.repositoryItemMailMergeCurrentRecordEdit1.Name = "repositoryItemMailMergeCurrentRecordEdit1"
            ' 
            ' commandBarSubItem8
            ' 
            Me.commandBarSubItem8.Id = 298
            Me.commandBarSubItem8.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem13), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem14), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem15) _
            })
            Me.commandBarSubItem8.Name = "commandBarSubItem8"
            Me.commandBarSubItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            Me.commandBarSubItem8.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.FinishAndMerge
            ' 
            ' commandBarItem13
            ' 
            Me.commandBarItem13.Id = 299
            Me.commandBarItem13.Name = "commandBarItem13"
            Me.commandBarItem13.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapMailMergeExportDocument
            ' 
            ' commandBarItem14
            ' 
            Me.commandBarItem14.Id = 300
            Me.commandBarItem14.Name = "commandBarItem14"
            Me.commandBarItem14.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapMailMergePrint
            ' 
            ' commandBarItem15
            ' 
            Me.commandBarItem15.Id = 301
            Me.commandBarItem15.Name = "commandBarItem15"
            Me.commandBarItem15.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapMailMergePrintPreview
            ' 
            ' headerFooterToolsRibbonPageCategory1
            ' 
            Me.headerFooterToolsRibbonPageCategory1.Control = Me.snapControl1
            Me.headerFooterToolsRibbonPageCategory1.Name = "headerFooterToolsRibbonPageCategory1"
            Me.headerFooterToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.headerFooterToolsDesignRibbonPage1})
            Me.headerFooterToolsRibbonPageCategory1.Visible = False
            ' 
            ' headerFooterToolsDesignRibbonPage1
            ' 
            Me.headerFooterToolsDesignRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.headerFooterToolsDesignNavigationRibbonPageGroup1, Me.headerFooterToolsDesignOptionsRibbonPageGroup1, Me.headerFooterToolsDesignCloseRibbonPageGroup1})
            Me.headerFooterToolsDesignRibbonPage1.Name = "headerFooterToolsDesignRibbonPage1"
            Me.headerFooterToolsDesignRibbonPage1.Visible = False
            ' 
            ' headerFooterToolsDesignNavigationRibbonPageGroup1
            ' 
            Me.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(Me.goToPageHeaderItem1)
            Me.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(Me.goToPageFooterItem1)
            Me.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(Me.goToNextHeaderFooterItem1)
            Me.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(Me.goToPreviousHeaderFooterItem1)
            Me.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(Me.toggleLinkToPreviousItem1)
            Me.headerFooterToolsDesignNavigationRibbonPageGroup1.Name = "headerFooterToolsDesignNavigationRibbonPageGroup1"
            ' 
            ' headerFooterToolsDesignOptionsRibbonPageGroup1
            ' 
            Me.headerFooterToolsDesignOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleDifferentFirstPageItem1)
            Me.headerFooterToolsDesignOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleDifferentOddAndEvenPagesItem1)
            Me.headerFooterToolsDesignOptionsRibbonPageGroup1.Name = "headerFooterToolsDesignOptionsRibbonPageGroup1"
            ' 
            ' headerFooterToolsDesignCloseRibbonPageGroup1
            ' 
            Me.headerFooterToolsDesignCloseRibbonPageGroup1.ItemLinks.Add(Me.closePageHeaderFooterItem1)
            Me.headerFooterToolsDesignCloseRibbonPageGroup1.Name = "headerFooterToolsDesignCloseRibbonPageGroup1"
            ' 
            ' tableToolsRibbonPageCategory1
            ' 
            Me.tableToolsRibbonPageCategory1.Control = Me.snapControl1
            Me.tableToolsRibbonPageCategory1.Name = "tableToolsRibbonPageCategory1"
            Me.tableToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.tableDesignRibbonPage1, Me.tableLayoutRibbonPage1})
            Me.tableToolsRibbonPageCategory1.Visible = False
            ' 
            ' tableDesignRibbonPage1
            ' 
            Me.tableDesignRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.tableStyleOptionsRibbonPageGroup1, Me.tableStylesRibbonPageGroup1, Me.tableCellStylesRibbonPageGroup1, Me.tableDrawBordersRibbonPageGroup1})
            Me.tableDesignRibbonPage1.Name = "tableDesignRibbonPage1"
            Me.tableDesignRibbonPage1.Visible = False
            ' 
            ' tableStyleOptionsRibbonPageGroup1
            ' 
            Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleFirstRowItem1)
            Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleLastRowItem1)
            Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleBandedRowsItem1)
            Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleFirstColumnItem1)
            Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleLastColumnItem1)
            Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleBandedColumnItem1)
            Me.tableStyleOptionsRibbonPageGroup1.Name = "tableStyleOptionsRibbonPageGroup1"
            ' 
            ' tableStylesRibbonPageGroup1
            ' 
            Me.tableStylesRibbonPageGroup1.ItemLinks.Add(Me.galleryChangeTableStyleItem1)
            Me.tableStylesRibbonPageGroup1.Name = "tableStylesRibbonPageGroup1"
            ' 
            ' tableCellStylesRibbonPageGroup1
            ' 
            Me.tableCellStylesRibbonPageGroup1.ItemLinks.Add(Me.galleryChangeTableCellStyleItem1)
            Me.tableCellStylesRibbonPageGroup1.Name = "tableCellStylesRibbonPageGroup1"
            ' 
            ' tableDrawBordersRibbonPageGroup1
            ' 
            Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBorderLineStyleItem1)
            Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBorderLineWeightItem1)
            Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBorderColorItem1)
            Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBordersItem1)
            Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableCellsShadingItem1)
            Me.tableDrawBordersRibbonPageGroup1.Name = "tableDrawBordersRibbonPageGroup1"
            ' 
            ' tableLayoutRibbonPage1
            ' 
            Me.tableLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.tableTableRibbonPageGroup1, Me.tableRowsAndColumnsRibbonPageGroup1, Me.tableMergeRibbonPageGroup1, Me.tableCellSizeRibbonPageGroup1, Me.tableAlignmentRibbonPageGroup1})
            Me.tableLayoutRibbonPage1.Name = "tableLayoutRibbonPage1"
            Me.tableLayoutRibbonPage1.Visible = False
            ' 
            ' tableTableRibbonPageGroup1
            ' 
            Me.tableTableRibbonPageGroup1.ItemLinks.Add(Me.selectTableElementsItem1)
            Me.tableTableRibbonPageGroup1.ItemLinks.Add(Me.toggleShowTableGridLinesItem1)
            Me.tableTableRibbonPageGroup1.ItemLinks.Add(Me.showTablePropertiesFormItem1)
            Me.tableTableRibbonPageGroup1.Name = "tableTableRibbonPageGroup1"
            ' 
            ' tableRowsAndColumnsRibbonPageGroup1
            ' 
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.deleteTableElementsItem1)
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableRowAboveItem1)
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableRowBelowItem1)
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableColumnToLeftItem1)
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableColumnToRightItem1)
            Me.tableRowsAndColumnsRibbonPageGroup1.Name = "tableRowsAndColumnsRibbonPageGroup1"
            ' 
            ' tableMergeRibbonPageGroup1
            ' 
            Me.tableMergeRibbonPageGroup1.ItemLinks.Add(Me.mergeTableCellsItem1)
            Me.tableMergeRibbonPageGroup1.ItemLinks.Add(Me.showSplitTableCellsForm1)
            Me.tableMergeRibbonPageGroup1.ItemLinks.Add(Me.splitTableItem1)
            Me.tableMergeRibbonPageGroup1.Name = "tableMergeRibbonPageGroup1"
            ' 
            ' tableCellSizeRibbonPageGroup1
            ' 
            Me.tableCellSizeRibbonPageGroup1.ItemLinks.Add(Me.toggleTableAutoFitItem1)
            Me.tableCellSizeRibbonPageGroup1.Name = "tableCellSizeRibbonPageGroup1"
            ' 
            ' tableAlignmentRibbonPageGroup1
            ' 
            Me.tableAlignmentRibbonPageGroup1.Glyph = (DirectCast(resources.GetObject("tableAlignmentRibbonPageGroup1.Glyph"), System.Drawing.Image))
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsTopLeftAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsMiddleLeftAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsBottomLeftAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsTopCenterAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsMiddleCenterAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsBottomCenterAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsTopRightAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsMiddleRightAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsBottomRightAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.showTableOptionsFormItem1)
            Me.tableAlignmentRibbonPageGroup1.Name = "tableAlignmentRibbonPageGroup1"
            ' 
            ' floatingPictureToolsRibbonPageCategory1
            ' 
            Me.floatingPictureToolsRibbonPageCategory1.Control = Me.snapControl1
            Me.floatingPictureToolsRibbonPageCategory1.Name = "floatingPictureToolsRibbonPageCategory1"
            Me.floatingPictureToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.floatingPictureToolsFormatPage1})
            Me.floatingPictureToolsRibbonPageCategory1.Visible = False
            ' 
            ' floatingPictureToolsFormatPage1
            ' 
            Me.floatingPictureToolsFormatPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.floatingPictureToolsShapeStylesPageGroup1, Me.floatingPictureToolsArrangePageGroup1})
            Me.floatingPictureToolsFormatPage1.Name = "floatingPictureToolsFormatPage1"
            Me.floatingPictureToolsFormatPage1.Visible = False
            ' 
            ' floatingPictureToolsShapeStylesPageGroup1
            ' 
            Me.floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(Me.changeFloatingObjectFillColorItem1)
            Me.floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(Me.changeFloatingObjectOutlineColorItem1)
            Me.floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(Me.changeFloatingObjectOutlineWeightItem1)
            Me.floatingPictureToolsShapeStylesPageGroup1.Name = "floatingPictureToolsShapeStylesPageGroup1"
            ' 
            ' floatingPictureToolsArrangePageGroup1
            ' 
            Me.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.changeFloatingObjectTextWrapTypeItem1)
            Me.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.changeFloatingObjectAlignmentItem1)
            Me.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.floatingObjectBringForwardSubItem1)
            Me.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.floatingObjectSendBackwardSubItem1)
            Me.floatingPictureToolsArrangePageGroup1.Name = "floatingPictureToolsArrangePageGroup1"
            ' 
            ' dataToolsRibbonPageCategory1
            ' 
            Me.dataToolsRibbonPageCategory1.Control = Me.snapControl1
            Me.dataToolsRibbonPageCategory1.Name = "dataToolsRibbonPageCategory1"
            Me.dataToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.appearanceRibbonPage1, Me.snMergeFieldToolsRibbonPage1, Me.groupToolsRibbonPage1, Me.listToolsRibbonPage1, Me.mailMergeRibbonPage1})
            ' 
            ' appearanceRibbonPage1
            ' 
            Me.appearanceRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.themesRibbonPageGroup1})
            Me.appearanceRibbonPage1.Name = "appearanceRibbonPage1"
            ' 
            ' themesRibbonPageGroup1
            ' 
            Me.themesRibbonPageGroup1.ItemLinks.Add(Me.themesGalleryBarItem1)
            Me.themesRibbonPageGroup1.Name = "themesRibbonPageGroup1"
            ' 
            ' snMergeFieldToolsRibbonPage1
            ' 
            Me.snMergeFieldToolsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.dataShapingRibbonPageGroup1, Me.snMergeFieldPropertiesRibbonPageGroup1})
            Me.snMergeFieldToolsRibbonPage1.Name = "snMergeFieldToolsRibbonPage1"
            Me.snMergeFieldToolsRibbonPage1.Visible = False
            ' 
            ' dataShapingRibbonPageGroup1
            ' 
            Me.dataShapingRibbonPageGroup1.ItemLinks.Add(Me.commandBarCheckItem2)
            Me.dataShapingRibbonPageGroup1.ItemLinks.Add(Me.commandBarCheckItem3)
            Me.dataShapingRibbonPageGroup1.ItemLinks.Add(Me.commandBarCheckItem4)
            Me.dataShapingRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem1)
            Me.dataShapingRibbonPageGroup1.ItemLinks.Add(Me.filterPopupButtonItem1)
            Me.dataShapingRibbonPageGroup1.Name = "dataShapingRibbonPageGroup1"
            ' 
            ' snMergeFieldPropertiesRibbonPageGroup1
            ' 
            Me.snMergeFieldPropertiesRibbonPageGroup1.ItemLinks.Add(Me.propertiesBarButtonItem1)
            Me.snMergeFieldPropertiesRibbonPageGroup1.Name = "snMergeFieldPropertiesRibbonPageGroup1"
            ' 
            ' groupToolsRibbonPage1
            ' 
            Me.groupToolsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.groupingRibbonPageGroup1})
            Me.groupToolsRibbonPage1.Name = "groupToolsRibbonPage1"
            Me.groupToolsRibbonPage1.Visible = False
            ' 
            ' groupingRibbonPageGroup1
            ' 
            Me.groupingRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem2)
            Me.groupingRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem3)
            Me.groupingRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem8)
            Me.groupingRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem9)
            Me.groupingRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem4)
            Me.groupingRibbonPageGroup1.Name = "groupingRibbonPageGroup1"
            ' 
            ' listToolsRibbonPage1
            ' 
            Me.listToolsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.listHeaderAndFooterRibbonPageGroup1, Me.listCommandsRibbonPageGroup1, Me.listEditorRowLimitRibbonPageGroup1})
            Me.listToolsRibbonPage1.Name = "listToolsRibbonPage1"
            Me.listToolsRibbonPage1.Visible = False
            ' 
            ' listHeaderAndFooterRibbonPageGroup1
            ' 
            Me.listHeaderAndFooterRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem5)
            Me.listHeaderAndFooterRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem6)
            Me.listHeaderAndFooterRibbonPageGroup1.Name = "listHeaderAndFooterRibbonPageGroup1"
            ' 
            ' listCommandsRibbonPageGroup1
            ' 
            Me.listCommandsRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem10)
            Me.listCommandsRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem11)
            Me.listCommandsRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem7)
            Me.listCommandsRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem12)
            Me.listCommandsRibbonPageGroup1.Name = "listCommandsRibbonPageGroup1"
            ' 
            ' listEditorRowLimitRibbonPageGroup1
            ' 
            Me.listEditorRowLimitRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup8)
            Me.listEditorRowLimitRibbonPageGroup1.Name = "listEditorRowLimitRibbonPageGroup1"
            ' 
            ' mailMergeRibbonPage1
            ' 
            Me.mailMergeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.mailMergeRibbonPageGroup2, Me.mailMergeCurrentRecordRibbonPageGroup1, Me.finishAndMergeRibbonPageGroup1})
            Me.mailMergeRibbonPage1.Name = "mailMergeRibbonPage1"
            ' 
            ' mailMergeRibbonPageGroup2
            ' 
            Me.mailMergeRibbonPageGroup2.ItemLinks.Add(Me.mailMergeDataSourceItem1)
            Me.mailMergeRibbonPageGroup2.ItemLinks.Add(Me.commandBarCheckItem32)
            Me.mailMergeRibbonPageGroup2.ItemLinks.Add(Me.commandBarCheckItem33)
            Me.mailMergeRibbonPageGroup2.Name = "mailMergeRibbonPageGroup2"
            ' 
            ' mailMergeCurrentRecordRibbonPageGroup1
            ' 
            Me.mailMergeCurrentRecordRibbonPageGroup1.ItemLinks.Add(Me.mailMergeCurrentRecordItem1)
            Me.mailMergeCurrentRecordRibbonPageGroup1.Name = "mailMergeCurrentRecordRibbonPageGroup1"
            ' 
            ' finishAndMergeRibbonPageGroup1
            ' 
            Me.finishAndMergeRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem8)
            Me.finishAndMergeRibbonPageGroup1.Name = "finishAndMergeRibbonPageGroup1"
            ' 
            ' chartRibbonPageCategory1
            ' 
            Me.chartRibbonPageCategory1.Control = Nothing
            Me.chartRibbonPageCategory1.Name = "chartRibbonPageCategory1"
            Me.chartRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.createChartRibbonPage1})
            Me.chartRibbonPageCategory1.Visible = False
            ' 
            ' createChartRibbonPage1
            ' 
            Me.createChartRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.chartTypeRibbonPageGroup1, Me.chartAppearanceRibbonPageGroup1, Me.chartWizardRibbonPageGroup1})
            Me.createChartRibbonPage1.Name = "createChartRibbonPage1"
            Me.createChartRibbonPage1.Visible = False
            ' 
            ' chartTypeRibbonPageGroup1
            ' 
            Me.chartTypeRibbonPageGroup1.ItemLinks.Add(Me.createBarBaseItem1)
            Me.chartTypeRibbonPageGroup1.ItemLinks.Add(Me.createLineBaseItem1)
            Me.chartTypeRibbonPageGroup1.ItemLinks.Add(Me.createPieBaseItem1)
            Me.chartTypeRibbonPageGroup1.ItemLinks.Add(Me.createRotatedBarBaseItem1)
            Me.chartTypeRibbonPageGroup1.ItemLinks.Add(Me.createAreaBaseItem1)
            Me.chartTypeRibbonPageGroup1.ItemLinks.Add(Me.createOtherSeriesTypesBaseItem1)
            Me.chartTypeRibbonPageGroup1.Name = "chartTypeRibbonPageGroup1"
            ' 
            ' chartAppearanceRibbonPageGroup1
            ' 
            Me.chartAppearanceRibbonPageGroup1.ItemLinks.Add(Me.changePaletteGalleryBaseItem1)
            Me.chartAppearanceRibbonPageGroup1.ItemLinks.Add(Me.changeAppearanceGalleryBaseItem1)
            Me.chartAppearanceRibbonPageGroup1.Name = "chartAppearanceRibbonPageGroup1"
            ' 
            ' chartWizardRibbonPageGroup1
            ' 
            Me.chartWizardRibbonPageGroup1.AllowMinimize = False
            Me.chartWizardRibbonPageGroup1.ItemLinks.Add(Me.runWizardChartItem1)
            Me.chartWizardRibbonPageGroup1.Name = "chartWizardRibbonPageGroup1"
            ' 
            ' fileRibbonPage1
            ' 
            Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.commonRibbonPageGroup1, Me.dataRibbonPageGroup1})
            Me.fileRibbonPage1.Name = "fileRibbonPage1"
            ' 
            ' commonRibbonPageGroup1
            ' 
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileNewItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileOpenItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveAsItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.quickPrintItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printPreviewItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.undoItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.redoItem1)
            Me.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
            ' 
            ' dataRibbonPageGroup1
            ' 
            Me.dataRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem2)
            Me.dataRibbonPageGroup1.Name = "dataRibbonPageGroup1"
            ' 
            ' homeRibbonPage1
            ' 
            Me.homeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.clipboardRibbonPageGroup1, Me.fontRibbonPageGroup1, Me.paragraphRibbonPageGroup1, Me.stylesRibbonPageGroup1, Me.editingRibbonPageGroup1})
            Me.homeRibbonPage1.Name = "homeRibbonPage1"
            reduceOperation2.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.UntilAvailable
            reduceOperation2.Group = Me.stylesRibbonPageGroup1
            reduceOperation2.ItemLinkIndex = 0
            reduceOperation2.ItemLinksCount = 0
            reduceOperation2.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery
            Me.homeRibbonPage1.ReduceOperations.Add(reduceOperation2)
            ' 
            ' clipboardRibbonPageGroup1
            ' 
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.pasteItem1)
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.cutItem1)
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.copyItem1)
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.pasteSpecialItem1)
            Me.clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1"
            ' 
            ' fontRibbonPageGroup1
            ' 
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup2)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup3)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.changeTextCaseItem1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.clearFormattingItem1)
            Me.fontRibbonPageGroup1.Name = "fontRibbonPageGroup1"
            ' 
            ' paragraphRibbonPageGroup1
            ' 
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup4)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup5)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup6)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup7)
            Me.paragraphRibbonPageGroup1.Name = "paragraphRibbonPageGroup1"
            ' 
            ' editingRibbonPageGroup1
            ' 
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.findItem1)
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.replaceItem1)
            Me.editingRibbonPageGroup1.Name = "editingRibbonPageGroup1"
            ' 
            ' insertRibbonPage1
            ' 
            Me.insertRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.pagesRibbonPageGroup1, Me.tablesRibbonPageGroup1, Me.illustrationsRibbonPageGroup1, Me.toolboxRibbonPageGroup1, Me.linksRibbonPageGroup1, Me.headerFooterRibbonPageGroup1, Me.textRibbonPageGroup1, Me.symbolsRibbonPageGroup1})
            Me.insertRibbonPage1.Name = "insertRibbonPage1"
            ' 
            ' pagesRibbonPageGroup1
            ' 
            Me.pagesRibbonPageGroup1.ItemLinks.Add(Me.insertPageBreakItem1)
            Me.pagesRibbonPageGroup1.Name = "pagesRibbonPageGroup1"
            ' 
            ' tablesRibbonPageGroup1
            ' 
            Me.tablesRibbonPageGroup1.ItemLinks.Add(Me.insertTableItem1)
            Me.tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1"
            ' 
            ' illustrationsRibbonPageGroup1
            ' 
            Me.illustrationsRibbonPageGroup1.ItemLinks.Add(Me.insertPictureItem1)
            Me.illustrationsRibbonPageGroup1.ItemLinks.Add(Me.insertFloatingPictureItem1)
            Me.illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1"
            ' 
            ' toolboxRibbonPageGroup1
            ' 
            Me.toolboxRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem3)
            Me.toolboxRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem4)
            Me.toolboxRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem5)
            Me.toolboxRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem6)
            Me.toolboxRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem7)
            Me.toolboxRibbonPageGroup1.Name = "toolboxRibbonPageGroup1"
            ' 
            ' linksRibbonPageGroup1
            ' 
            Me.linksRibbonPageGroup1.ItemLinks.Add(Me.insertBookmarkItem1)
            Me.linksRibbonPageGroup1.ItemLinks.Add(Me.insertHyperlinkItem1)
            Me.linksRibbonPageGroup1.Name = "linksRibbonPageGroup1"
            ' 
            ' headerFooterRibbonPageGroup1
            ' 
            Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.editPageHeaderItem1)
            Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.editPageFooterItem1)
            Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.insertPageNumberItem1)
            Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.insertPageCountItem1)
            Me.headerFooterRibbonPageGroup1.Name = "headerFooterRibbonPageGroup1"
            ' 
            ' textRibbonPageGroup1
            ' 
            Me.textRibbonPageGroup1.Glyph = (DirectCast(resources.GetObject("textRibbonPageGroup1.Glyph"), System.Drawing.Image))
            Me.textRibbonPageGroup1.ItemLinks.Add(Me.insertTextBoxItem1)
            Me.textRibbonPageGroup1.Name = "textRibbonPageGroup1"
            ' 
            ' symbolsRibbonPageGroup1
            ' 
            Me.symbolsRibbonPageGroup1.ItemLinks.Add(Me.insertSymbolItem1)
            Me.symbolsRibbonPageGroup1.Name = "symbolsRibbonPageGroup1"
            ' 
            ' pageLayoutRibbonPage1
            ' 
            Me.pageLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.pageSetupRibbonPageGroup1, Me.pageBackgroundRibbonPageGroup1})
            Me.pageLayoutRibbonPage1.Name = "pageLayoutRibbonPage1"
            ' 
            ' pageSetupRibbonPageGroup1
            ' 
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionPageMarginsItem1)
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionPageOrientationItem1)
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionPaperKindItem1)
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionColumnsItem1)
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.insertBreakItem1)
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionLineNumberingItem1)
            Me.pageSetupRibbonPageGroup1.Name = "pageSetupRibbonPageGroup1"
            ' 
            ' pageBackgroundRibbonPageGroup1
            ' 
            Me.pageBackgroundRibbonPageGroup1.ItemLinks.Add(Me.changePageColorItem1)
            Me.pageBackgroundRibbonPageGroup1.Name = "pageBackgroundRibbonPageGroup1"
            ' 
            ' viewRibbonPage1
            ' 
            Me.viewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.documentViewsRibbonPageGroup1, Me.showRibbonPageGroup1, Me.zoomRibbonPageGroup1, Me.viewRibbonPageGroup1, Me.mailMergeRibbonPageGroup1})
            Me.viewRibbonPage1.Name = "viewRibbonPage1"
            ' 
            ' documentViewsRibbonPageGroup1
            ' 
            Me.documentViewsRibbonPageGroup1.ItemLinks.Add(Me.switchToSimpleViewItem1)
            Me.documentViewsRibbonPageGroup1.ItemLinks.Add(Me.switchToDraftViewItem1)
            Me.documentViewsRibbonPageGroup1.ItemLinks.Add(Me.switchToPrintLayoutViewItem1)
            Me.documentViewsRibbonPageGroup1.Name = "documentViewsRibbonPageGroup1"
            ' 
            ' showRibbonPageGroup1
            ' 
            Me.showRibbonPageGroup1.ItemLinks.Add(Me.toggleShowHorizontalRulerItem1)
            Me.showRibbonPageGroup1.ItemLinks.Add(Me.toggleShowVerticalRulerItem1)
            Me.showRibbonPageGroup1.Name = "showRibbonPageGroup1"
            ' 
            ' zoomRibbonPageGroup1
            ' 
            Me.zoomRibbonPageGroup1.ItemLinks.Add(Me.zoomOutItem1)
            Me.zoomRibbonPageGroup1.ItemLinks.Add(Me.zoomInItem1)
            Me.zoomRibbonPageGroup1.Name = "zoomRibbonPageGroup1"
            ' 
            ' viewRibbonPageGroup1
            ' 
            Me.viewRibbonPageGroup1.ItemLinks.Add(Me.snapBarToolbarsListItem1)
            Me.viewRibbonPageGroup1.ItemLinks.Add(Me.commandBarCheckItem1)
            Me.viewRibbonPageGroup1.Name = "viewRibbonPageGroup1"
            ' 
            ' mailMergeRibbonPageGroup1
            ' 
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldCodesItem1)
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldResultsItem1)
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.toggleFieldHighlightingItem1)
            Me.mailMergeRibbonPageGroup1.Name = "mailMergeRibbonPageGroup1"
            ' 
            ' reviewRibbonPage1
            ' 
            Me.reviewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.documentProofingRibbonPageGroup1})
            Me.reviewRibbonPage1.Name = "reviewRibbonPage1"
            ' 
            ' documentProofingRibbonPageGroup1
            ' 
            Me.documentProofingRibbonPageGroup1.ItemLinks.Add(Me.checkSpellingItem1)
            Me.documentProofingRibbonPageGroup1.Name = "documentProofingRibbonPageGroup1"
            ' 
            ' referencesRibbonPage1
            ' 
            Me.referencesRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.tableOfContentsRibbonPageGroup1, Me.captionsRibbonPageGroup1})
            Me.referencesRibbonPage1.Name = "referencesRibbonPage1"
            ' 
            ' tableOfContentsRibbonPageGroup1
            ' 
            Me.tableOfContentsRibbonPageGroup1.ItemLinks.Add(Me.insertTableOfContentsItem1)
            Me.tableOfContentsRibbonPageGroup1.ItemLinks.Add(Me.updateTableOfContentsItem1)
            Me.tableOfContentsRibbonPageGroup1.ItemLinks.Add(Me.addParagraphsToTableOfContentItem1)
            Me.tableOfContentsRibbonPageGroup1.Name = "tableOfContentsRibbonPageGroup1"
            ' 
            ' captionsRibbonPageGroup1
            ' 
            Me.captionsRibbonPageGroup1.ItemLinks.Add(Me.insertCaptionPlaceholderItem1)
            Me.captionsRibbonPageGroup1.ItemLinks.Add(Me.insertTableOfFiguresPlaceholderItem1)
            Me.captionsRibbonPageGroup1.ItemLinks.Add(Me.updateTableOfFiguresItem1)
            Me.captionsRibbonPageGroup1.Name = "captionsRibbonPageGroup1"
            ' 
            ' snapDockManager1
            ' 
            Me.snapDockManager1.Form = Me
            Me.snapDockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.panelContainer1})
            Me.snapDockManager1.SnapControl = Me.snapControl1
            Me.snapDockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
            ' 
            ' panelContainer1
            ' 
            Me.panelContainer1.Controls.Add(Me.fieldListDockPanel1)
            Me.panelContainer1.Controls.Add(Me.reportExplorerDockPanel1)
            Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.panelContainer1.ID = New System.Guid("5530ee01-82b7-414b-855d-4b549967039e")
            Me.panelContainer1.Location = New System.Drawing.Point(568, 142)
            Me.panelContainer1.Name = "panelContainer1"
            Me.panelContainer1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.panelContainer1.Size = New System.Drawing.Size(200, 435)
            Me.panelContainer1.Text = "panelContainer1"
            ' 
            ' fieldListDockPanel1
            ' 
            Me.fieldListDockPanel1.Controls.Add(Me.fieldListDockPanel1_Container)
            Me.fieldListDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.fieldListDockPanel1.ID = New System.Guid("3e1d6ba2-c033-428b-9fc2-43a588077af5")
            Me.fieldListDockPanel1.Location = New System.Drawing.Point(0, 0)
            Me.fieldListDockPanel1.Name = "fieldListDockPanel1"
            Me.fieldListDockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.fieldListDockPanel1.Size = New System.Drawing.Size(200, 218)
            Me.fieldListDockPanel1.SnapControl = Me.snapControl1
            Me.fieldListDockPanel1.Text = "Data Explorer"
            ' 
            ' fieldListDockPanel1_Container
            ' 
            Me.fieldListDockPanel1_Container.Location = New System.Drawing.Point(4, 23)
            Me.fieldListDockPanel1_Container.Name = "fieldListDockPanel1_Container"
            Me.fieldListDockPanel1_Container.Size = New System.Drawing.Size(192, 191)
            Me.fieldListDockPanel1_Container.TabIndex = 0
            ' 
            ' reportExplorerDockPanel1
            ' 
            Me.reportExplorerDockPanel1.Controls.Add(Me.reportExplorerDockPanel1_Container)
            Me.reportExplorerDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.reportExplorerDockPanel1.ID = New System.Guid("6095b30b-f5b5-4635-9c21-c4083af4dfb3")
            Me.reportExplorerDockPanel1.Location = New System.Drawing.Point(0, 218)
            Me.reportExplorerDockPanel1.Name = "reportExplorerDockPanel1"
            Me.reportExplorerDockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.reportExplorerDockPanel1.Size = New System.Drawing.Size(200, 217)
            Me.reportExplorerDockPanel1.SnapControl = Me.snapControl1
            Me.reportExplorerDockPanel1.Text = "Report Explorer"
            ' 
            ' reportExplorerDockPanel1_Container
            ' 
            Me.reportExplorerDockPanel1_Container.Location = New System.Drawing.Point(4, 23)
            Me.reportExplorerDockPanel1_Container.Name = "reportExplorerDockPanel1_Container"
            Me.reportExplorerDockPanel1_Container.Size = New System.Drawing.Size(192, 190)
            Me.reportExplorerDockPanel1_Container.TabIndex = 0
            ' 
            ' snapDocumentManager1
            ' 
            Me.snapDocumentManager1.ClientControl = Me.snapControl1
            Me.snapDocumentManager1.View = Me.noDocumentsView1
            Me.snapDocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() { Me.noDocumentsView1})
            ' 
            ' snapBarController1
            ' 
            Me.snapBarController1.BarItems.Add(Me.fileNewItem1)
            Me.snapBarController1.BarItems.Add(Me.fileOpenItem1)
            Me.snapBarController1.BarItems.Add(Me.fileSaveItem1)
            Me.snapBarController1.BarItems.Add(Me.fileSaveAsItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem1)
            Me.snapBarController1.BarItems.Add(Me.quickPrintItem1)
            Me.snapBarController1.BarItems.Add(Me.printItem1)
            Me.snapBarController1.BarItems.Add(Me.printPreviewItem1)
            Me.snapBarController1.BarItems.Add(Me.undoItem1)
            Me.snapBarController1.BarItems.Add(Me.redoItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem2)
            Me.snapBarController1.BarItems.Add(Me.pasteItem1)
            Me.snapBarController1.BarItems.Add(Me.cutItem1)
            Me.snapBarController1.BarItems.Add(Me.copyItem1)
            Me.snapBarController1.BarItems.Add(Me.pasteSpecialItem1)
            Me.snapBarController1.BarItems.Add(Me.changeFontNameItem1)
            Me.snapBarController1.BarItems.Add(Me.changeFontSizeItem1)
            Me.snapBarController1.BarItems.Add(Me.fontSizeIncreaseItem1)
            Me.snapBarController1.BarItems.Add(Me.fontSizeDecreaseItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFontBoldItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFontItalicItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFontUnderlineItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFontDoubleUnderlineItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFontStrikeoutItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFontDoubleStrikeoutItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFontSuperscriptItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFontSubscriptItem1)
            Me.snapBarController1.BarItems.Add(Me.changeFontColorItem1)
            Me.snapBarController1.BarItems.Add(Me.changeFontBackColorItem1)
            Me.snapBarController1.BarItems.Add(Me.changeTextCaseItem1)
            Me.snapBarController1.BarItems.Add(Me.makeTextUpperCaseItem1)
            Me.snapBarController1.BarItems.Add(Me.makeTextLowerCaseItem1)
            Me.snapBarController1.BarItems.Add(Me.capitalizeEachWordCaseItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTextCaseItem1)
            Me.snapBarController1.BarItems.Add(Me.clearFormattingItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleBulletedListItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleNumberingListItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleMultiLevelListItem1)
            Me.snapBarController1.BarItems.Add(Me.decreaseIndentItem1)
            Me.snapBarController1.BarItems.Add(Me.increaseIndentItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleParagraphAlignmentLeftItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleParagraphAlignmentCenterItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleParagraphAlignmentRightItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleParagraphAlignmentJustifyItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleShowWhitespaceItem1)
            Me.snapBarController1.BarItems.Add(Me.changeParagraphLineSpacingItem1)
            Me.snapBarController1.BarItems.Add(Me.setSingleParagraphSpacingItem1)
            Me.snapBarController1.BarItems.Add(Me.setSesquialteralParagraphSpacingItem1)
            Me.snapBarController1.BarItems.Add(Me.setDoubleParagraphSpacingItem1)
            Me.snapBarController1.BarItems.Add(Me.showLineSpacingFormItem1)
            Me.snapBarController1.BarItems.Add(Me.addSpacingBeforeParagraphItem1)
            Me.snapBarController1.BarItems.Add(Me.removeSpacingBeforeParagraphItem1)
            Me.snapBarController1.BarItems.Add(Me.addSpacingAfterParagraphItem1)
            Me.snapBarController1.BarItems.Add(Me.removeSpacingAfterParagraphItem1)
            Me.snapBarController1.BarItems.Add(Me.changeParagraphBackColorItem1)
            Me.snapBarController1.BarItems.Add(Me.galleryChangeStyleItem1)
            Me.snapBarController1.BarItems.Add(Me.findItem1)
            Me.snapBarController1.BarItems.Add(Me.replaceItem1)
            Me.snapBarController1.BarItems.Add(Me.insertPageBreakItem1)
            Me.snapBarController1.BarItems.Add(Me.insertTableItem1)
            Me.snapBarController1.BarItems.Add(Me.insertPictureItem1)
            Me.snapBarController1.BarItems.Add(Me.insertFloatingPictureItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem3)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem4)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem5)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem6)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem7)
            Me.snapBarController1.BarItems.Add(Me.insertBookmarkItem1)
            Me.snapBarController1.BarItems.Add(Me.insertHyperlinkItem1)
            Me.snapBarController1.BarItems.Add(Me.editPageHeaderItem1)
            Me.snapBarController1.BarItems.Add(Me.editPageFooterItem1)
            Me.snapBarController1.BarItems.Add(Me.insertPageNumberItem1)
            Me.snapBarController1.BarItems.Add(Me.insertPageCountItem1)
            Me.snapBarController1.BarItems.Add(Me.insertTextBoxItem1)
            Me.snapBarController1.BarItems.Add(Me.insertSymbolItem1)
            Me.snapBarController1.BarItems.Add(Me.changeSectionPageMarginsItem1)
            Me.snapBarController1.BarItems.Add(Me.setNormalSectionPageMarginsItem1)
            Me.snapBarController1.BarItems.Add(Me.setNarrowSectionPageMarginsItem1)
            Me.snapBarController1.BarItems.Add(Me.setModerateSectionPageMarginsItem1)
            Me.snapBarController1.BarItems.Add(Me.setWideSectionPageMarginsItem1)
            Me.snapBarController1.BarItems.Add(Me.showPageMarginsSetupFormItem1)
            Me.snapBarController1.BarItems.Add(Me.changeSectionPageOrientationItem1)
            Me.snapBarController1.BarItems.Add(Me.setPortraitPageOrientationItem1)
            Me.snapBarController1.BarItems.Add(Me.setLandscapePageOrientationItem1)
            Me.snapBarController1.BarItems.Add(Me.changeSectionPaperKindItem1)
            Me.snapBarController1.BarItems.Add(Me.changeSectionColumnsItem1)
            Me.snapBarController1.BarItems.Add(Me.setSectionOneColumnItem1)
            Me.snapBarController1.BarItems.Add(Me.setSectionTwoColumnsItem1)
            Me.snapBarController1.BarItems.Add(Me.setSectionThreeColumnsItem1)
            Me.snapBarController1.BarItems.Add(Me.showColumnsSetupFormItem1)
            Me.snapBarController1.BarItems.Add(Me.insertBreakItem1)
            Me.snapBarController1.BarItems.Add(Me.insertPageBreakItem2)
            Me.snapBarController1.BarItems.Add(Me.insertColumnBreakItem1)
            Me.snapBarController1.BarItems.Add(Me.insertSectionBreakNextPageItem1)
            Me.snapBarController1.BarItems.Add(Me.insertSectionBreakEvenPageItem1)
            Me.snapBarController1.BarItems.Add(Me.insertSectionBreakOddPageItem1)
            Me.snapBarController1.BarItems.Add(Me.changeSectionLineNumberingItem1)
            Me.snapBarController1.BarItems.Add(Me.setSectionLineNumberingNoneItem1)
            Me.snapBarController1.BarItems.Add(Me.setSectionLineNumberingContinuousItem1)
            Me.snapBarController1.BarItems.Add(Me.setSectionLineNumberingRestartNewPageItem1)
            Me.snapBarController1.BarItems.Add(Me.setSectionLineNumberingRestartNewSectionItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleParagraphSuppressLineNumbersItem1)
            Me.snapBarController1.BarItems.Add(Me.showLineNumberingFormItem1)
            Me.snapBarController1.BarItems.Add(Me.changePageColorItem1)
            Me.snapBarController1.BarItems.Add(Me.switchToSimpleViewItem1)
            Me.snapBarController1.BarItems.Add(Me.switchToDraftViewItem1)
            Me.snapBarController1.BarItems.Add(Me.switchToPrintLayoutViewItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleShowHorizontalRulerItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleShowVerticalRulerItem1)
            Me.snapBarController1.BarItems.Add(Me.zoomOutItem1)
            Me.snapBarController1.BarItems.Add(Me.zoomInItem1)
            Me.snapBarController1.BarItems.Add(Me.snapBarToolbarsListItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem1)
            Me.snapBarController1.BarItems.Add(Me.showAllFieldCodesItem1)
            Me.snapBarController1.BarItems.Add(Me.showAllFieldResultsItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFieldHighlightingItem1)
            Me.snapBarController1.BarItems.Add(Me.goToPageHeaderItem1)
            Me.snapBarController1.BarItems.Add(Me.goToPageFooterItem1)
            Me.snapBarController1.BarItems.Add(Me.goToNextHeaderFooterItem1)
            Me.snapBarController1.BarItems.Add(Me.goToPreviousHeaderFooterItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleLinkToPreviousItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleDifferentFirstPageItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleDifferentOddAndEvenPagesItem1)
            Me.snapBarController1.BarItems.Add(Me.closePageHeaderFooterItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFirstRowItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleLastRowItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleBandedRowsItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFirstColumnItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleLastColumnItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleBandedColumnItem1)
            Me.snapBarController1.BarItems.Add(Me.galleryChangeTableStyleItem1)
            Me.snapBarController1.BarItems.Add(Me.galleryChangeTableCellStyleItem1)
            Me.snapBarController1.BarItems.Add(Me.changeTableBorderLineStyleItem1)
            Me.snapBarController1.BarItems.Add(Me.changeTableBorderLineWeightItem1)
            Me.snapBarController1.BarItems.Add(Me.changeTableBorderColorItem1)
            Me.snapBarController1.BarItems.Add(Me.changeTableBordersItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsBottomBorderItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsTopBorderItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsLeftBorderItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsRightBorderItem1)
            Me.snapBarController1.BarItems.Add(Me.resetTableCellsAllBordersItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsAllBordersItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsOutsideBorderItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsInsideBorderItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsInsideHorizontalBorderItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsInsideVerticalBorderItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleShowTableGridLinesItem1)
            Me.snapBarController1.BarItems.Add(Me.changeTableCellsShadingItem1)
            Me.snapBarController1.BarItems.Add(Me.selectTableElementsItem1)
            Me.snapBarController1.BarItems.Add(Me.selectTableCellItem1)
            Me.snapBarController1.BarItems.Add(Me.selectTableColumnItem1)
            Me.snapBarController1.BarItems.Add(Me.selectTableRowItem1)
            Me.snapBarController1.BarItems.Add(Me.selectTableItem1)
            Me.snapBarController1.BarItems.Add(Me.showTablePropertiesFormItem1)
            Me.snapBarController1.BarItems.Add(Me.deleteTableElementsItem1)
            Me.snapBarController1.BarItems.Add(Me.showDeleteTableCellsFormItem1)
            Me.snapBarController1.BarItems.Add(Me.deleteTableColumnsItem1)
            Me.snapBarController1.BarItems.Add(Me.deleteTableRowsItem1)
            Me.snapBarController1.BarItems.Add(Me.deleteTableItem1)
            Me.snapBarController1.BarItems.Add(Me.insertTableRowAboveItem1)
            Me.snapBarController1.BarItems.Add(Me.insertTableRowBelowItem1)
            Me.snapBarController1.BarItems.Add(Me.insertTableColumnToLeftItem1)
            Me.snapBarController1.BarItems.Add(Me.insertTableColumnToRightItem1)
            Me.snapBarController1.BarItems.Add(Me.mergeTableCellsItem1)
            Me.snapBarController1.BarItems.Add(Me.showSplitTableCellsForm1)
            Me.snapBarController1.BarItems.Add(Me.splitTableItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableAutoFitItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableAutoFitContentsItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableAutoFitWindowItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableFixedColumnWidthItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsTopLeftAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsMiddleLeftAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsBottomLeftAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsTopCenterAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsMiddleCenterAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsBottomCenterAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsTopRightAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsMiddleRightAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsBottomRightAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.showTableOptionsFormItem1)
            Me.snapBarController1.BarItems.Add(Me.checkSpellingItem1)
            Me.snapBarController1.BarItems.Add(Me.insertTableOfContentsItem1)
            Me.snapBarController1.BarItems.Add(Me.updateTableOfContentsItem1)
            Me.snapBarController1.BarItems.Add(Me.addParagraphsToTableOfContentItem1)
            Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem1)
            Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem2)
            Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem3)
            Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem4)
            Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem5)
            Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem6)
            Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem7)
            Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem8)
            Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem9)
            Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem10)
            Me.snapBarController1.BarItems.Add(Me.insertCaptionPlaceholderItem1)
            Me.snapBarController1.BarItems.Add(Me.insertFiguresCaptionItems1)
            Me.snapBarController1.BarItems.Add(Me.insertTablesCaptionItems1)
            Me.snapBarController1.BarItems.Add(Me.insertEquationsCaptionItems1)
            Me.snapBarController1.BarItems.Add(Me.insertTableOfFiguresPlaceholderItem1)
            Me.snapBarController1.BarItems.Add(Me.insertTableOfFiguresItems1)
            Me.snapBarController1.BarItems.Add(Me.insertTableOfTablesItems1)
            Me.snapBarController1.BarItems.Add(Me.insertTableOfEquationsItems1)
            Me.snapBarController1.BarItems.Add(Me.updateTableOfFiguresItem1)
            Me.snapBarController1.BarItems.Add(Me.changeFloatingObjectFillColorItem1)
            Me.snapBarController1.BarItems.Add(Me.changeFloatingObjectOutlineColorItem1)
            Me.snapBarController1.BarItems.Add(Me.changeFloatingObjectOutlineWeightItem1)
            Me.snapBarController1.BarItems.Add(Me.changeFloatingObjectTextWrapTypeItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectSquareTextWrapTypeItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectTightTextWrapTypeItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectThroughTextWrapTypeItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectTopAndBottomTextWrapTypeItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectBehindTextWrapTypeItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectInFrontOfTextWrapTypeItem1)
            Me.snapBarController1.BarItems.Add(Me.changeFloatingObjectAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectTopLeftAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectTopCenterAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectTopRightAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectMiddleLeftAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectMiddleCenterAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectMiddleRightAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectBottomLeftAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectBottomCenterAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectBottomRightAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.floatingObjectBringForwardSubItem1)
            Me.snapBarController1.BarItems.Add(Me.floatingObjectBringForwardItem1)
            Me.snapBarController1.BarItems.Add(Me.floatingObjectBringToFrontItem1)
            Me.snapBarController1.BarItems.Add(Me.floatingObjectBringInFrontOfTextItem1)
            Me.snapBarController1.BarItems.Add(Me.floatingObjectSendBackwardSubItem1)
            Me.snapBarController1.BarItems.Add(Me.floatingObjectSendBackwardItem1)
            Me.snapBarController1.BarItems.Add(Me.floatingObjectSendToBackItem1)
            Me.snapBarController1.BarItems.Add(Me.floatingObjectSendBehindTextItem1)
            Me.snapBarController1.BarItems.Add(Me.themesGalleryBarItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem2)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem3)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem4)
            Me.snapBarController1.BarItems.Add(Me.commandBarSubItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem5)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem6)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem7)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem8)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem9)
            Me.snapBarController1.BarItems.Add(Me.filterPopupButtonItem1)
            Me.snapBarController1.BarItems.Add(Me.propertiesBarButtonItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarSubItem2)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem10)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem11)
            Me.snapBarController1.BarItems.Add(Me.commandBarSubItem3)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem12)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem13)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem8)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem9)
            Me.snapBarController1.BarItems.Add(Me.commandBarSubItem4)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem14)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem15)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem16)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem17)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem18)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem19)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem20)
            Me.snapBarController1.BarItems.Add(Me.commandBarSubItem5)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem21)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem22)
            Me.snapBarController1.BarItems.Add(Me.commandBarSubItem6)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem23)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem24)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem10)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem11)
            Me.snapBarController1.BarItems.Add(Me.commandBarSubItem7)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem25)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem26)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem27)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem28)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem29)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem30)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem31)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem12)
            Me.snapBarController1.BarItems.Add(Me.changeEditorRowLimitItem1)
            Me.snapBarController1.BarItems.Add(Me.createBarBaseItem1)
            Me.snapBarController1.BarItems.Add(Me.createLineBaseItem1)
            Me.snapBarController1.BarItems.Add(Me.createPieBaseItem1)
            Me.snapBarController1.BarItems.Add(Me.createRotatedBarBaseItem1)
            Me.snapBarController1.BarItems.Add(Me.createAreaBaseItem1)
            Me.snapBarController1.BarItems.Add(Me.createOtherSeriesTypesBaseItem1)
            Me.snapBarController1.BarItems.Add(Me.changePaletteGalleryBaseItem1)
            Me.snapBarController1.BarItems.Add(Me.changeAppearanceGalleryBaseItem1)
            Me.snapBarController1.BarItems.Add(Me.runWizardChartItem1)
            Me.snapBarController1.BarItems.Add(Me.mailMergeDataSourceItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem32)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem33)
            Me.snapBarController1.BarItems.Add(Me.mailMergeCurrentRecordItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarSubItem8)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem13)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem14)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem15)
            Me.snapBarController1.ContextPageCategories.Add(New DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(Me.headerFooterToolsRibbonPageCategory1))
            Me.snapBarController1.ContextPageCategories.Add(New DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(Me.tableToolsRibbonPageCategory1))
            Me.snapBarController1.ContextPageCategories.Add(New DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(Me.floatingPictureToolsRibbonPageCategory1))
            Me.snapBarController1.ContextPageCategories.Add(New DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(Me.dataToolsRibbonPageCategory1))
            Me.snapBarController1.ContextPageCategories.Add(New DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(Me.chartRibbonPageCategory1))
            Me.snapBarController1.Control = Me.snapControl1
            Me.snapBarController1.RibbonControl = Me.ribbonControl1
            Me.snapBarController1.SnapDockManager = Me.snapDockManager1
            ' 
            ' insertPageBreakItem2
            ' 
            Me.insertPageBreakItem2.Id = -1
            Me.insertPageBreakItem2.Name = "insertPageBreakItem2"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(768, 577)
            Me.Controls.Add(Me.snapControl1)
            Me.Controls.Add(Me.panelContainer1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemFloatingObjectOutlineWeight1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemEditorRowLimitEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.commandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.commandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.commandBarGalleryDropDown3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.commandBarGalleryDropDown4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.commandBarGalleryDropDown5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.commandBarGalleryDropDown6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.commandBarGalleryDropDown7, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemMailMergeCurrentRecordEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.snapDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelContainer1.ResumeLayout(False)
            Me.fieldListDockPanel1.ResumeLayout(False)
            Me.reportExplorerDockPanel1.ResumeLayout(False)
            DirectCast(Me.snapDocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.noDocumentsView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.snapBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents snapControl1 As DevExpress.Snap.SnapControl
        Private snapDockManager1 As DevExpress.Snap.Extensions.SnapDockManager
        Private panelContainer1 As DevExpress.XtraBars.Docking.DockPanel
        Private fieldListDockPanel1 As DevExpress.Snap.Extensions.UI.FieldListDockPanel
        Private fieldListDockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private reportExplorerDockPanel1 As DevExpress.Snap.Extensions.UI.ReportExplorerDockPanel
        Private reportExplorerDockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private snapDocumentManager1 As DevExpress.Snap.Extensions.SnapDocumentManager
        Private noDocumentsView1 As DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private fileNewItem1 As DevExpress.XtraRichEdit.UI.FileNewItem
        Private fileOpenItem1 As DevExpress.XtraRichEdit.UI.FileOpenItem
        Private fileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem
        Private fileSaveAsItem1 As DevExpress.XtraRichEdit.UI.FileSaveAsItem
        Private commandBarItem1 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private quickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem
        Private printItem1 As DevExpress.XtraRichEdit.UI.PrintItem
        Private printPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem
        Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
        Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
        Private commandBarItem2 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private pasteItem1 As DevExpress.XtraRichEdit.UI.PasteItem
        Private cutItem1 As DevExpress.XtraRichEdit.UI.CutItem
        Private copyItem1 As DevExpress.XtraRichEdit.UI.CopyItem
        Private pasteSpecialItem1 As DevExpress.XtraRichEdit.UI.PasteSpecialItem
        Private barButtonGroup1 As DevExpress.XtraBars.BarButtonGroup
        Private changeFontNameItem1 As DevExpress.XtraRichEdit.UI.ChangeFontNameItem
        Private repositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
        Private changeFontSizeItem1 As DevExpress.XtraRichEdit.UI.ChangeFontSizeItem
        Private repositoryItemRichEditFontSizeEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit
        Private fontSizeIncreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem
        Private fontSizeDecreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem
        Private barButtonGroup2 As DevExpress.XtraBars.BarButtonGroup
        Private toggleFontBoldItem1 As DevExpress.XtraRichEdit.UI.ToggleFontBoldItem
        Private toggleFontItalicItem1 As DevExpress.XtraRichEdit.UI.ToggleFontItalicItem
        Private toggleFontUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem
        Private toggleFontDoubleUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem
        Private toggleFontStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem
        Private toggleFontDoubleStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem
        Private toggleFontSuperscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem
        Private toggleFontSubscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem
        Private barButtonGroup3 As DevExpress.XtraBars.BarButtonGroup
        Private changeFontColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontColorItem
        Private changeFontBackColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem
        Private changeTextCaseItem1 As DevExpress.XtraRichEdit.UI.ChangeTextCaseItem
        Private makeTextUpperCaseItem1 As DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem
        Private makeTextLowerCaseItem1 As DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem
        Private capitalizeEachWordCaseItem1 As DevExpress.XtraRichEdit.UI.CapitalizeEachWordCaseItem
        Private toggleTextCaseItem1 As DevExpress.XtraRichEdit.UI.ToggleTextCaseItem
        Private clearFormattingItem1 As DevExpress.XtraRichEdit.UI.ClearFormattingItem
        Private barButtonGroup4 As DevExpress.XtraBars.BarButtonGroup
        Private toggleBulletedListItem1 As DevExpress.XtraRichEdit.UI.ToggleBulletedListItem
        Private toggleNumberingListItem1 As DevExpress.XtraRichEdit.UI.ToggleNumberingListItem
        Private toggleMultiLevelListItem1 As DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem
        Private barButtonGroup5 As DevExpress.XtraBars.BarButtonGroup
        Private decreaseIndentItem1 As DevExpress.XtraRichEdit.UI.DecreaseIndentItem
        Private increaseIndentItem1 As DevExpress.XtraRichEdit.UI.IncreaseIndentItem
        Private toggleShowWhitespaceItem1 As DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem
        Private barButtonGroup6 As DevExpress.XtraBars.BarButtonGroup
        Private toggleParagraphAlignmentLeftItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem
        Private toggleParagraphAlignmentCenterItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem
        Private toggleParagraphAlignmentRightItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem
        Private toggleParagraphAlignmentJustifyItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem
        Private barButtonGroup7 As DevExpress.XtraBars.BarButtonGroup
        Private changeParagraphLineSpacingItem1 As DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem
        Private setSingleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem
        Private setSesquialteralParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem
        Private setDoubleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem
        Private showLineSpacingFormItem1 As DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem
        Private addSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem
        Private removeSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem
        Private addSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem
        Private removeSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem
        Private changeParagraphBackColorItem1 As DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem
        Private galleryChangeStyleItem1 As DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem
        Private findItem1 As DevExpress.XtraRichEdit.UI.FindItem
        Private replaceItem1 As DevExpress.XtraRichEdit.UI.ReplaceItem
        Private insertPageBreakItem1 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem
        Private insertTableItem1 As DevExpress.XtraRichEdit.UI.InsertTableItem
        Private insertPictureItem1 As DevExpress.XtraRichEdit.UI.InsertPictureItem
        Private insertFloatingPictureItem1 As DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem
        Private commandBarItem3 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private commandBarItem4 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private commandBarItem5 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private commandBarItem6 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private commandBarItem7 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private insertBookmarkItem1 As DevExpress.XtraRichEdit.UI.InsertBookmarkItem
        Private insertHyperlinkItem1 As DevExpress.XtraRichEdit.UI.InsertHyperlinkItem
        Private editPageHeaderItem1 As DevExpress.XtraRichEdit.UI.EditPageHeaderItem
        Private editPageFooterItem1 As DevExpress.XtraRichEdit.UI.EditPageFooterItem
        Private insertPageNumberItem1 As DevExpress.XtraRichEdit.UI.InsertPageNumberItem
        Private insertPageCountItem1 As DevExpress.XtraRichEdit.UI.InsertPageCountItem
        Private insertTextBoxItem1 As DevExpress.XtraRichEdit.UI.InsertTextBoxItem
        Private insertSymbolItem1 As DevExpress.XtraRichEdit.UI.InsertSymbolItem
        Private changeSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem
        Private setNormalSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem
        Private setNarrowSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem
        Private setModerateSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem
        Private setWideSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem
        Private showPageMarginsSetupFormItem1 As DevExpress.XtraRichEdit.UI.ShowPageMarginsSetupFormItem
        Private changeSectionPageOrientationItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem
        Private setPortraitPageOrientationItem1 As DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem
        Private setLandscapePageOrientationItem1 As DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem
        Private changeSectionPaperKindItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem
        Private changeSectionColumnsItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem
        Private setSectionOneColumnItem1 As DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem
        Private setSectionTwoColumnsItem1 As DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem
        Private setSectionThreeColumnsItem1 As DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem
        Private showColumnsSetupFormItem1 As DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem
        Private insertBreakItem1 As DevExpress.XtraRichEdit.UI.InsertBreakItem
        Private insertColumnBreakItem1 As DevExpress.XtraRichEdit.UI.InsertColumnBreakItem
        Private insertSectionBreakNextPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem
        Private insertSectionBreakEvenPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem
        Private insertSectionBreakOddPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem
        Private changeSectionLineNumberingItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem
        Private setSectionLineNumberingNoneItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem
        Private setSectionLineNumberingContinuousItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem
        Private setSectionLineNumberingRestartNewPageItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem
        Private setSectionLineNumberingRestartNewSectionItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem
        Private toggleParagraphSuppressLineNumbersItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem
        Private showLineNumberingFormItem1 As DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem
        Private changePageColorItem1 As DevExpress.XtraRichEdit.UI.ChangePageColorItem
        Private switchToSimpleViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem
        Private switchToDraftViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem
        Private switchToPrintLayoutViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem
        Private toggleShowHorizontalRulerItem1 As DevExpress.XtraRichEdit.UI.ToggleShowHorizontalRulerItem
        Private toggleShowVerticalRulerItem1 As DevExpress.XtraRichEdit.UI.ToggleShowVerticalRulerItem
        Private zoomOutItem1 As DevExpress.XtraRichEdit.UI.ZoomOutItem
        Private zoomInItem1 As DevExpress.XtraRichEdit.UI.ZoomInItem
        Private snapBarToolbarsListItem1 As DevExpress.Snap.Extensions.UI.SnapBarToolbarsListItem
        Private commandBarCheckItem1 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private showAllFieldCodesItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem
        Private showAllFieldResultsItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem
        Private toggleFieldHighlightingItem1 As DevExpress.Snap.Extensions.UI.ToggleFieldHighlightingItem
        Private goToPageHeaderItem1 As DevExpress.XtraRichEdit.UI.GoToPageHeaderItem
        Private goToPageFooterItem1 As DevExpress.XtraRichEdit.UI.GoToPageFooterItem
        Private goToNextHeaderFooterItem1 As DevExpress.XtraRichEdit.UI.GoToNextHeaderFooterItem
        Private goToPreviousHeaderFooterItem1 As DevExpress.XtraRichEdit.UI.GoToPreviousHeaderFooterItem
        Private toggleLinkToPreviousItem1 As DevExpress.XtraRichEdit.UI.ToggleLinkToPreviousItem
        Private toggleDifferentFirstPageItem1 As DevExpress.XtraRichEdit.UI.ToggleDifferentFirstPageItem
        Private toggleDifferentOddAndEvenPagesItem1 As DevExpress.XtraRichEdit.UI.ToggleDifferentOddAndEvenPagesItem
        Private closePageHeaderFooterItem1 As DevExpress.XtraRichEdit.UI.ClosePageHeaderFooterItem
        Private toggleFirstRowItem1 As DevExpress.XtraRichEdit.UI.ToggleFirstRowItem
        Private toggleLastRowItem1 As DevExpress.XtraRichEdit.UI.ToggleLastRowItem
        Private toggleBandedRowsItem1 As DevExpress.XtraRichEdit.UI.ToggleBandedRowsItem
        Private toggleFirstColumnItem1 As DevExpress.XtraRichEdit.UI.ToggleFirstColumnItem
        Private toggleLastColumnItem1 As DevExpress.XtraRichEdit.UI.ToggleLastColumnItem
        Private toggleBandedColumnItem1 As DevExpress.XtraRichEdit.UI.ToggleBandedColumnsItem
        Private galleryChangeTableStyleItem1 As DevExpress.XtraRichEdit.UI.GalleryChangeTableStyleItem
        Private galleryChangeTableCellStyleItem1 As DevExpress.Snap.Extensions.UI.GalleryChangeTableCellStyleItem
        Private changeTableBorderLineStyleItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem
        Private repositoryItemBorderLineStyle1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle
        Private changeTableBorderLineWeightItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem
        Private repositoryItemBorderLineWeight1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight
        Private changeTableBorderColorItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem
        Private changeTableBordersItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBordersItem
        Private toggleTableCellsBottomBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem
        Private toggleTableCellsTopBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem
        Private toggleTableCellsLeftBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem
        Private toggleTableCellsRightBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem
        Private resetTableCellsAllBordersItem1 As DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem
        Private toggleTableCellsAllBordersItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem
        Private toggleTableCellsOutsideBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem
        Private toggleTableCellsInsideBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem
        Private toggleTableCellsInsideHorizontalBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem
        Private toggleTableCellsInsideVerticalBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem
        Private toggleShowTableGridLinesItem1 As DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem
        Private changeTableCellsShadingItem1 As DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem
        Private selectTableElementsItem1 As DevExpress.XtraRichEdit.UI.SelectTableElementsItem
        Private selectTableCellItem1 As DevExpress.XtraRichEdit.UI.SelectTableCellItem
        Private selectTableColumnItem1 As DevExpress.XtraRichEdit.UI.SelectTableColumnItem
        Private selectTableRowItem1 As DevExpress.XtraRichEdit.UI.SelectTableRowItem
        Private selectTableItem1 As DevExpress.XtraRichEdit.UI.SelectTableItem
        Private showTablePropertiesFormItem1 As DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem
        Private deleteTableElementsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableElementsItem
        Private showDeleteTableCellsFormItem1 As DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem
        Private deleteTableColumnsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem
        Private deleteTableRowsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableRowsItem
        Private deleteTableItem1 As DevExpress.XtraRichEdit.UI.DeleteTableItem
        Private insertTableRowAboveItem1 As DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem
        Private insertTableRowBelowItem1 As DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem
        Private insertTableColumnToLeftItem1 As DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem
        Private insertTableColumnToRightItem1 As DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem
        Private mergeTableCellsItem1 As DevExpress.XtraRichEdit.UI.MergeTableCellsItem
        Private showSplitTableCellsForm1 As DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm
        Private splitTableItem1 As DevExpress.XtraRichEdit.UI.SplitTableItem
        Private toggleTableAutoFitItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem
        Private toggleTableAutoFitContentsItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem
        Private toggleTableAutoFitWindowItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem
        Private toggleTableFixedColumnWidthItem1 As DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem
        Private toggleTableCellsTopLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem
        Private toggleTableCellsMiddleLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem
        Private toggleTableCellsBottomLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem
        Private toggleTableCellsTopCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem
        Private toggleTableCellsMiddleCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem
        Private toggleTableCellsBottomCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem
        Private toggleTableCellsTopRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem
        Private toggleTableCellsMiddleRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem
        Private toggleTableCellsBottomRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem
        Private showTableOptionsFormItem1 As DevExpress.XtraRichEdit.UI.ShowTableOptionsFormItem
        Private checkSpellingItem1 As DevExpress.XtraRichEdit.UI.CheckSpellingItem
        Private insertTableOfContentsItem1 As DevExpress.XtraRichEdit.UI.InsertTableOfContentsItem
        Private updateTableOfContentsItem1 As DevExpress.XtraRichEdit.UI.UpdateTableOfContentsItem
        Private addParagraphsToTableOfContentItem1 As DevExpress.XtraRichEdit.UI.AddParagraphsToTableOfContentItem
        Private setParagraphHeadingLevelItem1 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem2 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem3 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem4 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem5 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem6 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem7 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem8 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem9 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem10 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private insertCaptionPlaceholderItem1 As DevExpress.XtraRichEdit.UI.InsertCaptionPlaceholderItem
        Private insertFiguresCaptionItems1 As DevExpress.XtraRichEdit.UI.InsertFiguresCaptionItems
        Private insertTablesCaptionItems1 As DevExpress.XtraRichEdit.UI.InsertTablesCaptionItems
        Private insertEquationsCaptionItems1 As DevExpress.XtraRichEdit.UI.InsertEquationsCaptionItems
        Private insertTableOfFiguresPlaceholderItem1 As DevExpress.XtraRichEdit.UI.InsertTableOfFiguresPlaceholderItem
        Private insertTableOfFiguresItems1 As DevExpress.XtraRichEdit.UI.InsertTableOfFiguresItems
        Private insertTableOfTablesItems1 As DevExpress.XtraRichEdit.UI.InsertTableOfTablesItems
        Private insertTableOfEquationsItems1 As DevExpress.XtraRichEdit.UI.InsertTableOfEquationsItems
        Private updateTableOfFiguresItem1 As DevExpress.XtraRichEdit.UI.UpdateTableOfFiguresItem
        Private changeFloatingObjectFillColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectFillColorItem
        Private changeFloatingObjectOutlineColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineColorItem
        Private changeFloatingObjectOutlineWeightItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineWeightItem
        Private repositoryItemFloatingObjectOutlineWeight1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight
        Private changeFloatingObjectTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectTextWrapTypeItem
        Private setFloatingObjectSquareTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectSquareTextWrapTypeItem
        Private setFloatingObjectTightTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTightTextWrapTypeItem
        Private setFloatingObjectThroughTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectThroughTextWrapTypeItem
        Private setFloatingObjectTopAndBottomTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTopAndBottomTextWrapTypeItem
        Private setFloatingObjectBehindTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectBehindTextWrapTypeItem
        Private setFloatingObjectInFrontOfTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectInFrontOfTextWrapTypeItem
        Private changeFloatingObjectAlignmentItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectAlignmentItem
        Private setFloatingObjectTopLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTopLeftAlignmentItem
        Private setFloatingObjectTopCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTopCenterAlignmentItem
        Private setFloatingObjectTopRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTopRightAlignmentItem
        Private setFloatingObjectMiddleLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleLeftAlignmentItem
        Private setFloatingObjectMiddleCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleCenterAlignmentItem
        Private setFloatingObjectMiddleRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleRightAlignmentItem
        Private setFloatingObjectBottomLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomLeftAlignmentItem
        Private setFloatingObjectBottomCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomCenterAlignmentItem
        Private setFloatingObjectBottomRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomRightAlignmentItem
        Private floatingObjectBringForwardSubItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardSubItem
        Private floatingObjectBringForwardItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardItem
        Private floatingObjectBringToFrontItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectBringToFrontItem
        Private floatingObjectBringInFrontOfTextItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectBringInFrontOfTextItem
        Private floatingObjectSendBackwardSubItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardSubItem
        Private floatingObjectSendBackwardItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardItem
        Private floatingObjectSendToBackItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectSendToBackItem
        Private floatingObjectSendBehindTextItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectSendBehindTextItem
        Private themesGalleryBarItem1 As DevExpress.Snap.Extensions.UI.ThemesGalleryBarItem
        Private commandBarCheckItem2 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem3 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem4 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarSubItem1 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
        Private commandBarCheckItem5 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem6 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem7 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem8 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem9 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private filterPopupButtonItem1 As DevExpress.Snap.Extensions.UI.FilterPopupButtonItem
        Private propertiesBarButtonItem1 As DevExpress.Snap.Extensions.UI.PropertiesBarButtonItem
        Private commandBarSubItem2 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
        Private commandBarCheckItem10 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem11 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarSubItem3 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
        Private commandBarCheckItem12 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem13 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarItem8 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private commandBarItem9 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private commandBarSubItem4 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
        Private commandBarCheckItem14 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem15 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem16 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem17 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem18 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem19 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem20 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarSubItem5 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
        Private commandBarCheckItem21 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem22 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarSubItem6 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
        Private commandBarCheckItem23 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem24 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarItem10 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private commandBarItem11 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private commandBarSubItem7 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
        Private commandBarCheckItem25 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem26 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem27 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem28 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem29 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem30 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem31 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarItem12 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private barButtonGroup8 As DevExpress.XtraBars.BarButtonGroup
        Private changeEditorRowLimitItem1 As DevExpress.Snap.Extensions.UI.ChangeEditorRowLimitItem
        Private repositoryItemEditorRowLimitEdit1 As DevExpress.Snap.Design.RepositoryItemEditorRowLimitEdit
        Private createBarBaseItem1 As DevExpress.XtraCharts.UI.CreateBarBaseItem
        Private commandBarGalleryDropDown1 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
        Private createLineBaseItem1 As DevExpress.XtraCharts.UI.CreateLineBaseItem
        Private commandBarGalleryDropDown2 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
        Private createPieBaseItem1 As DevExpress.XtraCharts.UI.CreatePieBaseItem
        Private commandBarGalleryDropDown3 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
        Private createRotatedBarBaseItem1 As DevExpress.XtraCharts.UI.CreateRotatedBarBaseItem
        Private commandBarGalleryDropDown4 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
        Private createAreaBaseItem1 As DevExpress.XtraCharts.UI.CreateAreaBaseItem
        Private commandBarGalleryDropDown5 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
        Private createOtherSeriesTypesBaseItem1 As DevExpress.XtraCharts.UI.CreateOtherSeriesTypesBaseItem
        Private commandBarGalleryDropDown6 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
        Private changePaletteGalleryBaseItem1 As DevExpress.XtraCharts.UI.ChangePaletteGalleryBaseItem
        Private commandBarGalleryDropDown7 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
        Private changeAppearanceGalleryBaseItem1 As DevExpress.XtraCharts.UI.ChangeAppearanceGalleryBaseItem
        Private runWizardChartItem1 As DevExpress.XtraCharts.UI.RunWizardChartItem
        Private mailMergeDataSourceItem1 As DevExpress.Snap.Extensions.UI.MailMergeDataSourceItem
        Private commandBarCheckItem32 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem33 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private mailMergeCurrentRecordItem1 As DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordItem
        Private repositoryItemMailMergeCurrentRecordEdit1 As DevExpress.Snap.Extensions.UI.RepositoryItemMailMergeCurrentRecordEdit
        Private commandBarSubItem8 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
        Private commandBarItem13 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private commandBarItem14 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private commandBarItem15 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private headerFooterToolsRibbonPageCategory1 As DevExpress.XtraRichEdit.UI.HeaderFooterToolsRibbonPageCategory
        Private headerFooterToolsDesignRibbonPage1 As DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignRibbonPage
        Private headerFooterToolsDesignNavigationRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignNavigationRibbonPageGroup
        Private headerFooterToolsDesignOptionsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignOptionsRibbonPageGroup
        Private headerFooterToolsDesignCloseRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignCloseRibbonPageGroup
        Private tableToolsRibbonPageCategory1 As DevExpress.XtraRichEdit.UI.TableToolsRibbonPageCategory
        Private tableDesignRibbonPage1 As DevExpress.XtraRichEdit.UI.TableDesignRibbonPage
        Private tableStyleOptionsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableStyleOptionsRibbonPageGroup
        Private tableStylesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableStylesRibbonPageGroup
        Private tableCellStylesRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.TableCellStylesRibbonPageGroup
        Private tableDrawBordersRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableDrawBordersRibbonPageGroup
        Private tableLayoutRibbonPage1 As DevExpress.XtraRichEdit.UI.TableLayoutRibbonPage
        Private tableTableRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableTableRibbonPageGroup
        Private tableRowsAndColumnsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableRowsAndColumnsRibbonPageGroup
        Private tableMergeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableMergeRibbonPageGroup
        Private tableCellSizeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableCellSizeRibbonPageGroup
        Private tableAlignmentRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableAlignmentRibbonPageGroup
        Private floatingPictureToolsRibbonPageCategory1 As DevExpress.XtraRichEdit.UI.FloatingPictureToolsRibbonPageCategory
        Private floatingPictureToolsFormatPage1 As DevExpress.XtraRichEdit.UI.FloatingPictureToolsFormatPage
        Private floatingPictureToolsShapeStylesPageGroup1 As DevExpress.XtraRichEdit.UI.FloatingPictureToolsShapeStylesPageGroup
        Private floatingPictureToolsArrangePageGroup1 As DevExpress.XtraRichEdit.UI.FloatingPictureToolsArrangePageGroup
        Private dataToolsRibbonPageCategory1 As DevExpress.Snap.Extensions.UI.DataToolsRibbonPageCategory
        Private appearanceRibbonPage1 As DevExpress.Snap.Extensions.UI.AppearanceRibbonPage
        Private themesRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ThemesRibbonPageGroup
        Private snMergeFieldToolsRibbonPage1 As DevExpress.Snap.Extensions.UI.SNMergeFieldToolsRibbonPage
        Private dataShapingRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.DataShapingRibbonPageGroup
        Private snMergeFieldPropertiesRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.SNMergeFieldPropertiesRibbonPageGroup
        Private groupToolsRibbonPage1 As DevExpress.Snap.Extensions.UI.GroupToolsRibbonPage
        Private groupingRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.GroupingRibbonPageGroup
        Private listToolsRibbonPage1 As DevExpress.Snap.Extensions.UI.ListToolsRibbonPage
        Private listHeaderAndFooterRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ListHeaderAndFooterRibbonPageGroup
        Private listCommandsRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ListCommandsRibbonPageGroup
        Private listEditorRowLimitRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ListEditorRowLimitRibbonPageGroup
        Private mailMergeRibbonPage1 As DevExpress.Snap.Extensions.UI.MailMergeRibbonPage
        Private mailMergeRibbonPageGroup2 As DevExpress.Snap.Extensions.UI.MailMergeRibbonPageGroup
        Private mailMergeCurrentRecordRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordRibbonPageGroup
        Private finishAndMergeRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.FinishAndMergeRibbonPageGroup
        Private chartRibbonPageCategory1 As DevExpress.XtraCharts.UI.ChartRibbonPageCategory
        Private createChartRibbonPage1 As DevExpress.XtraCharts.UI.CreateChartRibbonPage
        Private chartTypeRibbonPageGroup1 As DevExpress.XtraCharts.UI.ChartTypeRibbonPageGroup
        Private chartAppearanceRibbonPageGroup1 As DevExpress.XtraCharts.UI.ChartAppearanceRibbonPageGroup
        Private chartWizardRibbonPageGroup1 As DevExpress.XtraCharts.UI.ChartWizardRibbonPageGroup
        Private fileRibbonPage1 As DevExpress.XtraRichEdit.UI.FileRibbonPage
        Private commonRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup
        Private dataRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.DataRibbonPageGroup
        Private homeRibbonPage1 As DevExpress.XtraRichEdit.UI.HomeRibbonPage
        Private clipboardRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup
        Private fontRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.FontRibbonPageGroup
        Private paragraphRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup
        Private stylesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup
        Private editingRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup
        Private insertRibbonPage1 As DevExpress.XtraRichEdit.UI.InsertRibbonPage
        Private pagesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup
        Private tablesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup
        Private illustrationsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup
        Private toolboxRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ToolboxRibbonPageGroup
        Private linksRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup
        Private headerFooterRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup
        Private textRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TextRibbonPageGroup
        Private symbolsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup
        Private pageLayoutRibbonPage1 As DevExpress.XtraRichEdit.UI.PageLayoutRibbonPage
        Private pageSetupRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PageSetupRibbonPageGroup
        Private pageBackgroundRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PageBackgroundRibbonPageGroup
        Private viewRibbonPage1 As DevExpress.XtraRichEdit.UI.ViewRibbonPage
        Private documentViewsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.DocumentViewsRibbonPageGroup
        Private showRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ShowRibbonPageGroup
        Private zoomRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ZoomRibbonPageGroup
        Private viewRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ViewRibbonPageGroup
        Private mailMergeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup
        Private reviewRibbonPage1 As DevExpress.XtraRichEdit.UI.ReviewRibbonPage
        Private documentProofingRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.DocumentProofingRibbonPageGroup
        Private referencesRibbonPage1 As DevExpress.XtraRichEdit.UI.ReferencesRibbonPage
        Private tableOfContentsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableOfContentsRibbonPageGroup
        Private captionsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.CaptionsRibbonPageGroup
        Private snapBarController1 As DevExpress.Snap.Extensions.SnapBarController
        Private insertPageBreakItem2 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem
    End Class
End Namespace

