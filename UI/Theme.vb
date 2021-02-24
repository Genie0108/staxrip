﻿Imports System.ComponentModel
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports Microsoft.VisualBasic

Public Class Theme
    Private Shared _baseHue As Integer = 210
    Private Shared _highlightHue As Integer = 0
    Private Shared _defaultBackHighlightColor As ColorHSL = New ColorHSL(_highlightHue, 0.75, 0.75, 1)

    Public ReadOnly Property Name As String

    Private _generalThemeColors As GeneralThemeColors
    Private _appsFormThemeColors As AppsFormThemeColors
    Private _codeEditorThemeColors As CodeEditorThemeColors
    Private _cropFormThemeColors As CropFormThemeColors
    Private _mainFormThemeColors As MainFormThemeColors

    Public Property General As GeneralThemeColors
        Get
            _generalThemeColors = If(_generalThemeColors, New GeneralThemeColors())
            Return _generalThemeColors
        End Get
        Set(value As GeneralThemeColors)
            _generalThemeColors = value
        End Set
    End Property

    Public Property AppsForm As AppsFormThemeColors
        Get
            _appsFormThemeColors = If(_appsFormThemeColors, New AppsFormThemeColors())
            Return _appsFormThemeColors
        End Get
        Set(value As AppsFormThemeColors)
            _appsFormThemeColors = value
        End Set
    End Property

    Public Property CodeEditor As CodeEditorThemeColors
        Get
            _codeEditorThemeColors = If(_codeEditorThemeColors, New CodeEditorThemeColors())
            Return _codeEditorThemeColors
        End Get
        Set(value As CodeEditorThemeColors)
            _codeEditorThemeColors = value
        End Set
    End Property

    Public Property CropForm As CropFormThemeColors
        Get
            _cropFormThemeColors = If(_cropFormThemeColors, New CropFormThemeColors())
            Return _cropFormThemeColors
        End Get
        Set(value As CropFormThemeColors)
            _cropFormThemeColors = value
        End Set
    End Property

    Public Property MainForm As MainFormThemeColors
        Get
            _mainFormThemeColors = If(_mainFormThemeColors, New MainFormThemeColors())
            Return _mainFormThemeColors
        End Get
        Set(value As MainFormThemeColors)
            _mainFormThemeColors = value
        End Set
    End Property




    Private Sub New()
        Throw New Exception("Please use Theme(name As String) instead to specify a theme name!")
    End Sub

    Public Sub New(name As String)
        If String.IsNullOrWhiteSpace(name) Then
            Throw New ArgumentNullException(NameOf(name))
        End If
        Me.Name = name
    End Sub




    <Serializable>
    Public Class ControlsThemeColors
        Private _buttonThemeColors As ButtonThemeColors
        Private _buttonLabelThemeColors As ButtonLabelThemeColors
        Private _checkBoxThemeColors As CheckBoxThemeColors
        Private _comboboxThemeColors As ComboBoxThemeColors
        Private _criteriaControlThemeColors As CriteriaControlThemeColors
        Private _flowLayoutPanelThemeColors As FlowLayoutPanelThemeColors
        Private _flowPageThemeColors As FlowPageThemeColors
        Private _gridViewThemeColors As GridviewThemeColors
        Private _groupBoxThemeColors As GroupBoxThemeColors
        Private _labelThemeColors As LabelThemeColors
        Private _labelProgressBarThemeColors As LabelProgressBarThemeColors
        Private _listBoxThemeColors As ListBoxThemeColors
        Private _listViewThemeColors As ListViewThemeColors
        Private _numEditThemeColors As NumEditThemeColors
        Private _panelThemeColors As PanelThemeColors
        Private _propertyGridThemeColors As PropertyGridThemeColors
        Private _richTextBoxThemeColors As RichTextBoxThemeColors
        Private _tableLayoutPanelThemeColors As TableLayoutPanelThemeColors
        Private _tabControlThemeColors As TabControlThemeColors
        Private _tabPageThemeColors As TabPageThemeColors
        Private _textBoxThemeColors As TextBoxThemeColors
        Private _textEditThemeColors As TextEditThemeColors
        Private _toolStripThemeColors As ToolStripThemeColors
        Private _toolStripButtonThemeColors As ToolStripButtonThemeColors
        Private _trackBarThemeColors As TrackBarThemeColors
        Private _treeViewThemeColors As TreeViewThemeColors
        Private _videoRendererThemeColors As VideoRendererThemeColors

        Public Property Button As ButtonThemeColors
            Get
                _buttonThemeColors = If(_buttonThemeColors, New ButtonThemeColors())
                Return _buttonThemeColors
            End Get
            Set(value As ButtonThemeColors)
                _buttonThemeColors = value
            End Set
        End Property

        Public Property ButtonLabel As ButtonLabelThemeColors
            Get
                _buttonLabelThemeColors = If(_buttonLabelThemeColors, New ButtonLabelThemeColors())
                Return _buttonLabelThemeColors
            End Get
            Set(value As ButtonLabelThemeColors)
                _buttonLabelThemeColors = value
            End Set
        End Property

        Public Property CheckBox As CheckBoxThemeColors
            Get
                _checkBoxThemeColors = If(_checkBoxThemeColors, New CheckBoxThemeColors())
                Return _checkBoxThemeColors
            End Get
            Set(value As CheckBoxThemeColors)
                _checkBoxThemeColors = value
            End Set
        End Property

        Public Property ComboBox As ComboBoxThemeColors
            Get
                _comboboxThemeColors = If(_comboboxThemeColors, New ComboBoxThemeColors())
                Return _comboboxThemeColors
            End Get
            Set(value As ComboBoxThemeColors)
                _comboboxThemeColors = value
            End Set
        End Property

        Public Property CriteriaControl As CriteriaControlThemeColors
            Get
                _criteriaControlThemeColors = If(_criteriaControlThemeColors, New CriteriaControlThemeColors())
                Return _criteriaControlThemeColors
            End Get
            Set(value As CriteriaControlThemeColors)
                _criteriaControlThemeColors = value
            End Set
        End Property

        Public Property FlowLayoutPanel As FlowLayoutPanelThemeColors
            Get
                _flowLayoutPanelThemeColors = If(_flowLayoutPanelThemeColors, New FlowLayoutPanelThemeColors())
                Return _flowLayoutPanelThemeColors
            End Get
            Set(value As FlowLayoutPanelThemeColors)
                _flowLayoutPanelThemeColors = value
            End Set
        End Property

        Public Property FlowPage As FlowPageThemeColors
            Get
                _flowPageThemeColors = If(_flowPageThemeColors, New FlowPageThemeColors())
                Return _flowPageThemeColors
            End Get
            Set(value As FlowPageThemeColors)
                _flowPageThemeColors = value
            End Set
        End Property

        Public Property GridView As GridviewThemeColors
            Get
                _gridViewThemeColors = If(_gridViewThemeColors, New GridviewThemeColors())
                Return _gridViewThemeColors
            End Get
            Set(value As GridviewThemeColors)
                _gridViewThemeColors = value
            End Set
        End Property

        Public Property GroupBox As GroupBoxThemeColors
            Get
                _groupBoxThemeColors = If(_groupBoxThemeColors, New GroupBoxThemeColors())
                Return _groupBoxThemeColors
            End Get
            Set(value As GroupBoxThemeColors)
                _groupBoxThemeColors = value
            End Set
        End Property

        Public Property Label As LabelThemeColors
            Get
                _labelThemeColors = If(_labelThemeColors, New LabelThemeColors())
                Return _labelThemeColors
            End Get
            Set(value As LabelThemeColors)
                _labelThemeColors = value
            End Set
        End Property

        Public Property LabelProgressBar As LabelProgressBarThemeColors
            Get
                _labelProgressBarThemeColors = If(_labelProgressBarThemeColors, New LabelProgressBarThemeColors())
                Return _labelProgressBarThemeColors
            End Get
            Set(value As LabelProgressBarThemeColors)
                _labelProgressBarThemeColors = value
            End Set
        End Property

        Public Property ListBox As ListBoxThemeColors
            Get
                _listBoxThemeColors = If(_listBoxThemeColors, New ListBoxThemeColors())
                Return _listBoxThemeColors
            End Get
            Set(value As ListBoxThemeColors)
                _listBoxThemeColors = value
            End Set
        End Property

        Public Property ListView As ListViewThemeColors
            Get
                _listViewThemeColors = If(_listViewThemeColors, New ListViewThemeColors())
                Return _listViewThemeColors
            End Get
            Set(value As ListViewThemeColors)
                _listViewThemeColors = value
            End Set
        End Property

        Public Property NumEdit As NumEditThemeColors
            Get
                _numEditThemeColors = If(_numEditThemeColors, New NumEditThemeColors())
                Return _numEditThemeColors
            End Get
            Set(value As NumEditThemeColors)
                _numEditThemeColors = value
            End Set
        End Property

        Public Property Panel As PanelThemeColors
            Get
                _panelThemeColors = If(_panelThemeColors, New PanelThemeColors())
                Return _panelThemeColors
            End Get
            Set(value As PanelThemeColors)
                _panelThemeColors = value
            End Set
        End Property

        Public Property PropertyGrid As PropertyGridThemeColors
            Get
                _propertyGridThemeColors = If(_propertyGridThemeColors, New PropertyGridThemeColors())
                Return _propertyGridThemeColors
            End Get
            Set(value As PropertyGridThemeColors)
                _propertyGridThemeColors = value
            End Set
        End Property


        Public Property RichTextBox As RichTextBoxThemeColors
            Get
                _richTextBoxThemeColors = If(_richTextBoxThemeColors, New RichTextBoxThemeColors())
                Return _richTextBoxThemeColors
            End Get
            Set(value As RichTextBoxThemeColors)
                _richTextBoxThemeColors = value
            End Set
        End Property

        Public Property TableLayoutPanel As TableLayoutPanelThemeColors
            Get
                _tableLayoutPanelThemeColors = If(_tableLayoutPanelThemeColors, New TableLayoutPanelThemeColors())
                Return _tableLayoutPanelThemeColors
            End Get
            Set(value As TableLayoutPanelThemeColors)
                _tableLayoutPanelThemeColors = value
            End Set
        End Property

        Public Property TabControl As TabControlThemeColors
            Get
                _tabControlThemeColors = If(_tabControlThemeColors, New TabControlThemeColors())
                Return _tabControlThemeColors
            End Get
            Set(value As TabControlThemeColors)
                _tabControlThemeColors = value
            End Set
        End Property

        Public Property TabPage As TabPageThemeColors
            Get
                _tabPageThemeColors = If(_tabPageThemeColors, New TabPageThemeColors())
                Return _tabPageThemeColors
            End Get
            Set(value As TabPageThemeColors)
                _tabPageThemeColors = value
            End Set
        End Property

        Public Property TextBox As TextBoxThemeColors
            Get
                _textBoxThemeColors = If(_textBoxThemeColors, New TextBoxThemeColors())
                Return _textBoxThemeColors
            End Get
            Set(value As TextBoxThemeColors)
                _textBoxThemeColors = value
            End Set
        End Property

        Public Property TextEdit As TextEditThemeColors
            Get
                _textEditThemeColors = If(_textEditThemeColors, New TextEditThemeColors())
                Return _textEditThemeColors
            End Get
            Set(value As TextEditThemeColors)
                _textEditThemeColors = value
            End Set
        End Property

        Public Property ToolStrip As ToolStripThemeColors
            Get
                _toolStripThemeColors = If(_toolStripThemeColors, New ToolStripThemeColors())
                Return _toolStripThemeColors
            End Get
            Set(value As ToolStripThemeColors)
                _toolStripThemeColors = value
            End Set
        End Property

        Public Property ToolStripButton As ToolStripButtonThemeColors
            Get
                _toolStripButtonThemeColors = If(_toolStripButtonThemeColors, New ToolStripButtonThemeColors())
                Return _toolStripButtonThemeColors
            End Get
            Set(value As ToolStripButtonThemeColors)
                _toolStripButtonThemeColors = value
            End Set
        End Property

        Public Property TrackBar As TrackBarThemeColors
            Get
                _trackBarThemeColors = If(_trackBarThemeColors, New TrackBarThemeColors())
                Return _trackBarThemeColors
            End Get
            Set(value As TrackBarThemeColors)
                _trackBarThemeColors = value
            End Set
        End Property

        Public Property TreeView As TreeViewThemeColors
            Get
                _treeViewThemeColors = If(_treeViewThemeColors, New TreeViewThemeColors())
                Return _treeViewThemeColors
            End Get
            Set(value As TreeViewThemeColors)
                _treeViewThemeColors = value
            End Set
        End Property

        Public Property VideoRenderer As VideoRendererThemeColors
            Get
                _videoRendererThemeColors = If(_videoRendererThemeColors, New VideoRendererThemeColors())
                Return _videoRendererThemeColors
            End Get
            Set(value As VideoRendererThemeColors)
                _videoRendererThemeColors = value
            End Set
        End Property


        Public Function Clone() As ControlsThemeColors
            Using stream As Stream = New MemoryStream()
                Dim formatter As IFormatter = New BinaryFormatter()
                formatter.Serialize(stream, Me)
                stream.Seek(0, SeekOrigin.Begin)
                Return CType(formatter.Deserialize(stream), ControlsThemeColors)
            End Using
        End Function


        <Serializable>
        Public Class ButtonThemeColors
            Public Property BackColor As ColorHSL = SystemColors.ScrollBar
            Public Property BackDisabledColor As ColorHSL = BackColor
            Public Property BackHighlightColor As ColorHSL = SystemColors.ControlLight
            Public Property BorderColor As ColorHSL = SystemColors.ActiveBorder
            Public Property ForeColor As ColorHSL = SystemColors.ControlText
            Public Property ForeDisabledColor As ColorHSL = ForeColor
            Public Property ForeHighlightColor As ColorHSL = ForeColor
        End Class

        <Serializable>
        Public Class ButtonLabelThemeColors
            Public Property BackColor As ColorHSL = SystemColors.Control
            Public Property BackHighlightColor As ColorHSL = _defaultBackHighlightColor
            Public Property ForeColor As ColorHSL = New ColorHSL(_baseHue, 0.75, 0.5, 1)
            Public Property ForeHighlightColor As ColorHSL = New ColorHSL(_highlightHue, 0.75, 0.5, 1)
            Public Property LinkForeColor As ColorHSL = ForeColor
            Public Property LinkForeHoverColor As ColorHSL = LinkForeColor.AddSaturation(0.5).AddLuminance(0.2)
            Public Property LinkForeHighlightHoverColor As ColorHSL = ForeHighlightColor.AddSaturation(0.5).AddLuminance(0.2)
        End Class

        <Serializable>
        Public Class CheckBoxThemeColors
            Public Property BackColor As ColorHSL = SystemColors.Control
            Public Property BackHighlightColor As ColorHSL = _defaultBackHighlightColor
            Public Property BackHoverColor As ColorHSL = BackColor
            Public Property BorderColor As ColorHSL = SystemColors.ActiveBorder
            Public Property CheckedBackColor As ColorHSL = SystemColors.Control
            Public Property ForeColor As ColorHSL = SystemColors.ControlText
            Public Property ForeHighlightColor As ColorHSL = ForeColor
        End Class

        <Serializable>
        Public Class ComboBoxThemeColors
            Public Property BackColor As ColorHSL = SystemColors.Control
            Public Property BackHighlightColor As ColorHSL = _defaultBackHighlightColor
            Public Property BorderColor As ColorHSL = SystemColors.ActiveBorder
            Public Property ForeColor As ColorHSL = SystemColors.ControlText
            Public Property ForeHighlightColor As ColorHSL = ForeColor
        End Class

        <Serializable>
        Public Class CriteriaControlThemeColors
            Public Property BackColor As ColorHSL = SystemColors.Window
            Public Property ForeColor As ColorHSL = SystemColors.WindowText
        End Class

        <Serializable>
        Public Class FlowLayoutPanelThemeColors
            Public Property BackColor As ColorHSL = SystemColors.Control
            Public Property BackHighlightColor As ColorHSL = BackColor.AddLuminance(-0.25)
            Public Property ForeColor As ColorHSL = SystemColors.ControlText
            Public Property ForeHighlightColor As ColorHSL = ForeColor
        End Class

        <Serializable>
        Public Class FlowPageThemeColors
            Public Property BackColor As ColorHSL = SystemColors.Control
            Public Property BackHighlightColor As ColorHSL = BackColor.AddLuminance(-0.25)
            Public Property ForeColor As ColorHSL = SystemColors.ControlText
            Public Property ForeHighlightColor As ColorHSL = ForeColor
        End Class

        <Serializable>
        Public Class GridviewThemeColors
            Public Property BackColor As ColorHSL = SystemColors.Control
            Public Property BackHighlightColor As ColorHSL = BackColor.AddLuminance(-0.25)
            Public Property ForeColor As ColorHSL = SystemColors.ControlText
            Public Property ForeHighlightColor As ColorHSL = ForeColor
            Public Property GridColor As ColorHSL = SystemColors.Control
        End Class

        <Serializable>
        Public Class GroupBoxThemeColors
            Public Property BackColor As ColorHSL = SystemColors.Control
            Public Property BackHighlightColor As ColorHSL = BackColor.AddLuminance(-0.25)
            Public Property ForeColor As ColorHSL = SystemColors.ControlText
            Public Property ForeHighlightColor As ColorHSL = ForeColor
        End Class

        <Serializable>
        Public Class LabelThemeColors
            Public Property BackColor As ColorHSL = SystemColors.Control
            Public Property BackHighlightColor As ColorHSL = _defaultBackHighlightColor
            Public Property ForeColor As ColorHSL = SystemColors.ControlText
            Public Property ForeHighlightColor As ColorHSL = ForeColor
        End Class

        <Serializable>
        Public Class LabelProgressBarThemeColors
            Public Property BackColor As ColorHSL = SystemColors.Control
            Public Property ForeColor As ColorHSL = SystemColors.ControlText
            Public Property ProgressColor As ColorHSL = New ColorHSL(_baseHue, 0.5, 0.75, 1)
        End Class

        <Serializable>
        Public Class ListBoxThemeColors
            Public Property BackColor As ColorHSL = SystemColors.Window
            Public Property BackAlternateColor As ColorHSL = BackColor.AddLuminance(-0.05)
            Public Property BackHighlightColor As ColorHSL = _defaultBackHighlightColor
            Public Property BackSelectedColor As ColorHSL = SystemColors.ControlDarkDark
            Public Property ForeColor As ColorHSL = SystemColors.WindowText
            Public Property ForeHighlightColor As ColorHSL = ForeColor
            Public Property ForeSelectedColor As ColorHSL = SystemColors.Window
            Public Property SymbolImageColor As ColorHSL = ForeColor
        End Class

        <Serializable>
        Public Class ListViewThemeColors
            Public Property BackColor As ColorHSL = SystemColors.Window
            Public Property BackAlternateColor As ColorHSL = BackColor.AddLuminance(-0.05)
            Public Property BackHighlightColor As ColorHSL = _defaultBackHighlightColor
            Public Property BackSelectedColor As ColorHSL = SystemColors.ControlDarkDark
            Public Property ForeColor As ColorHSL = SystemColors.WindowText
            Public Property ForeHighlightColor As ColorHSL = ForeColor
            Public Property ForeSelectedColor As ColorHSL = SystemColors.Window
            Public Property SymbolImageColor As ColorHSL = ForeColor
        End Class

        <Serializable>
        Public Class NumEditThemeColors
            Private _upDownButton As UpDownButtonThemeColors

            Public Property BackColor As ColorHSL = SystemColors.Window
            Public Property BorderColor As ColorHSL = BackColor
            Public Property BorderSelectedColor As ColorHSL = SystemColors.ControlText


            Public Property UpDownButton As UpDownButtonThemeColors
                Get
                    _upDownButton = If(_upDownButton, New UpDownButtonThemeColors())
                    Return _upDownButton
                End Get
                Set
                    _upDownButton = Value
                End Set
            End Property

            <Serializable>
            Public Class UpDownButtonThemeColors
                Public Property BackColor As ColorHSL = SystemColors.Control
                Public Property BackHotColor As ColorHSL = SystemColors.Control
                Public Property BackPressedColor As ColorHSL = SystemColors.Control
                Public Property BorderColor As ColorHSL = BackColor
                Public Property ForeColor As ColorHSL = SystemColors.ControlText
                Public Property ForeDisabledColor As ColorHSL = SystemColors.GrayText
            End Class
        End Class

        <Serializable>
        Public Class PanelThemeColors
            Public Property BackColor As ColorHSL = SystemColors.Control
            Public Property BackHighlightColor As ColorHSL = _defaultBackHighlightColor
            Public Property ForeColor As ColorHSL = SystemColors.ControlText
            Public Property ForeHighlightColor As ColorHSL = ForeColor
        End Class

        <Serializable>
        Public Class PropertyGridThemeColors
            Public Property BackColor As ColorHSL = SystemColors.Control
            Public Property CategoryForeColor As ColorHSL = SystemColors.ControlText
            Public Property CategorySplitterColor As ColorHSL = SystemColors.ControlText
            Public Property CommandsActiveLinkColor As ColorHSL = SystemColors.ControlText
            Public Property CommandsBackColor As ColorHSL = SystemColors.ControlText
            Public Property CommandsBorderColor As ColorHSL = SystemColors.ControlText
            Public Property CommandsDisabledLinkColor As ColorHSL = SystemColors.ControlText
            Public Property CommandsForeColor As ColorHSL = SystemColors.ControlText
            Public Property CommandsLinkColor As ColorHSL = SystemColors.ControlText
            Public Property DisabledItemForeColor As ColorHSL = SystemColors.ControlText
            Public Property ForeColor As ColorHSL = SystemColors.ControlText
            Public Property HelpBackColor As ColorHSL = SystemColors.Control
            Public Property HelpBorderColor As ColorHSL = SystemColors.ControlDark
            Public Property HelpForeColor As ColorHSL = SystemColors.ControlText
            Public Property LineColor As ColorHSL = SystemColors.ControlDark
            Public Property SelectedItemWithFocusBackColor As ColorHSL = SystemColors.Control
            Public Property SelectedItemWithFocusForeColor As ColorHSL = SystemColors.ControlText
            Public Property ViewBackColor As ColorHSL = SystemColors.Control
            Public Property ViewBorderColor As ColorHSL = SystemColors.ControlText
            Public Property ViewForeColor As ColorHSL = SystemColors.ControlText
        End Class

        <Serializable>
        Public Class RichTextBoxThemeColors
            Public Property BackColor As ColorHSL = SystemColors.Window
            Public Property BackHighlightColor As ColorHSL = _defaultBackHighlightColor
            Public Property BackReadonlyColor As ColorHSL = SystemColors.Control
            Public Property BorderColor As ColorHSL = New ColorHSL(_baseHue, 0.0, 0.3, 1)
            Public Property BorderFocusedColor As ColorHSL = New ColorHSL(_baseHue, 0.0, 0.5, 1)
            Public Property ForeColor As ColorHSL = SystemColors.ControlText
            Public Property ForeHighlightColor As ColorHSL = ForeColor
        End Class

        <Serializable>
        Public Class TableLayoutPanelThemeColors
            Public Property BackColor As ColorHSL = SystemColors.Control
            Public Property BackHighlightColor As ColorHSL = _defaultBackHighlightColor
            Public Property ForeColor As ColorHSL = SystemColors.ControlText
            Public Property ForeHighlightColor As ColorHSL = ForeColor
        End Class

        <Serializable>
        Public Class TabControlThemeColors
            Public Property BackColor As ColorHSL = SystemColors.Control
            Public Property BackHighlightColor As ColorHSL = _defaultBackHighlightColor
            Public Property ForeColor As ColorHSL = SystemColors.ControlText
            Public Property ForeHighlightColor As ColorHSL = ForeColor
        End Class

        <Serializable>
        Public Class TabPageThemeColors
            Public Property BackColor As ColorHSL = SystemColors.Control
            Public Property BackHighlightColor As ColorHSL = _defaultBackHighlightColor
            Public Property ForeColor As ColorHSL = SystemColors.ControlText
            Public Property ForeHighlightColor As ColorHSL = ForeColor
        End Class

        <Serializable>
        Public Class TextBoxThemeColors
            Public Property BackColor As ColorHSL = SystemColors.Window
            Public Property BackHighlightColor As ColorHSL = _defaultBackHighlightColor
            Public Property BackReadonlyColor As ColorHSL = SystemColors.Control
            Public Property BorderColor As ColorHSL = New ColorHSL(_baseHue, 0.0, 0.3, 1)
            Public Property BorderFocusedColor As ColorHSL = New ColorHSL(_baseHue, 0.0, 0.5, 1)
            Public Property ForeColor As ColorHSL = SystemColors.ControlText
            Public Property ForeHighlightColor As ColorHSL = ForeColor
        End Class

        <Serializable>
        Public Class TextEditThemeColors
            Public Property BackColor As ColorHSL = SystemColors.Window
            Public Property BackHighlightColor As ColorHSL = _defaultBackHighlightColor
            Public Property BackReadonlyColor As ColorHSL = SystemColors.Control
            Public Property BorderColor As ColorHSL = New ColorHSL(_baseHue, 0.0, 0.3, 1)
            Public Property BorderFocusedColor As ColorHSL = New ColorHSL(_baseHue, 0.0, 0.5, 1)
            Public Property BorderHoverColor As ColorHSL = BorderFocusedColor.AddLuminance(0.1).AddSaturation(0.1)
            Public Property ForeColor As ColorHSL = SystemColors.ControlText
            Public Property ForeHighlightColor As ColorHSL = ForeColor
            Public Property ForeReadonlyColor As ColorHSL = SystemColors.ControlText
        End Class

        <Serializable>
        Public Class ToolStripThemeColors
            Public Property MenuStripBackgroundDefaultColor As ColorHSL = New ColorHSL(_baseHue, 0.0, 0.9, 1)
            Public Property MenuStripBackgroundSelectedColor As ColorHSL = New ColorHSL(_baseHue, 0.75, 0.75, 1)
            Public Property MenuStripTextDefaultColor As ColorHSL = New ColorHSL(_baseHue, 0.0, 0.3, 1)
            Public Property MenuStripTextSelectedColor As ColorHSL = New ColorHSL(_baseHue, 0.0, 0.2, 1)

            Public Property DropdownBackgroundDefaultColor As ColorHSL = MenuStripBackgroundDefaultColor
            Public Property DropdownBackgroundSelectedColor As ColorHSL = MenuStripBackgroundSelectedColor
            Public Property DropdownTextDefaultColor As ColorHSL = MenuStripTextDefaultColor
            Public Property DropdownTextSelectedColor As ColorHSL = MenuStripTextSelectedColor
            Public Property SymbolImageColor As ColorHSL = DropdownTextDefaultColor

            Public Property BorderInnerColor As ColorHSL = DropdownBackgroundDefaultColor.AddLuminance(0.3)
            Public Property BorderOuterColor As ColorHSL = DropdownBackgroundDefaultColor.AddLuminance(0.15)
        End Class

        <Serializable>
        Public Class ToolStripButtonThemeColors
            Public Property BackColor As ColorHSL = SystemColors.Control
            Public Property BackHighlightColor As ColorHSL = _defaultBackHighlightColor
            Public Property ForeColor As ColorHSL = SystemColors.ControlText
            Public Property ForeHighlightColor As ColorHSL = ForeColor
        End Class

        <Serializable>
        Public Class TrackBarThemeColors
            Public Property BackColor As ColorHSL = SystemColors.Control
            Public Property BackHighlightColor As ColorHSL = _defaultBackHighlightColor
            Public Property ForeColor As ColorHSL = SystemColors.ControlText
            Public Property ForeHighlightColor As ColorHSL = ForeColor
        End Class

        <Serializable>
        Public Class TreeViewThemeColors
            Public Property BackColor As ColorHSL = SystemColors.Window
            Public Property BackAlternateColor As ColorHSL = BackColor.AddLuminance(-0.05)
            Public Property BackExpandedColor As ColorHSL = SystemColors.Control
            Public Property BackHighlightColor As ColorHSL = _defaultBackHighlightColor
            Public Property BackSelectedColor As ColorHSL = SystemColors.ControlLight
            Public Property ForeColor As ColorHSL = SystemColors.WindowText
            Public Property ForeExpandedColor As ColorHSL = ForeColor
            Public Property ForeHighlightColor As ColorHSL = ForeColor
            Public Property ForeSelectedColor As ColorHSL = SystemColors.ControlText
            Public Property LineColor As ColorHSL = SystemColors.WindowText
        End Class

        <Serializable>
        Public Class VideoRendererThemeColors
            Public Property BackColor As ColorHSL = SystemColors.Window
        End Class

    End Class


    Public Class GeneralThemeColors
        Private _controlsThemeColors As ControlsThemeColors

        Public Property Controls As ControlsThemeColors
            Get
                _controlsThemeColors = If(_controlsThemeColors, New ControlsThemeColors())
                Return _controlsThemeColors
            End Get
            Set(value As ControlsThemeColors)
                _controlsThemeColors = value
            End Set
        End Property

        Public Property BackColor As ColorHSL = SystemColors.Control
        Public Property ControlBackColor As ColorHSL = Color.Transparent
        Public Property DangerBackColor As ColorHSL = Color.Transparent
        Public Property DangerForeColor As ColorHSL = New ColorHSL(358, 1, 0.5, 1)
        Public Property ForeColor As ColorHSL = SystemColors.ControlText
    End Class

    Public Class AppsFormThemeColors
        Public Property AttentionForeColor As ColorHSL = New ColorHSL(358, 1, 0.3, 1)
        Public Property OkayForeColor As ColorHSL = New ColorHSL(120, 1, 0.3, 1)
    End Class

    Public Class CodeEditorThemeColors
        Public Property BackAccentColor As ColorHSL = SystemColors.Window
        Public Property ForeColor As ColorHSL = SystemColors.ControlDark
        Public Property ForeAccentColor As ColorHSL = SystemColors.WindowText
        Public Property RichTextBoxBorderColor As ColorHSL = SystemColors.ControlDark
        Public Property RichTextBoxBorderAccentColor As ColorHSL = SystemColors.ControlDark
        Public Property RichTextBoxForeColor As ColorHSL = SystemColors.ControlDark
        Public Property RichTextBoxForeAccentColor As ColorHSL = SystemColors.WindowText
    End Class

    Public Class CropFormThemeColors
        Public Property BackColor As ColorHSL = SystemColors.Window
        Public Property BorderColor As ColorHSL = SystemColors.ControlDark
        Public Property BorderSelectedColor As ColorHSL = SystemColors.Control
    End Class

    Public Class MainFormThemeColors
        Public Property laTipBackColor As ColorHSL = Color.Transparent
        Public Property laTipBackHighlightColor As ColorHSL = Color.Transparent
        Public Property laTipForeColor As ColorHSL = SystemColors.ControlText
        Public Property laTipForeHighlightColor As ColorHSL = New ColorHSL(355, 1, 0.5, 1)
    End Class
End Class


