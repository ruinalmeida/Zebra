/*
 * Created by Rui de Almeida
 * Date: 03/11/2013
 * Time: 23:26
 * 
 * Solving the Zebra puzzle
 * 
 * 1. There are five houses.
 * 2. The Englishman lives in the red house.
 * 3. The Spaniard owns the dog.
 * 4. Coffee is drunk in the green house.
 * 5. The Ukrainian drinks tea.
 * 6. The green house is immediately to the right of the ivory house.
 * 7. The Old Gold smoker owns snails.
 * 8. Kools are smoked in the yellow house.
 * 9. Milk is drunk in the middle house.
 * 10. The Norwegian lives in the first house.
 * 11. The man who smokes Chesterfields lives in the house next to the man with the fox.
 * 12. Kools are smoked in the house next to the house where the horse is kept.
 * 13. The Lucky Strike smoker drinks orange juice.
 * 14. The Japanese smokes Parliaments.
 * 15. The Norwegian lives next to the blue house.
 * 
 * Now, who drinks water? Who owns the zebra?
 * 
 */


using System;
using System.Collections;
namespace Enigma
{

	public class Guy
	{
		public Guy(string sHouseColor, string sAnimal, string sSmoke, int iOrder , string sDrink, string sCountry)
		{
			this.iOrder=iOrder;
			this.sHouseColor=sHouseColor;
			this.sAnimal=sAnimal;
			this.sSmoke=sSmoke;
			this.sDrink=sDrink;
			this.sCountry=sCountry;
		}
		private int iOrder;
		public int IOrder
		{
			get { return iOrder; }
			set { iOrder = value; }
		}
		private string sHouseColor;
		public string SHouseColor
		{
			get { return sHouseColor; }
			set { sHouseColor = value; }
		}
		private string sAnimal;
		public string SAnimal
		{
			get { return sAnimal; }
			set { sAnimal = value; }
		}
		private string sSmoke;
		public string SSmoke
		{
			get { return sSmoke; }
			set { sSmoke = value; }
		}
		private string sDrink;
		public string SDrink
		{
			get { return sDrink; }
			set { sDrink = value; }
		}
		private string sCountry;
		public string SCountry
		{
			get { return sCountry; }
			set { sCountry = value; }
		}

	}
	public class GetSolucao
	{
		public string[] Solucao = new string[19];
		bool tesSol= false;
		static string color1;
		static string color2;
		static string color3;
		static string animal1;
		static string animal2;
		static string animal3;
		static string animal4;
		static string smoke11;
		static string smoke12;
		static string smoke13;
		static string smoke14;
		static string drink1;
		static string drink2;
		static string drink3;
		static string drink4;
		static string country1;
		static string country2;
		static string country3;
		static string country4;

		public  void  gime()
		{
			if (tesSol) return;
			string[] cores = new string[] { "ivory", "Red", "Green" };
			for (int k = 0; (ulong)k < StringPerm.FactorialLookup(3); ++k)
			{
				StringPerm p = new StringPerm(cores, k);
				color1 = p.element[0].ToString();
				color2  = p.element[1].ToString();
				color3 = p.element[2].ToString();
				gimeAnimais( new string[] {"snails", "Dog", "fox", "Zebra"});
			}

		}
		/// <summary>
		/// Gime the animals.
		/// </summary>
		public void gimeAnimais(string[] atoms)
		{
			if (tesSol) return;
			for (int k = 0; (ulong)k < StringPerm.FactorialLookup(4); ++k)
			{
				StringPerm p = new StringPerm(atoms, k);
				animal1 = p.element[0].ToString();
				animal2 =  p.element[1].ToString();
				animal3=  p.element[2].ToString();
				animal4=  p.element[3].ToString();
				gimesmoke1(new string[] {"Parliaments", "Lucky Strike", "Chesterfield", "Old Gold"});
			}

		}

		/// <summary>
		/// Gime the smoke1.
		/// </summary>
		public void gimesmoke1(string[] smoke1s)
		{
			if (tesSol) return;
			for (int k = 0; (ulong)k < StringPerm.FactorialLookup(4); ++k)
			{
				StringPerm p = new StringPerm(smoke1s, k);
				smoke11 = p.element[0].ToString();
				smoke12 =  p.element[1].ToString();
				smoke13 =  p.element[2].ToString();
				smoke14 =  p.element[3].ToString();
				gimedrinks(new string[] {"Coffee", "Tea", "orange juice", "Water"});
			}

		}

