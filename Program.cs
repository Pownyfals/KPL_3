using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modul3_1302204081;

//kode buah
KodeBuah buah = new KodeBuah();
Console.WriteLine("Kode Buah Apel : "+ buah.getKodeBuah(KodeBuah.NamaBuah.Apel));
Console.WriteLine("Kode Buah Alpukat : "+ buah.getKodeBuah(KodeBuah.NamaBuah.Alpukat));

//state 
PosisiKarakterGame state = new PosisiKarakterGame();
string input;
Console.WriteLine("Input Key");
input = Console.ReadLine();
while(input != "")
{
	Console.WriteLine(state.MessageState(input));
	Console.WriteLine("Input Key");
	input = Console.ReadLine();

}