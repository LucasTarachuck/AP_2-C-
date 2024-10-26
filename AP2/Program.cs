Agencia agencia = new Agencia();
var DataInicio = new DateTime(2024, 05, 10, 14, 30, 00);
var DataFim = new DateTime(2024, 10, 10, 17, 30, 00);     
PacoteTuristico novoPacote = new PacoteTuristico("Bahamas", DataInicio, DataFim, 2500, 4, "1", "Lugar Bonito");

bool prosseguir = true; 

while(prosseguir)
{
    Console.WriteLine("====================================");
    Console.WriteLine("================MENU================");
    Console.WriteLine("====================================");

    Console.WriteLine("0: sair");
    Console.WriteLine("1: Cadastrar Destino");
    Console.WriteLine("2: Buscar destino pelo código");
    Console.WriteLine("3: Listar destinos");
    Console.WriteLine("4: Cadastrar Cliente");
    Console.WriteLine("5: Consultar cliente pelo código");
    Console.WriteLine("6: Listar clientes");
    Console.WriteLine("7: Cadastrar pacotes");
    Console.WriteLine("8: Buscar pacote pelo código");
    Console.WriteLine("9: Listar pacotes");
    Console.WriteLine("10: Reservar pacote");
    Console.WriteLine("11: Cancelar reserva");

    
    Console.WriteLine("Escolha uma opção");
    string opc = Console.ReadLine();

    switch (opc)
    {
        case "0":
            Console.WriteLine("Encerrando serviço...");
            prosseguir = false;
            break;
        case "1":
            
            Destino novoDestino = new Destino("Los Angeles", "Estados Unidos", "1", "Lugar bonito");
            bool existe = false;
            if (novoDestino == null)
            {
                Console.WriteLine("Não são aceitos destinos nulos");
                break;
            }
            foreach(var destino in agencia.Destinos)
            {
                if(novoDestino.NomeLocal == destino.NomeLocal && novoDestino.Pais == destino.Pais)
                {
                        existe = true;
                        break;
                }   
            }
            if(existe)
            {
                Console.WriteLine("Destino já cadastrado");
                break;
            }
            else
            {
                agencia.CadastrarDestino(novoDestino);
            }                              
        
        break;
        case "2":
            agencia.ConsultarDestinoPorCodigo("1");
            break;
        case "3":
            agencia.ListarDestinos();
            break;
        case "4":            
            Cliente novoCliente = new Cliente("Clietne", "1", "51 998058194");
            bool exist = false;
            if (novoCliente == null)
            {
                Console.WriteLine("Não são aceitos clientes nulos");
                break;
            }
            foreach(var cliente in agencia.Clientes)
            {
                if(novoCliente.Nome == cliente.Nome && novoCliente.NumeroIdentificacao == cliente.NumeroIdentificacao)
                {
                    exist = true;
                    break;
                }   
            }
            if(exist)
            {
                Console.WriteLine("Cliente já cadastrado");
                break;
            }
            else
            {
               agencia.CadastrarCliente(novoCliente);
            }                              
            
            break;
        case "5":
            agencia.ConsultarClientePorID("1");
            break;
        case "6":
            agencia.ListarClientes();
            break;
        case "7":
            bool jaExiste = false;
            if (novoPacote == null)
            {
                Console.WriteLine("Não são aceitos pacotes nulos");
                break;
            }
 
            foreach(var pacote in agencia.PacoteTuristicos)
            {
                if(novoPacote.Destino == pacote.Destino)
                {
                    jaExiste = true;
                    break;
                }   
            }
            if(jaExiste)
            {
                Console.WriteLine("Pacote já cadastrado");
                break;
            }
            else
            {
                agencia.CadastrarPacoteTuristico(novoPacote);
            }    
            break;
        case "8":
            agencia.ConsultarPacotePorCodigo("1");
            break;
        case "9":
            agencia.ListarPacotes();
            break;
        case "10":
            novoPacote.Reservar();
            break;
        case "11":
            novoPacote.Cancelar();
            break;
        default:
            Console.WriteLine("Escolha um opção válida");
            break;
    }
}
