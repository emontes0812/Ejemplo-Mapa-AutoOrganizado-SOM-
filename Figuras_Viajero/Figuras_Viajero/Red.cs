using System;
using System.Windows.Forms;


namespace Figuras_Viajero
{
	public class Red
	{
		private int i;
		private int o;
		private int h;

		private double LH=0.9f; 
		private double LO=0.9f; 
		
		private double []entradas;
		private double []salidasdeseadas;

		private nodo []capaentrada; 
		private nodo []capasalida;
		private nodo []capaoculta;

		private double total_error;
		public double error_compared_to_tolerance=0;
		

		private double sigmoide(double x)
		{
			return 1/(1+Math.Exp(-x));
			
		}

		public Red(int inp , int hide , int outp)
		{
			i = inp ; o = outp ; h = hide;
			int ahm = 0;
			capaentrada = new nodo[i];
			capasalida = new nodo[o];
			capaoculta = new nodo[h];
			Random rand = new Random(unchecked((int)DateTime.Now.Ticks));
			for(int x=0 ; x<inp ; x++)
			{
				capaentrada[x] = new nodo();
				capaentrada[x].pesos = new double[this.h];
				for(int j=0 ; j<hide ; j++)
				{
					ahm =  rand.Next()& 1; 
					capaentrada[x].pesos[j] = rand.NextDouble() ;
					if(ahm == 0)
						capaentrada[x].pesos[j] *= -1;
				}

			}
			for(int y=0; y<hide ; y++)
			{
				capaoculta[y] = new nodo();
				capaoculta[y].pesos = new double[o];
				for(int j=0 ; j<outp ; j++)
					capaoculta[y].pesos[j] = rand.NextDouble();
			}
			for(int z=0 ; z<outp ; z++)
			{
				capasalida[z] = new nodo();
			}
		}
		

	
		public void Ajustes()
		{
			Random x = new Random(unchecked((int)DateTime.Now.Ticks)); 
			for(int i=0 ; i<h ; i++)
				capaoculta[i].Bias = x.NextDouble();
			for(int i=0 ; i<o ; i++)
				capasalida[i].Bias = x.NextDouble();
		}
		

	
		public void Entinicl(params double []list)
		{
			int counter=0;
			int j=0;
			int k=0;
			entradas = new double[i];
			salidasdeseadas = new double[o];

			while(counter < list.Length)
			{
				if( counter < i)
				{
					entradas[j] = list [counter];
					j++;
				}
				else
				{
					salidasdeseadas[k] = list[counter];
					k++;
				}
				counter++;
			}



		}


		public void Entrenamiento(double[,] listaentrada, double[,] listasalida, int iteraciones, ProgressBar progressBar1)
		{
			entradas = new double[i];
			salidasdeseadas = new double[o];

			int outputlistSampleLength = listasalida.GetUpperBound(0) + 1;
			int outputlistLength = listasalida.GetUpperBound(1) + 1;
			int inputlistLength = listaentrada.GetUpperBound(1) + 1;

			progressBar1.Minimum = 0;
			progressBar1.Maximum = iteraciones;
			progressBar1.Value = 0;

			for (int ix = 0; ix < iteraciones; ix++)
			{
				progressBar1.Value ++;
				for (int x = 0; x < outputlistSampleLength; x++)
				{
					for (int j = 0; j < inputlistLength; j++)
					{
						entradas[j] = listaentrada[x, j];
					}

					for (int k = 0; k < outputlistLength; k++)
					{
						salidasdeseadas[k] = listasalida[x, k];
					}


                    Entpatron();
				}
			}
		}

		void Completarentradaasignada(double[,] listaentrada, int p)
		{
				for (int j = 0; j < listaentrada.GetUpperBound(1) + 1; j++)
				{
					entradas[j] = listaentrada[p, j];
                    //System.Console.WriteLine(entradas[j]);
                   //entradas[0] = 1;
                   //entradas[1] = 1;
				}
		}

	
		public double[] Test(double[] listaentrada)
		{
            for (int j = 0; j <i; j++)
            {
                entradas[j] = listaentrada[j];
            }
			//Completarentradaasignada(listaentrada, q);
			this.Calc_Activacion();
			double [] temp = impsalida();
			return temp;
		}


	
		public void Entpatron()
		{
			Calc_Activacion();
			Calc_error_salida();
			Calc_error_ocultas();
			Calc_nuevo_bias();
			Nuevos_pesos_oculta();
			Nuevos_pesos_entrada();
		}

		
		private void Calc_Activacion()
		{
		
			int ch=0;
			while(ch<h)
			{
				for(int ci=0 ; ci<i ; ci++)
					capaoculta[ch].Activacion += entradas[ci] * capaentrada[ci].pesos[ch];

				ch++;
			}

			for(int x=0 ; x<h ; x++)
			{
				capaoculta[x].Activacion += capaoculta[x].Bias ;
				capaoculta[x].Activacion = sigmoide(capaoculta[x].Activacion );
			}
			int co=0;
			while(co<o)
			{
				for(int chi=0 ; chi<h ; chi++)
					capasalida[co].Activacion += capaoculta[chi].Activacion  * capaoculta[chi].pesos[co];

				co++;
			}
			for(int x=0 ; x<o ; x++)
			{
				capasalida[x].Activacion += capasalida[x].Bias ;
				capasalida[x].Activacion = sigmoide(capasalida[x].Activacion );
			}


		}

		public double[] impsalida()
		{
			double[] outp=new double [o];
			for(int x=0 ; x<o ; x++)
			{
                //System.Console.WriteLine(capasalida[x].Activacion);
				outp[x]=capasalida[x].Activacion;
			}
			return outp;

		}


		private void Calc_error_salida()
		{
			for(int x=0 ; x<o ; x++)
				capasalida[x].error = capasalida[x].Activacion * (1 - capasalida[x].Activacion ) * (salidasdeseadas[x] - capasalida[x].Activacion );
		}


		private void Calc_error_ocultas()
		{
			int y=0;
			while(y<h)
			{
				for(int x=0 ; x<o ; x++)
				{
					capaoculta[y].error += capaoculta[y].pesos[x] * capasalida[x].error ; 
				}
				capaoculta[y].error *= capaoculta[y].Activacion * (1 - capaoculta[y].Activacion );
				y++;
			}

		}

		
		private void Calc_nuevo_bias()
		{
			for(int x=0 ; x<h ; x++)
				capaoculta[x].Bias +=  capaoculta[x].error * LH ;
			for(int y=0 ; y<o ; y++)
				capasalida[y].Bias += capasalida[y].error * LO;
		}


		private void Nuevos_pesos_oculta()
		{
			int x=0;
			double temp=0.0f;
			while(x < h)
			{
				temp = capaoculta[x].Activacion * LO;
				for(int y=0 ; y<o ; y++)
				{
					capaoculta[x].pesos[y] += temp * capasalida[y].error;
				}
				x++;
			}
		}


		private void Nuevos_pesos_entrada()
		{
			int x=0;
			double temp=0.0f;
			while(x < i)
			{
				temp = entradas[x] * LH;
				for(int y=0 ; y<h ; y++)
				{
					capaentrada[x].pesos[y] += temp * capaoculta[y].error;
				}
				x++;
			}

		}

		
		public double Calc_errortotal_patron()
		{
			double temp=0.0f;
			for(int x=0 ; x<o ; x++)
				temp+=capasalida[x].error;
			return total_error;
		}

		public void reset_total_error()
		{
			total_error = 0;
		}






	}
}
