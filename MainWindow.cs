using System;
using Gtk;
using Enigma;

public partial class MainWindow: Gtk.Window
{
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton1Clicked (object sender, EventArgs e)
	{

		int cont = 0;

		for (var i1=0;i1<5;i1++)
		{

			cont= cont+1;
			Guy g1= new Guy("yellow",e2.Text,"Kools",1,e5.Text,"Norwegian");
			Guy g2= new Guy("blue","horse",e9.Text,2,e11.Text,e12.Text);
			Guy G3 = new Guy(e13.Text,e14.Text,e15.Text,3,"Milk",e18.Text);
			Guy G4 = new Guy(e19.Text,e20.Text,e21.Text,4,e23.Text,e24.Text);
			Guy G5 = new Guy(e25.Text,e26.Text,e27.Text,5,e29.Text,e30.Text);

			e1.Text="yellow";
			e2.Text=g1.SAnimal;
			e3.Text=g1.SSmoke;
			e4.Text="1";
			e5.Text=g1.SDrink;
			e6.Text="Norwegian";
			e7.Text="blue";
			e8.Text="horse";
			e9.Text=g2.SSmoke;
			e10.Text="2";
			e11.Text=g2.SDrink;
			e12.Text=g2.SCountry;
			e13.Text=G3.SHouseColor;
			e14.Text=G3.SAnimal;
			e15.Text=G3.SSmoke;
			e16.Text="3";
			e17.Text="Milk";
			e18.Text=G3.SCountry;
			e19.Text=G4.SHouseColor;
			e20.Text=G4.SAnimal;
			e21.Text=G4.SSmoke;
			e22.Text="4";
			e23.Text=G4.SDrink;
			e24.Text=G4.SCountry;
			e25.Text=G5.SHouseColor;
			e26.Text=G5.SAnimal;
			e27.Text=G5.SSmoke;
			e28.Text="5";
			e29.Text=G5.SDrink;
			e30.Text=G5.SCountry;


		}
	}

	protected void OnButton2Clicked (object sender, EventArgs e)
	{
		GetSolucao gs = new GetSolucao ();
		gs.gime();
		
		e1.Text="yellow";
		e2.Text = gs.Solucao [3];
		e3.Text="Kools";
		e4.Text="1";
		e5.Text=gs.Solucao [11];
		e6.Text="Norwegian";

		e7.Text="blue";
		e8.Text="horse";
		e9.Text=gs.Solucao [7];
		e10.Text="2";
		e11.Text=gs.Solucao [12];
		e12.Text=gs.Solucao [15];

		e13.Text=gs.Solucao[0];
		e14.Text=gs.Solucao [4];
		e15.Text=gs.Solucao [8];
		e16.Text="3";
		e17.Text="Milk";
		e18.Text=gs.Solucao [16];

		e19.Text=gs.Solucao[1];
		e20.Text=gs.Solucao [5];
		e21.Text=gs.Solucao [9];
		e22.Text="4";
		e23.Text=gs.Solucao [13];
		e24.Text=gs.Solucao [17];

		e25.Text=gs.Solucao[2];
		e26.Text=gs.Solucao [6];
		e27.Text=gs.Solucao [10];
		e28.Text="5";
		e29.Text=gs.Solucao [14];
		e30.Text=gs.Solucao [18];
}
}

