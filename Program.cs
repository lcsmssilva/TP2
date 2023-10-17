using System;
class Program
{
    public class Personagem{
        private string nome;
        private int altura;
        private double peso;
        private string corDoCabelo;
        private string corDaPele;
        private string corDosOlhos;
        private string anoNascimento;
        private string genero;
        private string homeworld;
        public Personagem(string[] valores){

            SetNome(valores[0]);
            if(valores[1] == "unknown"){
                SetAltura(0);
            }
            else {
                SetAltura(int.Parse(valores[1]));
            }
            if(valores[2] == "unknown"){
                SetPeso(0);
            }
            else {
                SetPeso(double.Parse(valores[2]));
            }
            SetCorDoCabelo(valores[3]);
            SetCorDaPele(valores[4]);
            SetcorDosOlhos(valores[5]);
            SetAnoNascimento(valores[6]);
            SetGenero(valores[7]);
            SetHomeWorld(valores[7]);

        }

        public string SetNome(string name) { nome = name;}
        public int SetAltura(int alt) { altura = alt;}
        public double SetPeso(double pe) { peso = pe;}
        public string SetCorDoCabelo(string CorCabelo) { corDoCabelo = CorCabelo;}
        public string SetCorDaPele(string CorPele) { corDaPele = CorPele;}

        public string SetcorDosOlhos(string CorOlhos) { corDosOlhos = CorOlhos;}
        public string SetAnoNascimento(string Nascimento) { anoNascimento = Nascimento;}
        public string SetGenero(string Gender) { genero = Gender;}
        public string SetHomeWorld(string MundoNasc) { homeworld = MundoNasc;}

        public string GetNome(){return nome;}
        public int GetAltura(){return altura;}
        public double GetPeso(){return peso;}

        public string GetcorDoCabelo(){return corDoCabelo;}
        public string GetcorDaPele(){return corDaPele;}
        public string GetcorDosOlhos(){return corDosOlhos;}
        public string GetanoNascimento(){return anoNascimento;}
        public string Getgenero(){return genero;}
        public string Gethomeworld(){return homeworld;}


        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
