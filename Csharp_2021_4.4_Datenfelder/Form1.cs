using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_4._4_Datenfelder
{
	public partial class Form1 : Form
	{
		private readonly Random r = new Random();

		public Form1()
		{
			InitializeComponent();
		}

		private void btnAnzeigen1_Click(object sender, EventArgs e)
		{
			// Datenfeld deklarieren
			int[] a;

			// Datenfeld erzeugen
			a = new int[7];

			// ListBox leeren
			lstFeld.Items.Clear();

			// For-Schleife über alle Einträge des Feldes
			// Index beginnt wie bei der ListBox bei 0
			for (int i = 0; i < 7; i++)
			{
				// Datenfeld mit Zufallszahlen befüllen
				a[i] = r.Next(20, 31);
				lstFeld.Items.Add(a[i]);
			}
		}

		private void btnAnzeigen2_Click(object sender, EventArgs e)
		{
			// Datenfeld deklarieren und erzeugen
			int[] a = new int[7];

			// Variablen für Min- und Max-Werte deklarieren
			int MaxWert, MinWert, MaxWertIndex, MinWertIndex;

			// ListBox leeren
			lstFeld.Items.Clear();

			// Zufallszahlen erzeugen und in ListBox eintragen
			for (int i = 0; i < a.Length; i++)
			{
				a[i] = r.Next(20, 31);
				lstFeld.Items.Add(a[i]);
			}

			// Vorschlag 1: 
			// - Datenfeld sortieren
			//	- Index 0 = Niedrigster Wert
			//	- Index 6 = Höchster Wert

			// Vorschlag 2: 
			// - Visual Studion besitzt eine Methode, die Min- und
			//   Max-Werte zurückgibt

			// MinWert = a.Min();
			// MaxWert = a.Max();
			// MinWertIndex = Array.IndexOf(a, MinWert);
			// MaxWertIndex = Array.IndexOf(a, MaxWert);

			// Vorschlag 3:
			// - Zahl in Zwischenspeicher speichern und alle Elemente durchlaufen.
			//   Falls Zahl größer (kleiner) als gespeicherte Zahl ist, gespeicherte 
			//	 Zahl ersetzen

			// Variablen initialisieren
			MaxWert = a[0];
			MinWert = a[0];
			MaxWertIndex = 0;
			MinWertIndex = 0;

			// Feld durchsuchen
			for (int i = 0; i < a.Length; i++)
			{
				// Prüfen, ob aktueller Wert größer als bisheriger 
				// Max-Wert ist
				if (a[i] > MaxWert)
				{
					MaxWert = a[i];
					MaxWertIndex = i;
				}

				// Prüfen, ob aktueller Wert kleiner als bisheriger 
				// Min-Wert ist
				if (a[i] < MinWert)
				{
					MinWert = a[i];
					MinWertIndex = i;
				}
			}

			lblAusgabe.Text =
				"Max. Wert: " + MaxWert + " bei Index " + MaxWertIndex + "\n" +
				"Min. Wert: " + MinWert + " bei Index " + MinWertIndex;
		}

		private void btnAnzeigen3_Click(object sender, EventArgs e)
		{
			int[] a = new int[7], b;
			int SuchIndex;

			// Zufallszahlen erstellen und speichern
			for (int i = 0; i < a.Length; i++)
			{
				a[i] = r.Next(20, 31);
			}

			// Kopie des bestehenden Feldes a erstellen und in b speichern
			b = (int[])a.Clone();

			// Feld sortieren
			Array.Sort(b);

			// Sortiertes Feld anzeigen
			lstFeld.Items.Clear();
			for (int i = 0; i < b.Length; i++)
			{
				lstFeld.Items.Add(b[i]);
			}

			// Index der gesuchten Zahl bestimmen
			SuchIndex = Array.IndexOf(b, 25);

			// Gesuchten Wert anzeigen
			lblAusgabe.Text = "Gesuchter Wert 25 bei Index: " + SuchIndex;
		}
	}
}
