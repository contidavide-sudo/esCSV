namespace esCSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ID = new List<string>();
            List<string> nome = new List<string>();
            List<string> categoria = new List<string>();
            List<string> prezzo = new List<string>();
            List<string> disponibilita = new List<string>();

            string[] arrPar;
            int sommaP = 0, numP=0;
            float media;

            using (StreamReader sr = new StreamReader("prodotti_abbigliamento.csv"))
            {
                string riga = sr.ReadLine(); 

                while (riga != null) 
                {
                    riga = sr.ReadLine();

                    arrPar = riga.Split(',');

                    ID.Add(arrPar[0]);
                    nome.Add(arrPar[1]);
                    categoria.Add(arrPar[2]);
                    prezzo.Add(arrPar[3]);

                    sommaP = sommaP + Convert.ToInt32(arrPar[3]);
                    numP++;

                    disponibilita.Add(arrPar[4]);

                }
            }

            media = sommaP / numP;


        }
    }
}