		/// <summary>
		/// Gime the drinks.
		/// </summary>
		public void gimedrinks(string[] drinks)
		{
			if (tesSol) return;
			for (int k = 0; (ulong)k < StringPerm.FactorialLookup(4); ++k)
			{
				StringPerm p = new StringPerm(drinks, k);
				drink1= p.element[0].ToString();
				drink2=  p.element[1].ToString();
				drink3=  p.element[2].ToString();
				drink4=  p.element[3].ToString();
				gimecountrys(new string[] {"Spaniard", "Ukrainian", "Englishman", "Japanese"});
			}

		}
		/// <summary>
		/// Gimes the countries.
		/// </summary>
		public void gimecountrys(string[] countrys)
		{
			if (tesSol) return;
			for (int k = 0; (ulong)k < StringPerm.FactorialLookup(4); ++k) {
				StringPerm p = new StringPerm (countrys, k);
				country1 = p.element [0].ToString ();
				country2 = p.element [1].ToString ();
				country3 = p.element [2].ToString ();
				country4 = p.element [3].ToString ();



				Guy[] vizinhosArray = new Guy[5] {
					new Guy ("yellow", animal1, "Kools", 1, drink1, "Norwegian"),
					new Guy ("blue", "horse", smoke11, 2, drink2, country1),
					new Guy (color1, animal2, smoke12, 3, "Milk", country2),
					new Guy (color2, animal3, smoke13, 4, drink3, country3),
					new Guy (color3, animal4, smoke14, 5, drink4, country4),

				};
				Vizinhos vizinhoslist= new Vizinhos(vizinhosArray);
				bool val = vizinhoslist.Valida();
				if (val==true)
				{
					tesSol = true;
					Solucao[0] =color1;
					Solucao[1] =color2;
					Solucao[2] =color3;
					Solucao[3] =animal1;
					Solucao[4] =animal2;
					Solucao[5] =animal3;
					Solucao[6] =animal4;
					Solucao[7] =smoke11;
					Solucao[8] =smoke12;
					Solucao[9] =smoke13;
					Solucao[10] =smoke14;
					Solucao[11] =drink1;
					Solucao[12] =drink2;
					Solucao[13] =drink3;
					Solucao[14] =drink4;
					Solucao[15] =country1;
					Solucao[16] =country2;
					Solucao[17] =country3;
					Solucao[18] =country4;

				}

			}}


	}
	public class Vizinhos : IEnumerable
	{
		private Guy[] _vizinhos;
		public Vizinhos(Guy[] pArray)
		{
			_vizinhos = new Guy[pArray.Length];

			for (int i = 0; i < pArray.Length; i++)
			{
				_vizinhos[i] = pArray[i];
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator) GetEnumerator();
		}

		public VizinhosEnum GetEnumerator()
		{
			return new VizinhosEnum(_vizinhos);
		}

		public  bool Valida()
		{


			return Valida2(this) & Valida3(this) & Valida4(this) & Valida5(this) & Valida6(this) & Valida7(this) & Valida8(this) & Valida9(this) & Valida10(this) & Valida11(this) & Valida12(this) & Valida13(this) & Valida14(this) & Valida15(this);

		}
		
		//2. The Englishman lives in the red house.
		public Boolean Valida2(Vizinhos e)
		{
			Boolean retorno = true;
			foreach (Guy g in e)
			{
				if (g.SCountry=="Englishman" && g.SHouseColor !="Red")
				{
					retorno = false;
				}
			}
			return retorno;
		}
		
		//3. The Spaniard owns the dog.
		public Boolean Valida3(Vizinhos e)
		{
			Boolean retorno = true;
			foreach (Guy g in e)
			{
				if (g.SCountry=="Spaniard" && g.SAnimal !="Dog")
				{
					retorno = false;
				}
			}
			return retorno;
		}
		
		//4. Coffee is drunk in the green house.
		public Boolean Valida4(Vizinhos e)
		{
			Boolean retorno = true;
			foreach (Guy g in e)
			{
				if (g.SHouseColor =="Green"  && g.SDrink  !="Coffee")
				{
					retorno = false;
				}
			}
			return retorno;
		}
		
		//5. The Ukrainian drinks tea.
		public Boolean Valida5(Vizinhos e)
		{
			Boolean retorno = true;
			foreach (Guy g in e)
			{
				if (g.SCountry =="Ukrainian"  && g.SDrink  !="Tea")
				{
					retorno = false;
				}
			}
			return retorno;
		}
		
		//6. The green house is immediately to the right of the ivory house.
		public Boolean Valida6(Vizinhos e)
		{
			Boolean retorno = true;
			foreach (Guy g in e)
			{
				foreach (Guy g1 in e)
				{
					if (g.SHouseColor =="Green" && g1.SHouseColor =="ivory")
					{

						if (g.IOrder != g1.IOrder-1)
						{
							retorno = false;
						}
					}
				}
			}
			return retorno;
		}
		
