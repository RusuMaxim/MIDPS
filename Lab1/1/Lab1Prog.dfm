object Form1: TForm1
  Left = 222
  Top = 202
  Width = 1142
  Height = 656
  Caption = 'MIDPS 1- A'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 480
    Top = 248
    Width = 20
    Height = 37
    Caption = '0'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clRed
    Font.Height = -32
    Font.Name = 'MS Sans Serif'
    Font.Style = [fsBold]
    ParentFont = False
  end
  object Label2: TLabel
    Left = 328
    Top = 112
    Width = 524
    Height = 37
    Caption = 'Incrementare decrementare contor'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clLime
    Font.Height = -32
    Font.Name = 'MS Sans Serif'
    Font.Style = [fsBold]
    ParentFont = False
  end
  object Button1: TButton
    Left = 152
    Top = 200
    Width = 81
    Height = 57
    Caption = 'Increment [+1]'
    TabOrder = 0
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 152
    Top = 304
    Width = 81
    Height = 57
    Caption = 'Decrement [-1]'
    TabOrder = 1
    OnClick = Button2Click
  end
end
