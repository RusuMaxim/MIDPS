//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
unsigned int sec=0;
unsigned int min=0;
unsigned int hour=0;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button1Click(TObject *Sender)
{
   Timer1->Enabled= true;     
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Timer1Timer(TObject *Sender)
{
   sec+=1;
   if(sec==60){min+=1; sec=0;}
   if(min==60){hour+=1; min=0;sec=0;}
   Label1->Caption = IntToStr(hour)+  " : " + IntToStr(min)+" : " +IntToStr(sec);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button2Click(TObject *Sender)
{
        Timer1->Enabled= false;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button3Click(TObject *Sender)
{
        sec=0;
        min=0;
        hour=0;
        Label1->Caption = " 0 : 0 : 0 ";
}
//---------------------------------------------------------------------------