		//7. O fumador de Marlboro tem uma snails The Old Gold smoker owns snails.

		public Boolean Valida7(Vizinhos e)
		{
			Boolean retorno = true;
			foreach (Guy g in e)
			{
				if (g.SSmoke =="Old Gold"  && g.SAnimal  !="snails")
				{
					retorno = false;
				}
			}
			return retorno;
		}
		
		//8. Kools are smoked in the yellow house.

		public Boolean Valida8(Vizinhos e)
		{
			Boolean retorno = true;
			foreach (Guy g in e)
			{
				if (g.SHouseColor =="yellow"  && g.SSmoke  !="Kools")
				{
					retorno = false;
				}
			}
			return retorno;
		}
		
		//9. Milk is drunk in the middle house.

		public Boolean Valida9(Vizinhos e)
		{
			Boolean retorno = true;
			foreach (Guy g in e)
			{
				if (g.IOrder ==3  && g.SDrink  !="Milk")
				{
					retorno = false;
				}
			}
			return retorno;
		}
		
		//10. The Norwegian lives in the first house.

		public Boolean Valida10(Vizinhos e)
		{
			Boolean retorno = true;
			foreach (Guy g in e)
			{
				if (g.IOrder ==1  && g.SCountry   !="Norwegian")
				{
					retorno = false;
				}
			}
			return retorno;
		}
		
		//11. The man who smokes Chesterfields lives in the house next to the man with the fox.

		public Boolean Valida11(Vizinhos e)
		{
			Boolean retorno = false;
			foreach (Guy g in e)
			{
				foreach (Guy g1 in e)
				{
					if  ( g.SSmoke=="Chesterfield" && ( g.IOrder -g1.IOrder ==1  ||  g.IOrder -g1.IOrder == -1 ))
					{
						if (g1.SAnimal == "fox")
						{
							retorno = true;
						}
					}
				}
			}
			return retorno;
		}
		
		//12. Kools are smoked in the house next to the house where the horse is kept.

		public Boolean Valida12(Vizinhos e)
		{
			Boolean retorno = false;
			foreach (Guy g in e)
			{
				foreach (Guy g1 in e)
				{
					if  ( g.SAnimal  =="horse" && ( g.IOrder -g1.IOrder ==1  ||  g.IOrder -g1.IOrder == -1 ))
					{
						if (g1.SSmoke == "Kools")
						{
							retorno = true;
						}
					}
				}
			}
			return retorno;
		}
		
		//13. The Lucky Strike smoker drinks orange juice.

		public Boolean Valida13(Vizinhos e)
		{
			Boolean retorno = true;
			foreach (Guy g in e)
			{
				if (g.SSmoke =="Lucky Strike"  && g.SDrink   !="orange juice")
				{
					retorno = false;
				}
			}
			return retorno;
		}
		
		//14. The Japanese smokes Parliaments.

		public Boolean Valida14(Vizinhos e)
		{
			Boolean retorno = true;
			foreach (Guy g in e)
			{
				if (g.SCountry =="Japanese"  && g.SSmoke   !="Parliaments")
				{
					retorno = false;
				}
			}
			return retorno;
		}
		
		//15. The Norwegian lives next to the blue house.
		
		public Boolean Valida15(Vizinhos e)
		{
			Boolean retorno = false;
			foreach (Guy g in e)
			{
				foreach (Guy g1 in e)
				{
					if  ( g.SCountry  =="Norwegian" && ( g.IOrder -g1.IOrder ==1  ||  g.IOrder -g1.IOrder == -1 ))
					{
						if (g1.SHouseColor == "blue")
						{
							retorno = true;
						}
					}
				}
			}
			return retorno;
		}


	}

	public class VizinhosEnum : IEnumerator
	{
		public Guy[] _vizinhos;

		// Enumerators are positioned before the first element
		// until the first MoveNext() call.
		int position = -1;

		public VizinhosEnum(Guy[] list)
		{
			_vizinhos = list;
		}

		public bool MoveNext()
		{
			position++;
			return (position < _vizinhos.Length);
		}

		public void Reset()
		{
			position = -1;
		}

		object IEnumerator.Current
		{
			get
			{
				return Current;
			}
		}

		public Guy Current
		{
			get
			{
				try
				{
					return _vizinhos[position];
				}
				catch (IndexOutOfRangeException)
				{
					throw new InvalidOperationException();
				}
			}
		}


	}
}
