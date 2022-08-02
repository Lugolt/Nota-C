namespace PrimeirosPassosCom2
{
    public class Program
    {

        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;

            var opcaoUser = ObterOpcaoUser();
            while (opcaoUser != "4")
            {
                switch (opcaoUser)
                {
                    case "1":
                        try
                        {
                            Console.WriteLine("");
                            Console.Write("informe o nome do aluno: ");
                            Aluno aluno = new Aluno();
                            aluno.Nome = Console.ReadLine();
                            Console.WriteLine("");
                            Console.Write("informe a nota do aluno: ");
                            aluno.Nota = decimal.Parse(Console.ReadLine());
                            alunos[indiceAluno] = aluno;
                            indiceAluno++;
                            break;
                        }
                        catch
                        {
                            throw new ArgumentException("valor deve ser numerico");
                        }
                    case "2":
                        foreach( var i in alunos)
                        {
                            if(!string.IsNullOrEmpty(i.Nome))
                            {
                                Console.WriteLine("");
                                Console.WriteLine($"Aluno: {i.Nome} - Nota:  {i.Nota}");
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("");
                        decimal notaTotal = 0;
                        decimal nrAlunos = 0;
                        
                        for (int i = 0;i<alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal += alunos[i].Nota;
                                nrAlunos++;
                            }
                        }
                        var mediaGeral = notaTotal / nrAlunos;
                        Console.WriteLine($"A media geral foi de: {mediaGeral}");

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUser = ObterOpcaoUser();
            }
        }

        private static string ObterOpcaoUser()
        {
            Console.WriteLine("");
            Console.WriteLine("Informe a opção: ");
            Console.WriteLine("1 - Inserir aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular media geral");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("");

            string opcaoUser = Console.ReadLine();
            return opcaoUser;
        }
    }
}