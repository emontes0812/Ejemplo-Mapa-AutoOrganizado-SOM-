using System;



namespace Figuras_Viajero
{
	
	public class nodo
	{
		private double activacion;
		private double bias;
		public double []pesos;
		public double error;

		public nodo()
		{
			this.activacion = 0;
			this.error = 0;
		}
		
		public nodo(double act,double thr,int numOfweights)
		{
			this.activacion = act;
			this.bias = thr;
			this.pesos = new double[numOfweights];
		}

		public double Activacion
		{
			set	{activacion = value ;}
			get {return activacion;}
		}

		public double Bias
		{
			set {bias = value;}
			get {return bias;}
		}
	}

}
