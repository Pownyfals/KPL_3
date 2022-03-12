using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302204081
{
	public class PosisiKarakterGame
	{
		//1302204081 % 3 = 0
		private enum StateKarakter {BERDIRI,TERBANG,TENGKURAP,JONGKOK};
		private enum Trigger { W,S};
		private StateKarakter currentState;

		//tidak ada perintah perubahan state dari soal, hanya menampilkan output
		public string MessageState(string x)
		{
			if(x == "S" || x=="s")
			{
				return "Tombol Arah Bawah Ditekan";
			}
			else if(x == "W" || x=="w")
			{
				return "Tombol arah atas ditekan";
			}
			return "";
		}

		

		
	}

	
}


