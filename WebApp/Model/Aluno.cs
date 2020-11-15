namespace WebApp.Model
{
    public class Aluno
    {
        public Aluno(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public int Teste()
        {
            return 10;
        }
       
    }
}